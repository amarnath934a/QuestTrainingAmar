CREATE TABLE medication(
	id INT PRIMARY KEY IDENTITY(1,1),
	med_name VARCHAR(50) NOT NULL,
	med_category VARCHAR(255) NOT NULL,
    med_price DECIMAL(5, 2) NOT NULL,
    med_expiry DATE,
    supplier_id INT UNIQUE,
    stock_quantity INT

    CONSTRAINT fk_supplier_id FOREIGN KEY (supplier_id) REFERENCES supplier(id)
)

CREATE TABLE supplier(
    id INT PRIMARY KEY IDENTITY(1,1),
    supplier_name VARCHAR(50) NOT NULL,
    contact_person VARCHAR(50),
    supplier_phone VARCHAR(20) NOT NULL,
    supplier_email VARCHAR(100)NOT NULL,
    supplier_address TEXT
)

CREATE TABLE customers(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_name VARCHAR(50) NOT NULL,
    customer_phone VARCHAR(20),
    customer_email VARCHAR(100),
    customer_address TEXT
)

DROP TABLE customers;

CREATE TABLE sales(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT,
    medication_id INT,
    quantity INT,
    sale_date DATE,
    total_price DECIMAL(5,2)

    CONSTRAINT fk_customer_id FOREIGN KEY (customer_id) REFERENCES customers(id),
    CONSTRAINT fk_medication_id FOREIGN KEY (medication_id) REFERENCES medication(id)
)

CREATE TABLE inventory(
    id INT PRIMARY KEY IDENTITY(1,1),
    medication_id INT,
    supplier_id INT,
    stock_in INT,
    stock_out INT,
    date_added DATE,

    CONSTRAINT fk_inventory_medication_id FOREIGN KEY (medication_id) REFERENCES medication(id),
    CONSTRAINT fk_inventory_supplier_id FOREIGN KEY (supplier_id) REFERENCES supplier(id)
)
GO
CREATE PROCEDURE med_medication (
    @med_name VARCHAR(255),
    @med_category VARCHAR(255),
    @med_price DECIMAL(10, 2),
    @med_expiry DATE,
    @med_supplier_id INT,
    @med_stock_quantity INT
)
AS
BEGIN
    INSERT INTO medication (med_name, med_category, med_price, med_expiry, supplier_id, stock_quantity)
    VALUES (@med_name, @med_category, @med_price, @med_expiry, @med_supplier_id, @med_stock_quantity);
END;

GO
EXEC med_medication 
    @med_name = 'Paracetamol', 
    @med_category = 'Analgesic',
    @med_price = 2.50, 
    @med_expiry = '2025-12-31', 
    @med_supplier_id = 1, 
    @med_stock_quantity = 100;

EXEC med_medication 
    @med_name = 'Ibuprofen', 
    @med_category = 'Anti-inflammatory',
    @med_price = 3.75, 
    @med_expiry = '2026-05-15', 
    @med_supplier_id = 2, 
    @med_stock_quantity = 200;

EXEC med_medication 
    @med_name = 'Amoxicillin', 
    @med_category = 'Antibiotic',
    @med_price = 15.00, 
    @med_expiry = '2025-09-10', 
    @med_supplier_id = 1, 
    @med_stock_quantity = 150;

EXEC med_medication 
    @med_name = 'Cetirizine', 
    @med_category = 'Antihistamine',
    @med_price = 5.50, 
    @med_expiry = '2024-11-20', 
    @med_supplier_id = 3, 
    @med_stock_quantity = 250;

EXEC med_medication 
    @med_name = 'Metformin', 
    @med_category = 'Antidiabetic',
    @med_price = 10.00, 
    @med_expiry = '2026-02-28', 
    @med_supplier_id = 4, 
    @med_stock_quantity = 120;

GO
CREATE PROCEDURE med_supplier (
    @supplier_name VARCHAR(50),
    @contact_person VARCHAR(50),
    @supplier_phone VARCHAR(20),
    @supplier_email VARCHAR(100),
    @supplier_address TEXT
)
AS
BEGIN
    INSERT INTO supplier (supplier_name, contact_person, supplier_phone, supplier_email, supplier_address)
    VALUES (@supplier_name, @contact_person, @supplier_phone, @supplier_email, @supplier_address);
END;

GO
-- Inserting Supplier 1
EXEC med_supplier 
    @supplier_name = 'HealthCorp', 
    @contact_person = 'John Smith', 
    @supplier_phone = '123-456-7890', 
    @supplier_email = 'john@healthcorp.com', 
    @supplier_address = '123 Health Street, New York, NY';

-- Inserting Supplier 2
EXEC med_supplier 
    @supplier_name = 'PharmaPlus', 
    @contact_person = 'Mary Johnson', 
    @supplier_phone = '987-654-3210', 
    @supplier_email = 'mary@pharmaplus.com', 
    @supplier_address = '456 Pharma Avenue, Los Angeles, CA';

-- Inserting Supplier 3
EXEC med_supplier 
    @supplier_name = 'MediSupplies', 
    @contact_person = 'Alice Brown', 
    @supplier_phone = '555-123-4567', 
    @supplier_email = 'alice@medisupplies.com', 
    @supplier_address = '789 Medical Lane, Chicago, IL';

