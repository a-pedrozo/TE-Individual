USE master 
GO
DROP DATABASE IF EXISTS Meetups;
GO 
CREATE DATABASE Meetups;
GO 
USE Meetups;
GO 


CREATE TABLE Member(
Id int IDENTITY (1,1) PRIMARY KEY,
member_id int ,
first_name nvarchar(200) NOT NULL,
last_name nvarchar(200) NOT NULL,
email nvarchar(200) NOT NULL, 
phone_number nvarchar(200),
birthday nvarchar(200) NOT NULL,
email_notification BIT
);

GO 


CREATE TABLE tbl_Group (
group_id int IDENTITY (1,1),
group_name nvarchar(200) PRIMARY KEY,
member_id int NOT NULL,
event_id int NOT NULL

); 
GO 


CREATE TABLE tbl_Event (
ID int IDENTITY (1,1) PRIMARY KEY,
event_id int NOT NULL,
name nvarchar(200)  NOT NULL,
description nvarchar(200) NOT NULL,
start_date_time datetime NOT NULL, 
duration int NOT NULL,
group_name nvarchar(200) NOT NULL
); 
GO 

INSERT INTO Member (member_id, first_name, last_name, email, phone_number, birthday)
VALUES (1, 'Jimothy', 'DOTnet', 'sqlhard@gmail.com', null, '19961201'), 
(2, 'Archer', 'Sterling', 'phrasing@gmail.com', null, '19951113'), 
(3, 'Monkey D', 'Luffy', 'kingofpirates@gmail.com', null, '19990511'), 
(1,'Johhny', 'Depp', 'whydoesmybedsmellfunnny@gmail.com', null, '19010512'), 
(2,'morty', 'smith', 'weirdmail@gmail.com', null, '20070408'), 
(3,'ash', 'ketchum', 'gottacatchthemall@gmail.com', null, '19850311'), 
(2,'Rick', 'Sanchez', 'c137@gmail.com', null, '120012108'), 
(1,'Bender', 'Rodriguez', 'meatbag@gmail.com', null, '30051605')

INSERT INTO tbl_Group (group_name, member_id, event_id)
VALUES ('breakfast club', 1, 2), ('men of culture', 2, 4), ('thoseguys', 3, 3)

INSERT INTO tbl_Event (name, description, start_date_time, duration, group_name, event_id)
VALUES ('this place' , 'sql is kicking me in the gut' , '20221111', 30, 'breakfast club', 1),
('flying into the danger zone' , 'are we still doing phrasing?' , '20221211', 45, 'men of culture', 2),
('interdemintional cable tv show' , 'lets get shwifty' , '20221112', 69, 'those guys', 3),
('captan jack sparrow adventures' , 'but why is the rum gone' , '20221111', 55, 'men of culture', 4)

--select * from tbl_Group
--select * from Member
--select * from tbl_Event
