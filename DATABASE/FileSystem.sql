CREATE TABLE tbl_Files (
	File_id INT AUTO_INCREMENT,
	File_Name VARCHAR(60) NOT NULL,
	FileData LONGBLOB NOT NULL,
	CONSTRAINT pk_File PRIMARY KEY (File_id)
);


DELIMITER //
CREATE PROCEDURE sp_ViewFiles()
BEGIN 
	SELECT File_id, FileName FROM tbl_Files;
END//
DELIMITER ;

CALL sp_ViewFiles();

DELIMITER //
CREATE PROCEDURE sp_GetFiles(id INT)
BEGIN 
	SELECT * FROM tbl_Files WHERE File_id = id;
END//
DELIMITER;

CALL sp_GetFiles(1);

DELIMITER //
CREATE PROCEDURE sp_InsertFile(Fname VARCHAR(60), FData LONGBLOB)
BEGIN 
	INSERT INTO tbl_Files(FileName,FileData) VALUES (Fname,FData);
END//
DELIMITER ;

CALL sp_InsertFile();

DELIMITER //
CREATE PROCEDURE sp_DeleteFile(id INT)
BEGIN
	DELETE FROM tbl_Files WHERE File_id = id;
END//
DELIMITER ;

CALL sp_DeleteFile();