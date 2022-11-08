/* Get Addresses*/
DELIMITER //
CREATE PROCEDURE sp_getAddresses()
BEGIN 
	SELECT * FROM tbl_Addresses;
END//
DELIMITER ;

CALL sp_getAddresses();

/* Get Address*/
DELIMITER //
CREATE PROCEDURE sp_getAddress(id INT)
BEGIN 
	SELECT * FROM tbl_Addresses WHERE Addr_id = id;
END//
DELIMITER ;

CALL sp_getAddress(3);

DELIMITER //
CREATE PROCEDURE sp_InsertAddress(
	IN Address VARCHAR(30), 
	IN County VARCHAR(20), 
	IN City VARCHAR(15), 
	IN Postcode VARCHAR(10) 
	)

BEGIN 
	INSERT INTO tbl_Addresses VALUES (0,Address, County, City, Postcode);
END//
DELIMITER ;

CALL sp_InsertAddress("adad", "kaldk","adada", "adawaw");



/* Delete Address*/

DELIMITER //
CREATE PROCEDURE sp_deleteAddresses(id INT)

BEGIN 
	DELETE FROM tbl_Addresses WHERE Addr_id = id;
END//
DELIMITER ;

CALL sp_deleteAddresses(2);


DELIMITER //
CREATE PROCEDURE sp_UpdateAddress(id INT,apAddress VARCHAR(30), apCounty VARCHAR(20), apCity VARCHAR(15), apPostcode VARCHAR(10) )

BEGIN 
	UPDATE tbl_Addresses
	SET
		Address = apAddress,
		County = apCounty,
		City = apCity,
		Postcode = apPostcode
	WHERE Addr_id = id;
END//
DELIMITER ;

CALL sp_UpdateAddress(2,"adaasdd", "kagggldk","advareda", "adayukywaw");

/* Students SP's*/

DELIMITER //
CREATE PROCEDURE sp_getStudents()
BEGIN 
	SELECT * FROM tbl_Students;
END//
DELIMITER ;

CALL sp_getStudents();

DELIMITER //
CREATE PROCEDURE sp_getStudent()
BEGIN 
	SELECT tbl_Students.Student_id, tbl_Students.stu_FirstName, tbl_Students.stu_LastName, tbl_Students.stu_DOB, tbl_Students.stu_Gender,tbl_Students.stu_Email,tbl_Students.stu_Phone ,tbl_Students.Addr_id, tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
	FROM tbl_Students INNER JOIN tbl_Addresses ON tbl_Students.Addr_id = tbl_Addresses.Addr_id;
END//
DELIMITER ;

CALL sp_getStudent(2);

DELIMITER //
CREATE PROCEDURE sp_InsertStudent(Sfname VARCHAR(20), Slname VARCHAR(20), SDOB DATE, Sgender VARCHAR(15),SEmail VARCHAR(40),SPhone VARCHAR(15) ,Saddr INT )

BEGIN 
	INSERT INTO tbl_Students VALUES (0,Sfname, Slname, SDOB, Sgender,Saddr,SEmail,SPhone);
END//
DELIMITER ;

CALL sp_InsertStudent("Jake", "Smith",'2001-4-24',"ac@gmail.com","07235352", "Male", 9);



DELIMITER //
CREATE PROCEDURE sp_UpdateStudents(id INT,Sfname VARCHAR(20), Slname VARCHAR(20), SDOB DATE, Sgender VARCHAR(15), SEmail VARCHAR(40), SPhone VARCHAR(15))

BEGIN 
	UPDATE tbl_Students
	SET
		stu_FirstName = Sfname,
		stu_LastName = Slname,
		stu_DOB = SDOB,
		stu_Gender = Sgender,
		stu_Email = SEmail,
		stu_Phone = SPhone
	WHERE Student_id = id;
END//
DELIMITER ;

CALL sp_UpdateAddress("adaasdd", "kagggldk","advareda", "adayukywaw","ac@7678.com","07133899",3);

DELIMITER //
CREATE PROCEDURE sp_deleteStudent(id INT)

BEGIN 
	DELETE FROM tbl_Students WHERE Student_id = id;
END//
DELIMITER ;

CALL sp_deleteStudent(1);

/* TEACHERS SP's*/

DELIMITER //
CREATE PROCEDURE sp_getTeachers()
BEGIN 
	SELECT * FROM tbl_Teachers;
END//
DELIMITER ;

CALL sp_getTeachers();

DELIMITER //
CREATE PROCEDURE sp_getTeacher(id INT)
BEGIN 
	SELECT tbl_Teachers.Teacher_id, tbl_Teachers.FirstName, tbl_Teachers.LastName, tbl_Teachers.DOB, tbl_Teachers.Gender,tbl_Teachers.Email,tbl_Teachers.Phone, tbl_Teachers.Addr_id, tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
	FROM tbl_Teachers INNER JOIN tbl_Addresses ON tbl_Teachers.Addr_id = tbl_Addresses.Addr_id;
END//
DELIMITER ;

CALL sp_getTeacher(1);

