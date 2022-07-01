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
VALUES ('Matt'), ('John')

INSERT INTO Jokes (setup, punchline, dad_id)
VALUES 
('What do you call this: ["hip", "hip"]', 'A hip hip array!', 1),
('What do you call a skinny ghost?', 'A boo-lean!', NULL),
('Want to hear a joke about constructors?', 'I''m still building it.', 1),
('Did you hear about the DBA who got divorced?', 'Their spouse was having a 1:Many relationship', 2),
('As a programmer, sometimes I feel a void', 'And I know I’ve reached the point of no return', 1),
('Why does Yoda’s code always crash?', 'Because there is no try.', 1),
('Why did the functions stop calling each other?', 'Because they had constant arguments (or parameters)', 2),
('My wife said I was immature.', 'So I told her to get out of my fort!', 1),
('What concert is just 45 cents?', '50 cent featuring Nickelback', NULL),
('Why don’t bachelors like Git?', 'They''re afraid to commit.', NULL),
('I was having a hard time understanding source control…','But now I''m starting to git it.', 2)

SELECT * FROM Jokes
SELECT * FROM Dads
