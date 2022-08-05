USE master
GO

-- Drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

-- Create Tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

-- Populate default data for testing: user and admin with password of 'password'
-- These values should not be kept when going to Production
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');
GO

-- Add a table for trolley problems
CREATE TABLE trolley_problems (
	id int IDENTITY(1,1) NOT NULL,
	problem nvarchar(300) NOT NULL,
	times_pulled_lever int NOT NULL,
	times_not_pulled int NOT NULL,
	CONSTRAINT PK_trolley_problems PRIMARY KEY (id)
)
GO

INSERT INTO trolley_problems (problem, times_pulled_lever, times_not_pulled)
VALUES ('A trolley is headed towards 5 kids, unless you pull the lever. If you do that, you have to use Vue.js', 0, 0),
('A trolley is going to make many people use JavaScript, unless you pull the lever, but then you would have to do work', 0, 0),
('A trolley is parked. Pulling a lever gives you something to do.', 0, 0)
GO

SELECT * FROM trolley_problems
