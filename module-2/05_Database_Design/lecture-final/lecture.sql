-- Switch to the system (aka master) database
USE master
GO

-- Delete the ArtGallery Database (IF EXISTS)
DROP DATABASE IF EXISTS ArtGallery;
GO

-- Create a new ArtGallery Database
CREATE DATABASE ArtGallery;
GO

-- Switch to the ArtGallery Database
USE ArtGallery
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION

-- Create tables as needed (adding primary key and foreign key constraints)
CREATE TABLE Person (
	person_id int IDENTITY(1,1) PRIMARY KEY,
	address nvarchar(300), -- Allows nulls
	person_name nvarchar(140) NOT NULL,
	phone nvarchar(20)
);
GO

CREATE TABLE Painting (
	painting_id int IDENTITY(1,1),
	artist_id int,
	painting_title nvarchar(140) NOT NULL,

	-- This creates a NAMED primary key constraint (named pk_painting) on the painting_id column
	CONSTRAINT pk_painting PRIMARY KEY (painting_id),

	-- Create a NAMED foreign key constraint pointing to the Person table
	CONSTRAINT fk_painting_person FOREIGN KEY (artist_id) REFERENCES Person(person_id)
);
GO

CREATE TABLE Purchase (
	purchase_id int IDENTITY(1,1) PRIMARY KEY,
	painting_id int NOT NULL,
	buyer_id int NOT NULL,
	sale_price decimal(9,2) NOT NULL,
	purchase_date datetime2 NOT NULL,

	CONSTRAINT fk_purchase_painting FOREIGN KEY (painting_id) REFERENCES Painting(painting_id),
	CONSTRAINT fk_purchase_person FOREIGN KEY (buyer_id) REFERENCES Person(person_id)
);
GO
-- Insert Rows into each Table
INSERT INTO Person (address, person_name, phone)
VALUES ('42 Wallaby Way', 'Jimothy', '411'), ('1600 Pennsylvania Avenue', 'Presidential Mainframe', '0')

INSERT INTO Painting (artist_id, painting_title)
VALUES (1, 'Man with Cheese')

INSERT INTO Purchase (painting_id, buyer_id, sale_price, purchase_date)
VALUES (1, 2, 20.42, GETDATE()) -- '6/17/2022'

-- Commit the Transaction
COMMIT TRANSACTION

-- Select * from each table
SELECT * FROM Person
SELECT * FROM Painting
SELECT * FROM Purchase
