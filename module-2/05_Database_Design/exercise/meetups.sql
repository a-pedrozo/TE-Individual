USE master 
GO
DROP DATABASE IF EXISTS Meetups;
GO 
CREATE DATABASE Meetups;
GO 
USE Meetups;
GO 

CREATE TABLE Member(
member_id int IDENTITY (1,1) PRIMARY KEY,
first_name nvarchar(200) NOT NULL,
last_name nvarchar(200) NOT NULL,
email nvarchar(200) NOT NULL, 
phone_number nvarchar(200),
birthday nvarchar(200) NOT NULL
--bool_email_notification?

);
GO 


CREATE TABLE tbl_Group (
group_id int IDENTITY (1,1),
group_name nvarchar(200) PRIMARY KEY,
member_id int 

); 
GO 

CREATE TABLE tbl_Event (
event_id int IDENTITY (1,1) PRIMARY KEY,
name nvarchar(200)  NOT NULL,
description nvarchar(200) NOT NULL,
start_date_time datetime NOT NULL, 
duration int NOT NULL,
group_name nvarchar(200) NOT NULL
); 
GO 

INSERT INTO Member (first_name, last_name, email, phone_number, birthday)
VALUES ('Jimothy', 'DOTnet', 'sqlhard@gmail.com', null, '19961201'), 
('Archer', 'Sterling', 'phrasing@gmail.com', null, '19951113'), 
('Monkey D', 'Luffy', 'kingofpirates@gmail.com', null, '19990511'), 
('Johhny', 'Depp', 'whydoesmybedsmellfunnny@gmail.com', null, '19010512'), 
('morty', 'smith', 'weirdmail@gmail.com', null, '20070408'), 
('ash', 'ketchum', 'gottacatchthemall@gmail.com', null, '19850311'), 
('Rick', 'Sanchez', 'c137@gmail.com', null, '120012108'), 
('Bender', 'Rodriguez', 'meatbag@gmail.com', null, '30051605')

INSERT INTO tbl_Group (group_name, member_id)
VALUES ('breakfast club', 1, 3), ('men of culture', 2, 5), ('thoseguys', 3,7)

INSERT INTO tbl_Event (name, description, start_date_time, duration, group_name)
VALUES ('this place' , 'sql is kicking me in the gut' , '20221111', 30, 'breakfast club'),
('flying into the danger zone' , 'are we still doing phrasing?' , '20221211', 45, 'men of culture'),
('interdemintional cable tv show' , 'lets get shwifty' , '20221112', 69, 'those guys'),
('captan jack sparrow adventures' , 'but why is the rum gone' , '20221311', 55, 'men of culture')
