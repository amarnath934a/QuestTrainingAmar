CREATE TABLE Customers (
    acc_no BIGINT PRIMARY KEY,
    name VARCHAR(100),
    phone_no VARCHAR(15),
    bank_balance BIGINT
);

--ALTER TABLE Customers
--ALTER COLUMN phone_no BIGINT;

--ALTER TABLE Transactions
--DROP COLUMN sender_name, receiver_name;

--ALTER TABLE Transactions
--ADD TransactionAmount BIGINT;

--DELETE FROM Transactions;

--DROP TABLE Transactions

CREATE TABLE Transactions (
    id BIGINT PRIMARY KEY,
    sender_acc_no BIGINT NULL, 
    receiver_acc_no BIGINT NULL,
    trans_type VARCHAR(20) CHECK (trans_type IN ('Withdraw', 'Deposit', 'Transfer')),
    trans_date DATE,
    trans_amount BIGINT,

    CONSTRAINT FK_sender_acc_no FOREIGN KEY(sender_acc_no)
        REFERENCES Customers(acc_no),
    CONSTRAINT FK_receiver_acc_no FOREIGN KEY(receiver_acc_no)
        REFERENCES Customers(acc_no)
);

INSERT INTO Transactions (id, sender_acc_no, receiver_acc_no, trans_type, trans_date, trans_amount) 
VALUES 
(1, NULL, 1001, 'Deposit', '2024-10-01', 5000),
(2, 1002, NULL, 'Withdraw', '2024-10-02', 3000),
(3, 1003, 1004, 'Transfer', '2024-10-03', 2000),
(4, NULL, 1005, 'Deposit', '2024-10-04', 4500),
(5, 1005, NULL, 'Withdraw', '2024-10-05', 1500);

INSERT INTO Customers (acc_no, name, phone_no, bank_balance)
VALUES 
(1001, 'Alice Johnson', '1234567890', 5000),
(1002, 'Bob Smith', '0987654321', 3000),
(1003, 'Charlie Brown', '5551234567', 7000),
(1004, 'Diana Prince', '6667894563', 4500),
(1005, 'Eva Adams', '7775551234', 1500);

SELECT 
    Transactions.id,
    sender.name AS sender_name,
    receiver.name AS receiver_name,
    Transactions.trans_type,
    Transactions.trans_date,
    Transactions.trans_amount
FROM Transactions 
LEFT JOIN Customers AS sender ON Transactions.sender_acc_no = sender.acc_no
LEFT JOIN Customers AS receiver ON Transactions.receiver_acc_no = receiver.acc_no;

--create account
INSERT INTO Customers (acc_no, name, phone_no, bank_balance)
VALUES (1006, 'amar', '88836985244', 3000);


--delete account
DELETE FROM Customers WHERE acc_no = 1006;

--update account
UPDATE Customers 
SET 
    name = 'ravi',
    phone_no = '1112223333',
    bank_balance = 6000
WHERE acc_no = 1001; 

--deposite
UPDATE Customers 
SET bank_balance = bank_balance + 1500 
WHERE acc_no = 1001;