-- Inserting Supplier 4
EXEC med_supplier 
    @supplier_name = 'Wellness Distributors', 
    @contact_person = 'Robert Davis', 
    @supplier_phone = '444-987-6543', 
    @supplier_email = 'robert@wellnessdist.com', 
    @supplier_address = '321 Wellness Way, Miami, FL';

-- Inserting Supplier 5
EXEC med_supplier 
    @supplier_name = 'LifeCare Suppliers', 
    @contact_person = 'Emma Wilson', 
    @supplier_phone = '333-888-9999', 
    @supplier_email = 'emma@lifecare.com', 
    @supplier_address = '111 Life Street, Houston, TX';


DROP PROCEDURE IF EXISTS AddCustomerToCustomers;
GO

GO
CREATE PROCEDURE AddCustomerToCustomers (
    @customer_name VARCHAR(50),
    @customer_phone VARCHAR(20),
    @customer_email VARCHAR(100),
    @customer_address TEXT
)
AS
BEGIN
    INSERT INTO customers (customer_name, customer_phone, customer_email, customer_address)
    VALUES (@customer_name, @customer_phone, @customer_email, @customer_address);
END;

-- Inserting Customer 1
EXEC AddCustomerToCustomers 
    @customer_name = 'John Doe', 
    @customer_phone = '555-555-1234', 
    @customer_email = 'john.doe@example.com', 
    @customer_address = '123 Main Street, New York, NY';

-- Inserting Customer 2
EXEC AddCustomerToCustomers
    @customer_name = 'Jane Smith', 
    @customer_phone = '555-555-5678', 
    @customer_email = 'jane.smith@example.com', 
    @customer_address = '456 Oak Avenue, Los Angeles, CA';

-- Inserting Customer 3
EXEC AddCustomerToCustomers 
    @customer_name = 'David Johnson', 
    @customer_phone = '555-555-9101', 
    @customer_email = 'david.johnson@example.com', 
    @customer_address = '789 Pine Street, Chicago, IL';

-- Inserting Customer 4
EXEC AddCustomerToCustomers 
    @customer_name = 'Emily Brown', 
    @customer_phone = '555-555-1213', 
    @customer_email = 'emily.brown@example.com', 
    @customer_address = '321 Cedar Lane, Miami, FL';

-- Inserting Customer 5
EXEC AddCustomerToCustomers 
    @customer_name = 'Michael Wilson', 
    @customer_phone = '555-555-1415', 
    @customer_email = 'michael.wilson@example.com', 
    @customer_address = '987 Maple Street, Houston, TX';

GO
CREATE PROCEDURE AddSale (
    @customer_id INT,
    @medication_id INT,
    @quantity INT,
    @sale_date DATE,
    @total_price DECIMAL(10, 2)
)
AS
BEGIN
    INSERT INTO sales (customer_id, medication_id, quantity, sale_date, total_price)
    VALUES (@customer_id, @medication_id, @quantity, @sale_date, @total_price);
END;

GO

EXEC AddSale 
    @customer_id = 1, 
    @medication_id = 7, 
    @quantity = 2, 
    @sale_date = '2024-10-01', 
    @total_price = 5.00;

EXEC AddSale 
    @customer_id = 2, 
    @medication_id = 8, 
    @quantity = 1, 
    @sale_date = '2024-10-02', 
    @total_price = 3.75;

EXEC AddSale 
    @customer_id = 1, 
    @medication_id = 9,
    @quantity = 1, 
    @sale_date = '2024-10-03', 
    @total_price = 15.00; 

EXEC AddSale 
    @customer_id = 3, 
    @medication_id = 10, 
    @quantity = 3, 
    @sale_date = '2024-10-04', 
    @total_price = 16.50;

EXEC AddSale 
    @customer_id = 2, 
    @medication_id = 11,
    @quantity = 2, 
    @sale_date = '2024-10-05', 
    @total_price = 20.00; 


GO
CREATE PROCEDURE add_inventory 
    @medication_id INT,
    @supplier_id INT,
    @stock_in INT,
    @stock_out INT,
    @date_added DATE
AS
BEGIN
    INSERT INTO inventory (medication_id, supplier_id, stock_in, stock_out, date_added)
    VALUES (@medication_id, @supplier_id, @stock_in, @stock_out, @date_added);
END;

-- Inserting 1st inventory record
EXEC add_inventory 
    @medication_id = 1, 
    @supplier_id = 1, 
    @stock_in = 100, 
    @stock_out = 20, 
    @date_added = '2024-10-01';

-- Inserting 2nd inventory record
EXEC add_inventory 
    @medication_id = 2, 
    @supplier_id = 2, 
    @stock_in = 200, 
    @stock_out = 50, 
    @date_added = '2024-10-02';

-- Inserting 3rd inventory record
EXEC add_inventory 
    @medication_id = 3, 
    @supplier_id = 1, 
    @stock_in = 150, 
    @stock_out = 30, 
    @date_added = '2024-10-03';

-- Inserting 4th inventory record
EXEC add_inventory 
    @medication_id = 4, 
    @supplier_id = 3, 
    @stock_in = 250, 
    @stock_out = 40, 
    @date_added = '2024-10-04';

-- Inserting 5th inventory record
EXEC add_inventory 
    @medication_id = 5, 
    @supplier_id = 4, 
    @stock_in = 120, 
    @stock_out = 60, 
    @date_added = '2024-10-05';

