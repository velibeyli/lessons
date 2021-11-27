use School;

CREATE TABLE Students
(
StudentId INT NOT NULL,
Firstname NVARCHAR(20) NOT NULL,
Middlename NVARCHAR(20),
Surname NVARCHAR(30) NOT NULL,
Email NVARCHAR(30) NOT NULL,
IsActive bit NOT NULL
);

CREATE TABLE Teachers
(
TeacherId INT NOT NULL,
Firstname NVARCHAR(20) NOT NULL,
Middlename NVARCHAR(20),
Surname NVARCHAR(30) NOT NULL,
Email NVARCHAR(30) NOT NULL,
IsActive bit NOT NULL
);

ALTER TABLE Students ADD PRIMARY KEY (StudentId);

ALTER TABLE Teachers ADD PRIMARY KEY (TeacherId);

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

SELECT * FROM PivotTable;

SELECT * FROM Students;

SELECT * FROM Teachers;

SELECT * FROM Students WHERE IsActive = 1 and Surname = 'Mammadov';

SELECT * FROM Teachers WHERE IsActive = 1 and Surname = 'Eliyev';

Update Students set Middlename = 'Aydin' WHERE IsActive = 1 and Surname = 'Mammadov';

Update Teachers set Middlename = 'Memmed' WHERE IsActive = 1 and Surname = 'Eliyev';

Insert Into PivotTable
(TeacherId, StudentId) VAlUeS
(1, 3);