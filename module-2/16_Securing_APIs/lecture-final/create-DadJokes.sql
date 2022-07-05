USE master;
GO

DROP DATABASE IF EXISTS DadJokesAuth;
GO

CREATE DATABASE DadJokesAuth;
GO

USE DadJokesAuth;
GO


CREATE TABLE users (
	user_id int IDENTITY(3000,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	role nvarchar(200) NOT NULL,
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE Jokes (
	id int IDENTITY(1,1) PRIMARY KEY,
	setup NVARCHAR(255) NOT NULL,
	punchline NVARCHAR(255) NOT NULL,
	date_added DATETIME2 NOT NULL,
	user_id INT NULL
);
GO

ALTER TABLE Jokes
	-- When a joke is added, and the date isn't specified, use the current date for date_added
	ADD CONSTRAINT DF_DATE_ADDED DEFAULT GETDATE() FOR date_added
GO
ALTER TABLE Jokes
	ADD CONSTRAINT FK_Jokes_Users FOREIGN KEY (user_id) REFERENCES users(user_id)
GO

INSERT INTO Users (username, password_hash, salt, role)
VALUES
('meland',  'UZbuAvE/0/R1ui7SWsnAlJKmTj0=', '6OPsUJ2JbEE=',  'Admin'), -- FuzzyBunny
('jfulton', 'a/EKaeZaGXj54fdj83Kv1hFAdz8=', 'X3CoFG5cN+I==', 'Admin'), -- Elevate
('jimothy', 'BnXEOJclqXcqZZX0h/xXYi2i1iQ=', '8onPh1Xa61I=',  'User')   -- Password
GO

INSERT INTO Jokes (setup, punchline, user_id)
VALUES 
('What do you call this: ["hip", "hip"]', 'A hip hip array!', 3000),
('What do you call a skinny ghost?', 'A boo-lean!', NULL),
('Want to hear a joke about constructors?', 'I''m still building it.', 3000),
('Did you hear about the DBA who got divorced?', 'Their spouse was having a 1:Many relationship', 3001),
('As a programmer, sometimes I feel a void', 'And I know I’ve reached the point of no return', 3000),
('Why does Yoda’s code always crash?', 'Because there is no try.', 3000),
('Why did the functions stop calling each other?', 'Because they had constant arguments (or parameters)', 3001),
('My spouse said I was immature.', 'So I told them to get out of my fort!', 3000),
('What concert is just 45 cents?', '50 cent featuring Nickelback', NULL),
('Why don’t bachelors like Git?', 'They''re afraid to commit.', NULL),
('I was having a hard time understanding source control...','But now I''m starting to git it.', 3001)
GO

SELECT * FROM Jokes
SELECT * FROM Users

