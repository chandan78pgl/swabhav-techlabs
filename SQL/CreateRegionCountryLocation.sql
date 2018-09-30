CREATE TABLE REGIONS
    ( region_id      int 
       CONSTRAINT  region_id_nn NOT NULL 
    , region_name    VARCHAR(25) 
    );


ALTER TABLE REGIONS
ADD CONSTRAINT reg_id_pk
                 PRIMARY KEY (region_id)
     ;
     
     
     CREATE TABLE COUNTRIES 
    ( COUNTRY_ID      CHAR(2) 
       CONSTRAINT  COUNTRY_ID_NN NOT NULL 
    , COUNTRY_NAME    VARCHAR(40) 
    , REGION_ID       int 
    , CONSTRAINT     COUNTRY_C_ID_PK 
                     PRIMARY KEY (COUNTRY_ID) 
    ) 
    
    
    
    ALTER TABLE COUNTRIES
ADD  CONSTRAINT COUNTR_REG_FK
                 FOREIGN KEY (REGION_ID)
                  REFERENCES REGIONS(REGION_ID) 
 
 
 
 
 CREATE TABLE LOCATIONS
    ( LOCATION_ID    int not null
    , STREET_ADDRESS VARCHAR(40)
    , POSTAL_CODE    VARCHAR(12)
    , CITY       VARCHAR(30)
        CONSTRAINT     LOC_CITY_NN  NOT NULL
    , STATE_PROVINCE VARCHAR(25)
    , COUNTRY_ID     CHAR(2)
    ) ;
    
    
    
    
    ALTER TABLE LOCATIONS
ADD  CONSTRAINT LOC_ID_PK
                 PRIMARY KEY (LOCATION_ID)
    , CONSTRAINT LOC_C_ID_FK
                 FOREIGN KEY (COUNTRY_ID)
                  REFERENCES COUNTRIES(COUNTRY_ID) 
                  
                  
                  
                  
                  
                  
INSERT INTO regions VALUES( 1, 'Europe');
INSERT INTO regions VALUES( 2, 'Americas');
INSERT INTO regions VALUES( 3, 'Asia');
INSERT INTO regions VALUES( 4, 'Middle East and Africa');





INSERT INTO countries VALUES( 'IT', 'Italy', 1);
INSERT INTO countries VALUES( 'JP', 'Japan', 3);
INSERT INTO countries VALUES( 'US', 'United States of America', 2);
INSERT INTO countries VALUES( 'CA', 'Canada', 2);
INSERT INTO countries VALUES( 'CN', 'China', 3);
INSERT INTO countries VALUES( 'IN', 'India', 3);
INSERT INTO countries VALUES( 'AU', 'Australia', 3);
INSERT INTO countries VALUES( 'ZW', 'Zimbabwe',4);


INSERT INTO countries VALUES( 'SG', 'Singapore', 3);
INSERT INTO countries VALUES( 'UK', 'United Kingdom', 1);
INSERT INTO countries VALUES( 'FR', 'France', 1);
INSERT INTO countries VALUES( 'DE', 'Germany', 1);
INSERT INTO countries VALUES( 'ZM', 'Zambia', 4);
INSERT INTO countries VALUES( 'EG', 'Egypt', 4);
INSERT INTO countries VALUES( 'BR', 'Brazil', 2);
INSERT INTO countries VALUES( 'CH', 'Switzerland', 1);


INSERT INTO countries VALUES( 'NL', 'Netherlands', 1);
INSERT INTO countries VALUES( 'MX', 'Mexico', 2);
INSERT INTO countries VALUES( 'KW', 'Kuwait', 4);
INSERT INTO countries VALUES( 'IL', 'Israel', 4);
INSERT INTO countries VALUES( 'DK', 'Denmark', 1);
INSERT INTO countries VALUES( 'HK', 'HongKong', 3);
INSERT INTO countries VALUES( 'NG', 'Nigeria', 4);
INSERT INTO countries VALUES( 'AR', 'Argentina', 2);
INSERT INTO countries VALUES( 'BE', 'Belgium', 1);




INSERT INTO locations VALUES( 1000, '1297 Via Cola di Rie', '00989', 'Roma', NULL, 'IT');
INSERT INTO locations VALUES( 1100, '93091 Calle della Testa', '10934', 'Venice', NULL, 'IT');
INSERT INTO locations VALUES( 1200, '2017 Shinjuku-ku', '1689', 'Tokyo', 'Tokyo Prefecture', 'JP');
INSERT INTO locations VALUES( 1300, '9450 Kamiya-cho', '6823', 'Hiroshima', NULL, 'JP');
INSERT INTO locations VALUES( 1400, '2014 Jabberwocky Rd', '26192', 'Southlake', 'Texas', 'US');
INSERT INTO locations VALUES( 1500, '2011 Interiors Blvd', '99236', 'South San Francisco', 'California', 'US');
INSERT INTO locations VALUES( 1600, '2007 Zagora St', '50090', 'South Brunswick', 'New Jersey', 'US');
INSERT INTO locations VALUES( 1700, '2004 Charade Rd', '98199', 'Seattle', 'Washington', 'US');
INSERT INTO locations VALUES( 1800, '147 Spadina Ave', 'M5V 2L7', 'Toronto', 'Ontario', 'CA');
INSERT INTO locations VALUES( 1900, '6092 Boxwood St', 'YSW 9T2', 'Whitehorse', 'Yukon', 'CA');

