--INSERT INTO users
--(first_name,last_name,email,age) VALUES 
--('amar','nath','amarnath@gmail.com',22),
--('ravi','teja','raviteja@gmail.com',23),
--('ranjith','j','jranjith@gmail.com',24),
--('ravindra','a','ravindra@gmail.com',18)

SELECT first_name, last_name, age FROM users;

SELECT id, email FROM users WHERE first_name = 'amar'

SELECT id, email FROM users ORDER BY age ASC