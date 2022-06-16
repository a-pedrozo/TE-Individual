-- INSERT

-- Add Disneyland to the park table. (It was established on 7/17/1955, has an area of 2.1 square kilometers and does not offer camping.)
INSERT INTO
	park (park_name, date_established, area, has_camping) -- inserting table ie , table name( column 1, column 2, etc...) 
VALUES 
	('Disneyland', '7/17/1955', 2.1, 0) -- values for new table 


SELECT * FROM park
-- Add Hawkins, IN (with a population of 30,000 and an area of 38.1 square kilometers) and Cicely, AK (with a popuation of 839 and an area of 11.4 square kilometers) to the city table.
INSERT INTO 
	city (city_name, state_abbreviation, population, area)
VALUES 
	('Hawkins', 'IN', 30000, 38.1),
	('Cicely', 'AK', 839, 11.4)
SELECT * FROM city

-- Since Disneyland is in California (CA), add a record representing that to the park_state table.
INSERT INTO 
	park_state (park_id, state_abbreviation)
VALUES 
	(64, 'CA')


-- DELETE

-- Delete Hawkins, IN from the city table.
DELETE
FROM 
	city
WHERE
	city_name = 'Hawkins'

-- TRANSACTIONS Part 1

-- Delete the record for Smallville, KS within a transaction.


-- Delete all of the records from the park_state table, but then "undo" the deletion by rolling back the transaction.


-- Delete all cities with a population of less than 1,000 people from the city table.




-- UPDATE

-- Rename Columbus, OH to Flavortown, OH


-- Update all of the cities to be in the state of Texas (TX), but then roll back the transaction.


-- Increase the population of California by 1,000,000.


-- Change the capital of California to Anaheim.


-- Change Ohio's nickname and adjust its population




-- REFERENTIAL INTEGRITY

-- Try adding a city to the city table with "XX" as the state abbreviation.


-- Try deleting California from the state table.


-- Try deleting Disneyland from the park table. 

-- Try again after deleting its record from the park_state table.



-- CONSTRAINTS

-- NOT NULL constraint
-- Try adding Smallville, KS to the city table without specifying its population or area.


-- DEFAULT constraint
-- Try adding Smallville, KS again, specifying an area but not a population.


-- Retrieve the new record to confirm it has been given a default, non-null value for population.


-- UNIQUE constraint
-- Try changing California's nickname to "Vacationland" (which is already the nickname of Maine).


-- CHECK constraint
-- Try changing the census region of Florida (FL) to "Southeast" (which is not a valid census region).



-- TRANSACTIONS Part 2


-- Demonstrate two different SQL connections trying to access the same table where one is inside of a transaction but hasn't committed yet.
