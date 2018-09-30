SELECT GETDATE()

CREATE TABLE Student(
	rollNo int,
	fName VARCHAR(255),
	lName VARCHAR(255),
	CGPA float(4),
	
	PRIMARY KEY (rollNo)
);

INSERT INTO Student(rollNo,fName,lName,CGPA) VALUES(101,'Chandan','Maharana',7.6);
INSERT INTO Student(rollNo,fName,lName,CGPA) VALUES(102,'Dharmesh','Nayak',8.9);
INSERT INTO Student(rollNo,fName,lName,CGPA) VALUES(103,'Abhishek','Singh',5.2);
INSERT INTO Student(rollNo,fName,lName,CGPA) VALUES(104,'Foo','Bar',9.2);

SELECT * FROM Student;
SELECT rollNo,fName from Student;

SELECT @@SERVERNAME

