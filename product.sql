CREATE TABLE customers (
    id INT IDENTITY(1,1) PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,  
    last_name VARCHAR(50) NOT NULL,    
    email VARCHAR(100) UNIQUE,         
    phone_number VARCHAR(15),           
);

CREATE TABLE products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL, 
    price INT CHECK(price > 0), 
    stock_quantity INT CHECK(stock_quantity >= 0),
);

INSERT INTO customers(first_name,last_name,email,phone_number) VALUES
('Amit', 'Sharma', 'amit.sharma@gmail.com', '9876543210'),
('Neha', 'Kapoor', 'neha.kapoor@yahoo.com', '8765432109'),
('Rohit', 'Verma', 'rohit.verma@gmail.com', '7654321098'),
('Pooja', 'Rao', 'pooja.rao@hotmail.com', '6543210987'),
('Kiran', 'Singh', 'kiran.singh@gmail.com', '5432109876');

INSERT INTO products(product_name,price,stock_quantity) VALUES
('Smartphone', 29999, 50),
('Laptop', 59999, 30),
('Headphones', 1999, 100),
('Smartwatch', 14999, 25),
('Tablet', 24999, 40);

CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    product_id INT,
    order_quantity INT DEFAULT 1,
    order_date DATETIME DEFAULT GETDATE(),  
    FOREIGN KEY (customer_id) REFERENCES customers(id), 
    FOREIGN KEY (product_id) REFERENCES products(id)  
);

INSERT INTO orders(customer_id,product_id,order_quantity) VALUES
(2,2,2);

DELETE FROM customers WHERE id = 1

DELETE FROM products WHERE id = 1

CREATE TABLE order_items (
    order_id INT,
    product_id INT,
    quantity INT DEFAULT 1,
    FOREIGN KEY (order_id) REFERENCES orders(id),
    FOREIGN KEY (product_id) REFERENCES products(id)
);

INSERT INTO order_items(order_id,product_id,quantity) VALUES (1,2,3)