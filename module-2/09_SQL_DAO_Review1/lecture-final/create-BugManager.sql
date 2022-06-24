USE master;
GO

DROP DATABASE IF EXISTS BugManager;
GO

CREATE DATABASE BugManager;
GO

USE BugManager;
GO

-- Your DDL statements go here to create the Bugs table
CREATE TABLE Bugs(
	id int IDENTITY(1,1) PRIMARY KEY,
	summary nvarchar(255) NOT NULL,
	assignedTo nvarchar(255) NOT NULL,
	isOpen bit NOT NULL
);
GO

-- Your DML statements go here to insert any starting Bugs you may want
INSERT INTO Bugs(summary, assignedTo, isOpen)
VALUES
('It is Thursday', 'Vinny', 1),
('I do not like Thursdays', 'Matt', 1),
('Time travel does not yet exist', 'Matt', 1),
('The dog needs a bath', 'Matt', 0),
('Microsoft did not ask Matt or John', 'Microsoft', 1)

-- Select all bugs
SELECT * FROM Bugs