DELIMITER //
CREATE PROCEDURE sp_InsertTeacher(Tfname VARCHAR(20), Tlname VARCHAR(20), TDOB DATE, Tgender VARCHAR(15),TEmail VARCHAR(40),TPhone VARCHAR(15), Taddr INT )

BEGIN 
	INSERT INTO tbl_Teachers (FirstName,LastName,DOB,Gender,Email,Phone,Addr_id) VALUES (0,Tfname, Tlname, TDOB, Tgender,TEmail,TPhone,0);
END//
DELIMITER ;

CALL sp_InsertTeacher("Jake", "Smith",'2001-4-24', "Male","bc@242342.com","071237675", 3);



DELIMITER //
CREATE PROCEDURE sp_UpdateTeacher(id INT,Tfname VARCHAR(20), Tlname VARCHAR(20), TDOB DATE, Tgender VARCHAR(15), TEmail VARCHAR(40), TPhone VARCHAR(15))

BEGIN 
	UPDATE tbl_Teachers
	SET
		FirstName = Tfname,
		LastName = Tlname,
		DOB = TDOB,
		Gender = Tgender,
		Email = TEmail,
		Phone = TPhone
	WHERE Teacher_id = id;
END//
DELIMITER ;

CALL sp_UpdateTeacher("adaasdd", "kagggldk","advareda", "adayukywaw",3);

DELIMITER //
CREATE PROCEDURE sp_deleteTeacher(id INT)

BEGIN 
	DELETE FROM tbl_Teachers WHERE Teacher_id = id;
END//
DELIMITER ;

CALL sp_deleteTeacher(3);

/* Subjects SP's */

DELIMITER //
CREATE PROCEDURE sp_getSubjects()
BEGIN 
	SELECT * FROM tbl_Subjects;
END//
DELIMITER ;

CALL sp_getSubjects();

DELIMITER //
CREATE PROCEDURE sp_getSubject(id INT)
BEGIN 
	SELECT * FROM tbl_Subjects WHERE Sub_id = id;
END//
DELIMITER ;

CALL sp_getSubjects(3);

DELIMITER //
CREATE PROCEDURE sp_deleteSubject(id INT)

BEGIN 
	DELETE FROM tbl_Subjects WHERE Sub_id = id;
END//
DELIMITER ;

CALL sp_deleteSubject(2);

DELIMITER //
CREATE PROCEDURE sp_InsertSubject(subName VARCHAR(20), subDesc VARCHAR(255), CstartDate DATE, CendDate DATE, CBuilding VARCHAR(30) )

BEGIN 
	INSERT INTO tbl_Subjects(Sname, Sdesc, C_StartDate, C_EndDate,Building_Name) VALUES (subName, subDesc, CstartDate, CendDate, CBuilding );
END//
DELIMITER ;

CALL sp_InsertSubject ("Aerospace", "Advanced maths for aerospace design and testing", '2022-09-14', '2023-04-15', "Engineering Building");


DELIMITER //
CREATE PROCEDURE sp_UpdateSubject(id INT,subName VARCHAR(20), subDesc VARCHAR(255), CstartDate DATE, CendDate DATE, CBuilding VARCHAR(30) )

BEGIN 
	UPDATE tbl_Subjects 
	SET
		Sname = subName,
		Sdesc = subDesc,
		C_StartDate = CstartDate,
		C_EndDate = CendDate,
		Building_Name = CBuilding 
	WHERE Sub_id = id;
END//
DELIMITER ;

/* Courses SP's */

DELIMITER //
CREATE PROCEDURE sp_getCourses()
BEGIN 
	SELECT * FROM tbl_Courses;
END//
DELIMITER ;

CALL sp_getCourses();

DELIMITER //
CREATE PROCEDURE sp_getCourse(id INT)
BEGIN 
SELECT tbl_Courses.Course_id, tbl_Courses.Sub_id, tbl_Subjects.Sname, tbl_Subjects.Building_Name,tbl_Teachers.Teacher_id, tbl_Teachers.FirstName, tbl_Teachers.LastName, tbl_Addresses.Addr_id , tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
FROM tbl_Courses 
INNER JOIN tbl_Subjects ON tbl_Courses.Sub_id = tbl_Subjects.Sub_id 
INNER JOIN tbl_Teachers ON tbl_Courses.Teacher_id = tbl_Teachers.Teacher_id 
INNER JOIN tbl_Addresses ON tbl_Courses.Addr_id = tbl_Addresses.Addr_id; 

END//
DELIMITER ;

CALL sp_getCourse();

DELIMITER //
CREATE PROCEDURE sp_InsertCourse(CSub_id INT, CAddr_id INT, CTeach_id INT)

BEGIN 
	INSERT INTO tbl_Courses (Sub_id,Addr_id,Teacher_id) VALUES (CSub_id, CAddr_id, CTeach_id);
END//
DELIMITER ;

CALL sp_InsertCourse(2,3,1);



DELIMITER //
CREATE PROCEDURE sp_UpdateCourse(id INT,CSub_id INT, CAddr_id INT, CTeach_id INT)

BEGIN 
	UPDATE tbl_Courses
	SET
		Sub_id = CSub_id,
		Addr_id = CAddr_id,
		Teacher_id = CTeach_id
	WHERE Course_id = id;
