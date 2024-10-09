CREATE TABLE students (
    student_id INT IDENTITY(1,1) PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    class VARCHAR(50) NOT NULL,
);

CREATE TABLE subjects (
    subject_id INT IDENTITY(1,1) PRIMARY KEY,
    subject_name VARCHAR(100) NOT NULL  
);

CREATE TABLE exam (
    examID INT PRIMARY KEY,
    examName VARCHAR(100),
    max_mark INT,
    min_mark INT
);

CREATE TABLE Marks (
    studentID INT,
    subjectID INT,
    examID INT,
    marks_obtained INT,
    FOREIGN KEY (studentID) REFERENCES students(student_id),
    FOREIGN KEY (subjectID) REFERENCES subjects(subject_id),
    FOREIGN KEY (examID) REFERENCES Exam(ExamID)
);

INSERT INTO students (student_name, class) VALUES
('Rajesh Kumar', '10th'),
('Anita Verma', '12th'),
('Amit Sharma', '11th'),
('Priya Rao', '10th');

INSERT INTO subjects (subject_name) VALUES
('DBMS'),
('C'),
('Java'),
('Python'),
('C#');

INSERT INTO exam (examID, examName, max_mark,min_mark) VALUES
(1, 'Mid Term', 100, 25),
(2, 'Final Term', 100, 25),
(3, 'Practical Exam', 50, 15),
(4, 'Internal Assessment', 25, 10);

INSERT INTO Marks (studentID, subjectID, examID, marks_obtained) VALUES
(1, 1, 1, 85), 
(1, 2, 1, 78), 
(2, 1, 1, 90),  
(2, 3, 1, 88), 
(3, 2, 1, 65), 
(4, 2, 2, 60),
(3, 1, 1, 75), 
(4, 3, 1, 80),  
(1, 1, 2, 88),  
(2, 2, 2, 95),  
(3, 1, 2, 70);

SELECT students.student_name FROM students
INNER JOIN Marks ON students.student_id = Marks.studentID GROUP BY students.student_name;

SELECT 
    students.student_name, 
    subjects.subject_name, 
    exam.examName, 
    Marks.marks_obtained
FROM students
INNER JOIN Marks 
ON students.student_id = Marks.studentID
INNER JOIN subjects 
ON Marks.subjectID = subjects.subject_id
INNER JOIN exam 
ON Marks.examID = exam.examID;
