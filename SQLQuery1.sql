USE master
go
drop database H_Tshop
go
create database H_Tshop
go
use H_Tshop


-- FUNCION
go
CREATE FUNCTION AUTO_ID_CAKES()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(Cake_ID) FROM Cakes) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(Cake_ID, 3)) FROM Cakes
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'CA00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'CA0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'CA' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE FUNCTION AUTO_ID_Payment()
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(Customer_Payment_ID) FROM Customer_Payment_Methods) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(Customer_Payment_ID, 3)) FROM Customer_Payment_Methods
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'PM0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'PM000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 and @ID <999 THEN 'PM00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 and @ID <9999 THEN 'PM0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999  THEN 'PM' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
-- create table

create table LoginSystem
(
	ID varchar(50) primary key,
	Pass char(255),
	ID_Rule int, --0: customer 1:driver 2:chef 3:admin
)


create table Customer (
Customer_ID varchar(50) primary key  REFERENCES LoginSystem(ID),
Customer_Name nvarchar(20),
Customer_Phone char(12),
Customer_Email varchar(30),
Customer_Adress nvarchar(MAX),
Customer_Payment_ID char(5),

)

create table Payment_Methods
(
Payment_Method_Code char(2) primary key,
Payment_Method_Descripsion nvarchar(30),
--AM=AmEx,MC=MasterCard,CSH=cash
)

create table Customer_Payment_Methods
(
	Customer_Payment_ID char(7) primary key,
	Customer_ID varchar(50) REFERENCES Customer(Customer_ID),
	Payment_Menthod_Code char(2) REFERENCES Payment_Methods(Payment_Method_Code),
	Card_Number char(16),
	Date_from char(4),
	Date_to char(4),
)

create table Chef
(
	Chef_ID varchar(50) primary key REFERENCES LoginSystem(ID),
	Chef_Name nvarchar(30),
	Chef_Phone char(12),
)

create table Driver
(
	Driver_ID varchar(50) primary key REFERENCES LoginSystem(ID),
	Driver_Name nvarchar(30),
	Driver_Phone char(12),	
)

create table Manager
(
	Manager_ID varchar(50) primary key REFERENCES LoginSystem(ID),
	Manager_Name nvarchar(30),
	Manager_Phone char(12),

)

create table Cake_Type
(
	Cake_Type_Code char(7) primary key,
	Cake_Type_Name nvarchar(50),
)
create table Cakes
(
	Cake_ID char(5) primary key default dbo.AUTO_ID_CAKES(),
	Cake_Name nvarchar(20),
	Cake_Type_Code char(7) REFERENCES Cake_Type(Cake_Type_Code),
	Cake_Price float,
	Discount float, -- [0-99]
	Cake_decripsion nvarchar(50),
)
create table Cake_Image
(
	Imange_ID int identity primary key,
	Cake_ID char(5) REFERENCES Cakes(Cake_ID),
	Cake_Image nvarchar(max),
)
CREATE TABLE COMMENT(
	Comment_ID INT IDENTITY PRIMARY KEY,
	Customer_ID varchar(50) REFERENCES Customer(Customer_ID),
	Cake_ID char(5) REFERENCES Cakes(Cake_ID),
	Time_comment DATETIME,
	Content NVARCHAR(MAX)
)
create table Cart
(
	Customer_ID varchar(50) REFERENCES Customer(Customer_ID),
	Cart_ID INT IDENTITY PRIMARY KEY,
	Customer_Payment_ID char(7),
	Payment_time datetime,
	Shipping_Address nvarchar(50),
	Customer_Requirements nvarchar(200),
	Cart_Status int, --0: unpaid 1: not delivery 2: delivered
	Total float,
	Driver_ID varchar(50) REFERENCES Driver(Driver_ID)
)
create table Cart_Item
(
	Cake_ID char(5) REFERENCES Cakes(Cake_ID),
	Cart_ID int REFERENCES Cart(Cart_ID),
	Quantity int,
	Orther nvarchar(MAX),
	primary key(Cake_ID,Cart_ID)
)
