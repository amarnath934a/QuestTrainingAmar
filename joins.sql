CREATE TABLE employees
(
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(100) NOT NULL,
    department_id INT
);
CREATE TABLE departments
(
    department_id INT PRIMARY KEY,
    department_name VARCHAR(100) NOT NULL
);
CREATE TABLE salaries
(
    salary_id INT PRIMARY KEY,
    employee_id INT,
    salary_amount DECIMAL(10, 2),
    FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);
INSERT INTO departments (department_id, department_name) VALUES
(1, 'HR'),
(2, 'Engineering'),
(3, 'Marketing');

INSERT INTO employees (employee_id, employee_name, department_id) VALUES
(101, 'John Doe', 1),
(102, 'Jane Smith', 2),
(103, 'Alice Johnson', 2),
(104, 'Bob Brown', 3),
(105, 'Charlie White', 1);

INSERT INTO salaries (salary_id, employee_id, salary_amount) VALUES
(1, 101, 55000.00),
(2, 102, 75000.00),
(3, 103, 68000.00),
(4, 104, 45000.00),
(5, 105, 50000.00);

SELECT employees.employee_name, departments.department_name
FROM employees
INNER JOIN 
departments ON employees.department_id = departments.department_id;

SELECT employees.employee_name, departments.department_name
FROM employees
LEFT JOIN 
departments ON employees.department_id = departments.department_id;

SELECT employees.employee_name, departments.department_name
FROM employees
RIGHT JOIN 
departments ON employees.department_id = departments.department_id;

SELECT employees.employee_id, salaries.salary_amount
FROM employees
INNER JOIN 
salaries ON employees.department_id = salaries.salary_id;

SELECT employees.employee_name, departments.department_name, salaries.salary_amount
FROM employees
INNER JOIN
departments ON employees.department_id = departments.department_id
INNER JOIN
salaries ON employees.employee_id = salaries.employee_id;

SELECT employees.employee_name, departments.department_id, salaries.salary_amount
FROM employees
LEFT JOIN 
departments ON employees.department_id = departments.department_id
LEFT JOIN 
salaries ON employees.employee_id = salaries.employee_id;

SELECT employees.employee_id, departments.department_id, salaries.salary_amount
FROM employees
RIGHT JOIN 
departments ON employees.department_id = departments.department_id
RIGHT JOIN 
salaries ON employees.employee_id = salaries.employee_id;