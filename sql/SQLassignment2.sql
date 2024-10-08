CREATE TABLE patients(
id INT IDENTITY(1,1) PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
gender CHAR(6) CHECK(gender IN('M','F','OTHERS')),
age INT CHECK(age > 0 AND age < 120),
phone_number VARCHAR(15),
email VARCHAR(100) UNIQUE,
created_at DATEtIME DEFAULT GETDATE()
)

INSERT INTO patients(first_name,last_name,gender,age,phone_number,email) VALUES
('Rajesh', 'Sharma', 'M', 34, '9876543210', 'rajesh.sharma@gmail.com'),
('Anita', 'Verma', 'F', 29, '8765413254', 'anita.verma@yahoo.com'),
('Amit', 'Patel', 'M', 41, '7856421098', 'amit.patel@gmail.com'),
('Priya', 'Rao', 'F', 24, '6864259737', 'priya.rao@yahoo.com'),
('Kiran', 'Iyer', 'OTHERS', 38, '5931764826', 'kiran.iyer@gmail.com');


CREATE TABLE appointments
(
id INT IDENTITY(1,1) PRIMARY KEY,
patient_id INT,
appointment_date DATE CHECK (appointment_date >= GETDATE()),
appointment_time TIME,
reason_for_visit VARCHAR(250) NOT NULL,
doctor_name VARCHAR(100) NOT NULL,
created_at DATETIME DEFAULT GETDATE(),
)

INSERT INTO appointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name) VALUES
(1, '2024-10-10', '09:00:00', 'General check-up', 'Dr. Anderson'),
(2, '2024-10-12', '14:30:00', 'Routine blood test', 'Dr. Smith'),
(3, '2024-10-15', '11:00:00', 'Follow-up visit', 'Dr. Lee'),
(4, '2024-10-20', '16:00:00', 'Consultation for headache', 'Dr. Kim'),
(5, '2024-10-25', '10:00:00', 'Annual physical', 'Dr. Roberts');