END//
DELIMITER ;

CALL sp_UpdateTeacher("adaasdd", "kagggldk","advareda", "adayukywaw",3);

DELIMITER //
CREATE PROCEDURE sp_deleteCourse(id INT)

BEGIN 
	DELETE FROM tbl_Courses WHERE Course_id = id;
END//
DELIMITER ;

CALL sp_deleteCourse(2);

/* Enrollments SP's */

DELIMITER //
CREATE PROCEDURE sp_getEnrollments()
BEGIN 
	SELECT * FROM tbl_Enrollments;
END//
DELIMITER ;

CALL sp_getEnrollments();

DELIMITER //
CREATE PROCEDURE sp_getEnrollment(id INT)
BEGIN 
SELECT tbl_Enrollments.Enrollment_id,tbl_Enrollments.DOE ,tbl_Enrollments.Student_id, tbl_Students.stu_FirstName, tbl_Students.stu_LastName, tbl_Courses.Course_id, tbl_Courses.Sub_id
FROM tbl_Enrollments 
INNER JOIN tbl_Students ON tbl_Enrollments.Student_id =tbl_Students.Student_id 
INNER JOIN tbl_Courses ON tbl_Enrollments.Course_id = tbl_Courses.Course_id ;

END//
DELIMITER ;

CALL sp_getEnrollment();

DELIMITER //
CREATE PROCEDURE sp_InsertEnrollment(ES_id INT, EC_id INT, EDATE DATE)

BEGIN 
	INSERT INTO tbl_Enrollments (Student_id,Course_id,DOE) VALUES (ES_id, EC_id, EDATE);
END//
DELIMITER ;

CALL sp_InsertEnrollment(1,1,'2022-08-21');



DELIMITER //
CREATE PROCEDURE sp_UpdateEnrollment(id INT,ES_id INT, EC_id INT, EDATE DATE)

BEGIN 
	UPDATE tbl_Enrollments
	SET
		Student_id = ES_id,
		Course_id = EC_id,
		DOE = EDATE
	WHERE Enrollment_id = id;
END//
DELIMITER ;

CALL sp_UpdateEnrollment(2, 1,1,'2022-09-10');

DELIMITER //
CREATE PROCEDURE sp_deleteEnrollment(id INT)

BEGIN 
	DELETE FROM tbl_Enrollments WHERE Enrollment_id = id;
END//
DELIMITER ;

CALL sp_deleteEnrollment(2);


/* Class SP's*/

DELIMITER //
CREATE PROCEDURE sp_getClasses()
BEGIN 
	SELECT * FROM tbl_Class;
END//
DELIMITER ;

CALL sp_getClasses();

DELIMITER //
CREATE PROCEDURE sp_getClass(id INT)
BEGIN 
SELECT tbl_Class.Class_id,tbl_Class.Room,tbl_Class.Teacher_id,tbl_Teachers.FirstName,tbl_Teachers.LastName,tbl_Class.Enrollment_id,tbl_Enrollments.Student_id, tbl_Students.stu_FirstName, tbl_Students.stu_LastName, tbl_Class.TIme_id, tbl_Time.Time_Name,tbl_Class.File_id, tbl_Files.File_Name
FROM tbl_Class 
INNER JOIN tbl_Teachers ON tbl_Class.Teacher_id =tbl_Teachers.Teacher_id 
INNER JOIN tbl_Enrollments ON tbl_Class.Enrollment_id = tbl_Enrollments.Enrollment_id
INNER JOIN tbl_Students ON tbl_Class.Enrollment_id = tbl_Students.Student_id
INNER JOIN tbl_Time ON tbl_Class.TIme_id = tbl_Time.Time_id
INNER JOIN tbl_Files ON tbl_Class.File_id = tbl_Files.File_id;


END//
DELIMITER ;

CALL sp_getClass();

DELIMITER //
CREATE PROCEDURE sp_InsertClass(CRoom VARCHAR(10),CTeacher INT, CEnroll INT,Ctime INT, Cfile INT)

BEGIN 
	INSERT INTO tbl_Class (Room, Teacher_id, Enrollment_id, TIme_id, File_id) 
	VALUES (CRoom, CTeacher, CEnroll, Ctime, Cfile);
END//
DELIMITER ;

CALL sp_InsertClass(0,"R21",2,1,2,1);



DELIMITER //
CREATE PROCEDURE sp_UpdateClass(id INT,CRoom VARCHAR(10),CTeacher INT, CEnroll INT,Ctime INT, Cfile INT)

BEGIN 
	UPDATE tbl_Class
	SET
		Room = CRoom,
		Teacher_id = CTeacher,
		Enrollment_id = CEnroll,
		Time_id = Ctime,
		File_id = Cfile
	WHERE Class_id = id;
END//
DELIMITER ;

CALL sp_UpdateClass("R5",2,3,1,2);

DELIMITER //
CREATE PROCEDURE sp_deleteClass(id INT)

BEGIN 
	DELETE FROM tbl_Class WHERE Class_id = id;
END//
DELIMITER ;

CALL sp_deleteClass(2);







