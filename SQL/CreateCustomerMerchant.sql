CREATE TABLE CUSTOMER(
	customer_id INT IDENTITY PRIMARY KEY,
	customer_name VARCHAR(20),
	customer_balance INT
);

INSERT INTO CUSTOMER(customer_name,customer_balance)
VALUES('Chandan',20000);
INSERT INTO CUSTOMER(customer_name,customer_balance)
VALUES('Dharmesh',30000);

SELECT * FROM CUSTOMER

CREATE TABLE MERCHANT(
	merchant_id INT IDENTITY PRIMARY KEY,
	merchant_name VARCHAR(20),
	merchant_balance INT
);

INSERT INTO MERCHANT(merchant_name,merchant_balance)
VALUES('SMITH',15000);
INSERT INTO MERCHANT(merchant_name,merchant_balance)
VALUES('JOHN',12000);

SELECT * FROM MERCHANT