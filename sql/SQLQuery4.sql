CREATE TABLE students1(
    student_id INT PRIMARY KEY,
    student_name VARCHAR(50) NOT NULL,
    class VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL
)

INSERT INTO students1 (student_id, student_name, class, email) VALUES
(1, 'Alice Smith', '10th Grade', 'alice.smith@example.com'),
(2, 'Bob Johnson', '10th Grade', 'bob.johnson@example.com'),
(3, 'Charlie Brown', '11th Grade', 'charlie.brown@example.com'),
(4, 'David Wilson', '11th Grade', 'david.wilson@example.com'),
(5, 'Eva Green', '12th Grade', 'eva.green@example.com'),
(6, 'Fiona White', '12th Grade', 'fiona.white@example.com'),
(7, 'George Black', '9th Grade', 'george.black@example.com'),
(8, 'Hannah Blue', '9th Grade', 'hannah.blue@example.com'),
(9, 'Ian Gray', '10th Grade', 'ian.gray@example.com'),
(10, 'Jack Red', '11th Grade', 'jack.red@example.com');


SELECT class, COUNT(student_id) AS student_count
FROM students1
GROUP BY class;

SELECT class, COUNT(student_id) AS student_count
FROM students1
GROUP BY class HAVING COUNT(student_id) < 3;

SELECT student_id, student_name FROM students1 
WHERE class IN ('9th Grade','12th Grade')

--ORDER BY
SELECT TOP 5 student_name FROM students1;

--OFFSET
SELECT student_name FROM students1
ORDER BY student_id OFFSET 5 ROWS
FETCH NEXT 3 ROWS ONLY;

SELECT LEN('student')

--LENGTH
SELECT student_name, LEN(student_name) AS namelength FROM students1 

SELECT MIN(class) AS Minclass FROM students1;
SELECT MAX(class) AS maxclass FROM students1;
SELECT MIN(avg) AS Avgclass FROM students1;
