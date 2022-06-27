USE master;
GO

DROP DATABASE IF EXISTS DadJokes;
GO

CREATE DATABASE DadJokes;
GO

USE DadJokes;
GO

CREATE TABLE Dads(
	id int IDENTITY (1,1) PRIMARY KEY, 
	name nvarchar (255) NOT NULL
);
GO

CREATE TABLE Jokes (
id int IDENTITY (1,1) PRIMARY KEY, 
setup nvarchar(255) NOT NULL,
punchline nvarchar(255) NOT NULL,
date_added datetime2 NOT NULL,
dad_id INT NULL
); 
GO

ALTER TABLE Jokes 
ADD CONSTRAINT DF_DATE_ADDED DEFAULT GETDATE() FOR date_added
GO 
ALTER TABLE Jokes
ADD CONSTRAINT FK_Jokes_Dads FOREIGN KEY (dad_id) REFERENCES Dads(id)
GO
INSERT INTO Dads(name)
VALUES ('matt', 'john', 'jimothy')
INSERT INTO Jokes (setup, punchline, dad_id)
VALUES 
('What do you call this: ["hip", "hip"]', 'A hip hip array!',3),
('What do you call a skinny ghost?', 'a boo-lean!',1),
('want to hear a joke about constructors?', 'I am still building it',2)

--select j.setup, j.punchline, j.date_added from Jokes j
--INSERT INTO Jokes (setup, punchline) Values ('as a programmer, sometimes i feel a void', 'And i know i have reached a point of no return')
