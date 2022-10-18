SELECT * FROM tbl_Addresses;

SELECT * FROM tbl_Addresses WHERE Addr_id = 1;

INSERT INTO tbl_Addresses(Address,County,City,Postcode) VALUES ("8 Mile Ln", "West Midlands", "Coventry", "CV1 1NF");

UPDATE tbl_Addresses
	SET
		Address = "33 Caldmore Street",
		County = "West Midlands",
		City = "Walsall",
		Postcode = "WS3 5NF"
	WHERE Addr_id = 2;
	
DELETE FROM tbl_Addresses WHERE Addr_id = 1;

SELECT * FROM tbl_Students;

SELECT tbl_Students.Student_id, tbl_Students.stu_FirstName, tbl_Students.stu_LastName, tbl_Students.stu_DOB, tbl_Students.stu_Gender, tbl_Students.Addr_id, tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
FROM tbl_Students INNER JOIN tbl_Addresses ON tbl_Students.Addr_id = tbl_Addresses.Addr_id WHERE Student_id = 1;

INSERT INTO tbl_Students(stu_FirstName,stu_LastName,stu_DOB,stu_Gender,Addr_id) VALUES ("Amy", "Lane",'1995-2-3',"Female",3);

UPDATE tbl_Students
	SET
		stu_FirstName = "Dan",
		stu_LastName = "Stevens",
		stu_DOB = '1998-2-1',
		stu_Gender = "Male",
		Addr_id = 3, 
	WHERE Student_id = 2;
	
DELETE FROM tbl_Students WHERE Student_id = 1;

SELECT * FROM tbl_Teachers;

SELECT tbl_Teachers.Teacher_id, tbl_Teachers.FirstName, tbl_Teachers.LastName, tbl_Teachers.DOB, tbl_Teachers.Gender, tbl_Teachers.Addr_id, tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
FROM tbl_Teachers 
INNER JOIN tbl_Addresses ON tbl_Teachers.Addr_id = tbl_Addresses.Addr_id;


SELECT * FROM tbl_Teachers WHERE Teacher_id = 1;

INSERT INTO tbl_Teachers(FirstName,LastName,DOB,Gender,Addr_id) VALUES ("Derek", "Smith",'1980-4-10',"Male",3);

UPDATE tbl_Teachers
	SET
		stu_FirstName = "Derek",
		stu_LastName = "Smith",
		stu_DOB = '1980-4-10',
		stu_Gender = "Male",
		Addr_id = 3, 
	WHERE Teacher_id = 1;
	
DELETE FROM tbl_Teachers WHERE Teacher_id = 1;

SELECT * FROM tbl_Subjects;

SELECT * FROM tbl_Subjects WHERE Sub_id = 1;

INSERT INTO tbl_Subjects(Sname,Sdesc,C_StartDate,C_EndDate,Building_Name) VALUES ("Aerospace", "A course targeted at the aviation industry and engine development", '2022-09-10', '2022-06-24', "Engineering Building");

UPDATE tbl_Subjects 
	SET
		Sname = "Aerospace",
		Sdesc = "A course targeted at the aviation industry and engine development",
		C_StartDate = '2022-09-10',
		C_EndDate = '2022-06-24',
		Building_Name = "Engineering Building", 
		WHERE Sub_id = 1;
	
	
DELETE FROM tbl_Subjects WHERE Sub_id = 1;

SELECT * FROM tbl_Courses;

SELECT tbl_Courses.Course_id, tbl_Courses.Sub_id, tbl_Subjects.Sname, tbl_Subjects.Building_Name,tbl_Teachers.Teacher_id, tbl_Teachers.FirstName, tbl_Teachers.LastName, tbl_Addresses.Addr_id , tbl_Addresses.Address, tbl_Addresses.County, tbl_Addresses.City, tbl_Addresses.Postcode
FROM tbl_Courses 
INNER JOIN tbl_Subjects ON tbl_Courses.Sub_id = tbl_Subjects.Sub_id 
INNER JOIN tbl_Teachers ON tbl_Courses.Teacher_id = tbl_Teachers.Teacher_id 
INNER JOIN tbl_Addresses ON tbl_Courses.Addr_id = tbl_Addresses.Addr_id ;

 
SELECT * FROM tbl_Courses WHERE Course_id = 1;

INSERT INTO tbl_Courses (Sub_id, Addr_id, Teacher_id) VALUES (1,4,1);

UPDATE tbl_Courses
	SET
		Sub_id = 1,
		Addr_id = 4,
		Teacher_id = 1, 
	WHERE Courses_id = 1;
	
DELETE FROM tbl_Courses WHERE Course_id = 1;

SELECT * FROM tbl_Enrollments;

SELECT tbl_Enrollments.Enrollment_id,tbl_Enrollments.DOE ,tbl_Enrollments.Student_id, tbl_Students.stu_FirstName, tbl_Students.stu_LastName, tbl_Courses.Course_id, tbl_Courses.Sub_id
FROM tbl_Enrollments 
INNER JOIN tbl_Students ON tbl_Enrollments.Student_id =tbl_Students.Student_id 
INNER JOIN tbl_Courses ON tbl_Enrollments.Course_id = tbl_Courses.Course_id;

SELECT * FROM tbl_Enrollments WHERE Enrollment_id = 1;

INSERT INTO tbl_Enrollments (Student_id, Course_id, DOE) VALUES (1,1,'2022-08-25');

UPDATE tbl_Enrollments
	SET
		Student_id = 1,
		Course_id = 4,
		DOE = '2022-08-25', 
	WHERE Enrollment_id = 1;
	
DELETE FROM tbl_Enrollments WHERE Enrollment_id = 1;