SELECT * FROM REGIONS
SELECT * FROM COUNTRIES
SELECT * FROM LOCATIONS

INSERT INTO REGIONS(region_id,region_name)
VALUES(5,'Australia');

SELECT * 
FROM REGIONS r LEFT JOIN COUNTRIES c
ON r.region_id=c.REGION_ID
WHERE c.COUNTRY_NAME IS NULL;

SELECT * 
FROM COUNTRIES c LEFT JOIN LOCATIONS l
ON c.COUNTRY_ID=l.COUNTRY_ID
WHERE l.LOCATION_ID IS NULL;

SELECT r.region_name, COUNT(c.COUNTRY_NAME)
FROM REGIONS r LEFT JOIN COUNTRIES c
ON r.region_id=c.REGION_ID
GROUP BY r.region_name;

SELECT c.COUNTRY_NAME, COUNT(l.CITY)
FROM COUNTRIES c LEFT JOIN LOCATIONS l
ON c.COUNTRY_ID=l.COUNTRY_ID
GROUP BY c.COUNTRY_NAME;

SELECT r.region_name,c.COUNTRY_NAME, COUNT(l.CITY)AS NO_OF_LOCATIONS
FROM REGIONS r 
LEFT JOIN (COUNTRIES c 
LEFT JOIN LOCATIONS l 
ON c.COUNTRY_ID=l.COUNTRY_ID)
ON r.region_id=c.REGION_ID 
GROUP BY c.COUNTRY_NAME,r.region_name;


SELECT r.region_name,c.COUNTRY_NAME,l.CITY
FROM REGIONS r
JOIN (COUNTRIES c 
JOIN LOCATIONS l 
ON c.COUNTRY_ID=l.COUNTRY_ID)
ON r.REGION_ID=c.REGION_ID;

SELECT e.ENAME AS EMPLOYEE, m.ENAME AS MANAGER,d.DNAME AS DEPARTMENT
FROM EMP e 
LEFT JOIN (EMP m
LEFT JOIN DEPT d
ON m.DEPTNO=d.DEPTNO) 
ON e.MGR=m.EMPNO;

SELECT * FROM LOCATIONS WHERE CITY='Mumbai'

INSERT INTO LOCATIONS(LOCATION_ID,STREET_ADDRESS,CITY)
VALUES(1880,'Hitech','Ahmedabad');

INSERT INTO LOCATIONS(LOCATION_ID,STREET_ADDRESS,CITY)
VALUES(1890,'Swabhav','Mumbai');


/*STORED PROCEDURES*/
CREATE PROCEDURE usp_giveHikeToEmployee
@empId INT,@percent INT

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE EMP SET SAL=SAL+(SAL*@percent/100) WHERE EMPNO=@empId;
END

DROP PROCEDURE usp_giveHikeToEmployee

UPDATE EMP SET SAL=800 WHERE EMPNO=7369;
SELECT * FROM EMP

EXEC usp_giveHikeToEmployee 7369,50

CREATE PROCEDURE usp_giveHikeToDeptEmployee
@deptNo INT,@percent INT

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE EMP SET SAL=SAL+(SAL*@percent/100) WHERE DEPTNO=@deptNo;
END

EXEC usp_giveHikeToDeptEmployee 20,50

SELECT * INTO EMP10 FROM EMP
SELECT * INTO DEPT10 FROM DEPT

SELECT * FROM DEPT10

select convert(datetime,CONVERT(date,getdate()))
SELECT replace(convert(varchar, getdate(),105),'-','')

create function customGetDate()
returns VARCHAR(20)
as
begin
      return(SELECT REPLACE(CONVERT(varchar, getdate(),105),'-',''))
end
go

DROP FUNCTION customGetDate

SELECT dbo.customGetDate() AS CUSTOM_DATE


CREATE TABLE FOO(
	id INT IDENTITY(1,1),
	description VARCHAR(20)
)

INSERT INTO FOO(description)
VALUES('first')

SELECT * FROM FOO

BEGIN TRANSACTION trans
BEGIN TRY
	INSERT INTO FOO(description)
	VALUES('ten')
	INSERT INTO FOO(description)
	VALUES('eleven'+5)
	IF @@TRANCOUNT>0
	BEGIN COMMIT TRANSACTION trans
	END
END TRY
BEGIN CATCH
	print 'Error OCCURED'
	IF @@TRANCOUNT>0
	BEGIN ROLLBACK TRANSACTION trans
	END
END CATCH

DELETE
FROM FOO

SELECT * FROM EMP10
SELECT * FROM DEPT10 WHERE DEPTNO=30
SELECT * FROM DEPT WHERE DEPTNO=30

SELECT * FROM EMP10 WHERE ENAME LIKE '%A%'
SELECT * FROM EMP WHERE ENAME LIKE '%A%'

SELECT * FROM STUDENT2

CREATE TRIGGER autoCapitalize
ON STUDENT2
INSTEAD OF INSERT
AS 
BEGIN

INSERT INTO STUDENT2 
SELECT UPPER(I.student_name),I.student_CGPA,I.student_contact,I.student_college 
FROM INSERTED I

END

DROP TRIGGER autoCapitalize
SELECT * FROM STUDENT2

INSERT INTO STUDENT2(student_name,student_CGPA,student_contact,student_college)
VALUES('toon',8.5,1524897365,1)

