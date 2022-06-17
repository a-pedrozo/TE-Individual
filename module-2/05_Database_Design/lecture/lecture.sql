-- Switch to the system (aka master) database
USE master
GO 
-- Delete the ArtGallery Database (IF EXISTS)
DROP DATABASE IF EXISTS ArtGallery;
-- Create a new ArtGallery Database
CREATE DATABASE ArtGallery;
GO
-- Switch to the ArtGallery Database
USE ArtGallery
GO
-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION 

-- Create tables as needed (adding primary key and foreign key constraints)
CREATE TABLE Persons (
	person_id int IDENTITY(1,1) PRIMARY KEY,
	address nvarchar(300), --allows nulls 
	person_name nvarchar(69) NOT NULL, 
	phone_number nvarchar(20)
);
GO

CREATE TABLE Painting (
	painting_id int IDENTITY(1,1),
	artist_id int,
	paintint_title nvarchar(140) NOT NULL,
	-- creates a named primary key contraint (named pk_painting) on the painting_id column 
	CONSTRAINT pk_painting PRIMARY KEY (painting_id),

	--create a named foreign key contraint pointint toward the person table 
	CONSTRAINT fk_painting_person FOREIGN KEY (artist_id) REFERENCES Persons(person_id)
);
GO


CREATE TABLE Purchase (
	purchase_id int IDENTITY (1,1) PRIMARY KEY,
	painting_id int NOT NULL, 
	buyer_id int NOT NULL,
	sales_price decimal(9,2) NOT NULL,
	purchase_date datetime2 NOT NULL

	CONSTRAINT fk_purchase_painting FOREIGN KEY (painting_id) REFERENCES Painting(painting_id),

	CONSTRAINT fk_purchase_person FOREIGN KEY (buyer_id) REFERENCES Persons(person_id)
);
GO
-- Insert Rows into each Table
INSERT INTO Persons(address, person_name, phone_number)
VALUES ('wako texas', 'Jimothey', '911'), ('169 pennstate ave', 'Presidentail mainframe', '0')

INSERT INTO Painting(artist_id, paintint_title)
VALUES (1,'Man with cheese')

INSERT INTO Purchase (painting_id, buyer_id, sales_price, purchase_date)
VALUES (1,2, 200.69, GETDATE()) -- GETDATE will get todays date
-- Commit the Transaction
COMMIT TRANSACTION
-- Select * from each table
SELECT * FROM Persons 
SELECT * FROM Painting
SELECT * FROM Purchase
