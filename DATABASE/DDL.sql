CREATE TABLE tbl_Addresses(
		Addr_id INT AUTO_INCREMENT,
		Address VARCHAR(30) NOT NULL,
		County VARCHAR(20) NOT NULL,
		City VARCHAR (15)NOT NULL,
		Postcode VARCHAR(10) NOT NULL,
		CONSTRAINT pk_Addresses PRIMARY KEY (Addr_id) 
		

);

CREATE TABLE tbl_Students (
	Student_id INT AUTO_INCREMENT,
	stu_FirstName VARCHAR(20) NOT NULL,
	stu_LastName VARCHAR(20) NOT NULL,
	stu_DOB DATE NOT NULL,
	stu_Gender VARCHAR(15) NOT NULL,
	stu_Email VARCHAR(40) NOT NULL,
	stu_Phone VARCHAR(15) NOT NULL,
	Addr_id INT,
	CONSTRAINT pk_Student PRIMARY KEY (Student_id),
	CONSTRAINT fk_StudentAddr FOREIGN KEY (Addr_id) REFERENCES tbl_Addresses(Addr_id) ON UPDATE NO ACTION ON DELETE NO ACTION 
	
	
);

CREATE TABLE tbl_Teachers (
	Teacher_id INT AUTO_INCREMENT,
	FirstName VARCHAR(20) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	DOB DATE NOT NULL,
	Gender VARCHAR(15) NOT NULL,
	Email VARCHAR(40) NOT NULL,
	Phone VARCHAR(15) NOT NULL,
	Addr_id INT,
	CONSTRAINT pk_Teacher PRIMARY KEY (Teacher_id),
	CONSTRAINT fk_TeacherAddress FOREIGN KEY (Addr_id) REFERENCES tbl_Addresses(Addr_id) ON UPDATE NO ACTION ON DELETE NO ACTION	
	
);

CREATE TABLE tbl_Subjects (
	Sub_id INT AUTO_INCREMENT,
	Sname VARCHAR(20) NOT NULL,
	Sdesc VARCHAR(255) NOT NULL,
	C_StartDate DATE NOT NULL,
	C_EndDate DATE NOT NULL,
	Building_Name VARCHAR(30) NOT NULL,
	CONSTRAINT pk_Subject PRIMARY KEY (Sub_id)
);

CREATE TABLE tbl_Courses (
	Course_id INT AUTO_INCREMENT,
	Sub_id INT,
	Addr_id INT,
	Teacher_id INT,
	CONSTRAINT pk_Course PRIMARY KEY (Course_id),
	CONSTRAINT fk_CourseSubject FOREIGN KEY (Sub_id) REFERENCES tbl_Subjects(Sub_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_CourseAddress FOREIGN KEY (Addr_id) REFERENCES tbl_Addresses(Addr_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_CourseTeacher FOREIGN KEY (Teacher_id) REFERENCES tbl_Teachers(Teacher_id) ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE tbl_Enrollments (
	Enrollment_id INT AUTO_INCREMENT,
	Student_id INT,
	Course_id INT,
	DOE DATE NOT NULL,
	CONSTRAINT pk_Enrollment PRIMARY KEY (Enrollment_id),
	CONSTRAINT fk_EnrollmentStudent FOREIGN KEY (Student_id) REFERENCES tbl_Students(Student_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_EnrollmentCourse FOREIGN KEY (Course_id) REFERENCES tbl_Courses(Course_id) ON UPDATE NO ACTION ON DELETE NO ACTION

);


CREATE TABLE tbl_Class (
	Class_id INT AUTO_INCREMENT,
	Room VARCHAR(10) NOT NULL,
	Teacher_id INT,
	Enrollment_id INT,
	TIme_id INT,
	File_id INT,
	CONSTRAINT pk_Class PRIMARY KEY (Class_id),
	CONSTRAINT fk_ClassTeacher FOREIGN KEY (Teacher_id) REFERENCES tbl_Teachers(Teacher_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_ClassEnrollment FOREIGN KEY (Enrollment_id) REFERENCES tbl_Enrollments(Enrollment_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_ClassTime FOREIGN KEY (Time_id) REFERENCES tbl_Time(Time_id) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT fk_ClassFile FOREIGN KEY (File_id) REFERENCES tbl_Files(File_id) ON UPDATE NO ACTION ON DELETE NO ACTION
);
