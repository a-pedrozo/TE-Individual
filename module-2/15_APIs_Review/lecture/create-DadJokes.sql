USE master;
GO

DROP DATABASE IF EXISTS DadJokes;
GO

CREATE DATABASE DadJokes;
GO

USE DadJokes;
GO

CREATE TABLE Dads (
	id int IDENTITY(1,1) PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE Jokes (
	id int IDENTITY(1,1) PRIMARY KEY,
	setup NVARCHAR(255) NOT NULL,
	punchline NVARCHAR(255) NOT NULL,
	date_added DATETIME2 NOT NULL,
	dad_id INT NULL
);
GO

ALTER TABLE Jokes
	-- When a joke is added, and the date isn't specified, use the current date for date_added
	ADD CONSTRAINT DF_DATE_ADDED DEFAULT GETDATE() FOR date_added
GO
ALTER TABLE Jokes
	ADD CONSTRAINT FK_Jokes_Dads FOREIGN KEY (dad_id) REFERENCES Dads(id)
GO

INSERT INTO Dads (name)
VALUES ('Matt', 'John')

INSERT INTO Jokes (setup, punchline, dad_id)
VALUES 
('What do you call this: ["hip", "hip"]', 'A hip hip array!', NULL),
('What do you call a skinny ghost?', 'A boo-lean!', 2),
('Want to hear a joke about constructors?', 'I''m still building it.', 1)

SELECT * FROM Jokes
SELECT * FROM Dads
