--Creates new database
CREATE DATABASE FirstDatabase;

--single comment line

/*
Multi
Line 
Comments
*/

USE FirstDatabase;

--Select all columns (*) from table
SELECT * FROM Teachers;

--Select spesific columns from table
SELECT [Name], Surname FROM Teachers;

--Insert new row to Teachers table
INSERT INTO Teachers
([Name], Surname, MiddleName, Email, IsActive) VALUES
('Samir', 'Babayev', NULL, 'samir@gmail.com', 1)

--Delete all rows from Teachers table
DELETE FROM Teachers;

--Update email address of teacher which TeacherId is 2
UPDATE Teachers SET Email = 'orkhan@gmail.com' where TeacherId = 2;

--Update email address of all teachers
UPDATE Teachers SET Email = 'orkhan@gmail.com'

--Create new table in database
CREATE TABLE Students(
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	Firstname NVARCHAR(20),
	Lastname NVARCHAR(50),
	[Address] NVARCHAR(250) NOT NULL
);

--Delete table from database
DROP TABLE Students;

--Delete all data in table
TRUNCATE TABLE Teachers;



/*
HOMEWORK:
1. School adında bir database yarat.
2. School database'da Teachers adinda bir table olsun hemin table'in asagidaki column'lari olsun:
	- TeacherId (auto incremental ve primary key olsun)
	- Firstname
	- Middlename (nullable olsun)
	- Surname
	- Email
	- IsActive (True/False)
3. School database'da Students table olsun ve Teachers table'i ile eyni column'lara sahib olsun.
4. Teachers ve students table in her birine 3-4 data insert et.
5. Insert etdiyin 3-4 datanin ikisinin email unvanlarini deyis (her hansisa basqa value yaza bilersen istediyin)
6. Teachers table'dan butun row'lari, Studentsden ise ikinci ve sonuncu row'u sil.
7. Students ve Teachers table'lari sil
8. Database'i sil.
*/

USE School;

INSERT INTO Teachers 
(Firstname, Surname, Email, IsActive)
VALUES
('Eli', 'Eliyev', 'eli.eliyev@mail.ru', 1);

INSERT INTO Teachers 
(Firstname, Surname, Email, IsActive)
VALUES
('Zakir', 'Hikmetli', 'zakir.hikmetli@mail.ru', 0);

INSERT INTO Teachers 
(Firstname,  Surname, Email, IsActive)
VALUES
('Aida', 'Najafova', 'aida_najafova@mail.ru', 0);

INSERT INTO Students
(Firstname, Surname, Email, IsActive)
VALUES
('Orxan', 'Farajov', 'orxan.farajov@mail.ru', 0);

INSERT INTO Students
(Firstname, Surname, Email, IsActive)
VALUES
('Jeyhun', 'Babayev', 'jeyhun-babayev@mail.ru', 1);

INSERT INTO Students
(Firstname, Surname, Email, IsActive)
VALUES
('Samir', 'Hasanov', 'samir_hasanov@mail.ru', 1);

INSERT INTO Students
(Firstname, Surname, Email, IsActive)
VALUES
('Sabir', 'Mammadov', 'sabirm@mail.ru', 1);


UPDATE Teachers SET Email = 'eli_eliyev@gmail.com' WHERE (TeacherId = 1);

UPDATE Students SET Email = 'jeyhunbabayev@hotmail.ru' WHERE (StudentsId = 2);

UPDATE Teachers SET Email = 'zakir@gmail.com' WHERE ( TeacherId = 2);

TRUNCATE TABLE Teachers;

DELETE FROM Students where (StudentsId = 2);

DELETE FROM Students where (StudentsId = 4);

DROP TABLE Students;

DROP TABLE Teachers;

USE School;

/*2. School database'da Teachers adinda bir table olsun hemin table'in asagidaki column'lari olsun:
	- TeacherId (auto incremental ve primary key olsun)
	- Firstname
	- Middlename (nullable olsun)
	- Surname
	- Email
	- IsActive (True/False)
	*/



