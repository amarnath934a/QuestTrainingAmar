CREATE TABLE course (
    course_id INT PRIMARY KEY,
    course_name VARCHAR(50) NOT NULL,
    total_fees INT NOT NULL
);


CREATE TABLE students3 (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(50) NOT NULL,
    course_name VARCHAR(50) NOT NULL,
    fees_paid INT NOT NULL
);


INSERT INTO course (course_id, course_name, total_fees)
VALUES 
(1, 'Math', 5000),
(2, 'Science', 4500),
(3, 'English', 4000),
(4, 'History', 3800),
(5, 'Computer Science', 5500);

INSERT INTO students3 (student_id, student_name, course_name, fees_paid)
VALUES 
(1, 'Amar', 'Math', 5000),
(2, 'Ravi', 'Science', 4500),
(3, 'John', 'English', 4000),
(4, 'Sara', 'History', 3800),
(5, 'Kiran', 'Computer Science', 5500),
(6, 'Nina', 'Math', 4500),
(7, 'Rohit', 'Science', 4300),
(8, 'Lilly', 'English', 4000),
(9, 'Ali', 'History', 3700),
(10, 'Sita', 'Computer Science', 5000);

SELECT course_name, COUNT(student_id) AS total_students FROM students3
GROUP BY course_name;

SELECT course_name, SUM(fees_paid) AS course_fees FROM students3
GROUP BY course_name;

SELECT TOP 1 course_name, COUNT(student_id) AS total_students FROM students3
GROUP BY course_name ORDER BY total_students DESC;

INSERT INTO students3 (student_id, student_name, course_name, fees_paid)
VALUES (11, 'Sara', 'History', 3800);