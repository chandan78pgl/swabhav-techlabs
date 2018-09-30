CREATE TABLE CONTACTS(
	id int IDENTITY PRIMARY KEY,
	name varchar(20),
	number bigint
);

INSERT INTO CONTACTS(name,number) VALUES('chandan',8460551251);
INSERT INTO CONTACTS(name,number) VALUES('dharmesh',8780421011);

SELECT * FROM CONTACTS;

DROP TABLE CONTACTS;

CREATE TABLE LOGINUSERS(
	id int IDENTITY PRIMARY KEY,
	userID varchar(20),
	password varchar(20)
);

INSERT INTO LOGINUSERS(userID,password) values('chandan','root')

SELECT * FROM LOGINUSERS