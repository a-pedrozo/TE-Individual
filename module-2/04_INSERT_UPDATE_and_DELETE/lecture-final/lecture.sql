-- INSERT

-- Add Disneyland to the park table. (It was established on 7/17/1955, has an area of 2.1 square kilometers and does not offer camping.)
INSERT INTO
	park (park_name, date_established, area, has_camping) -- table_name (column1, column2, column3...)
VALUES
	('Disneyland', '7/17/1955', 2.1, 0)

SELECT TOP 1 * FROM park ORDER BY park_id DESC

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
	(64, 'CA') -- 64 is the ID of Disneyland within the parks table

	SELECT * FROM park_state
-- DELETE

-- Delete Hawkins, IN from the city table.
DELETE
FROM
	city
WHERE
	city_name = 'Hawkins'
	AND state_abbreviation = 'IN'

SELECT * FROM city

--DELETE FROM park_state

-- TRANSACTIONS Part 1

-- Delete the record for Cicely, AK within a transaction.
SELECT * FROM city WHERE city_name = 'Cicely'

BEGIN TRANSACTION

	DELETE FROM 
		city
	WHERE
		city_name = 'Cicely'
		AND state_abbreviation = 'AK'

COMMIT TRANSACTION -- Apply these changes to the dabase. We know they're good
-- ROLLBACK TRANSACTION -- Abort these changes; this was just a rehersal to make sure things worked

-- Delete all of the records from the park_state table, but then "undo" the deletion by rolling back the transaction.
BEGIN TRANSACTION

DELETE FROM
	park_state

	SELECT * FROM park_state

ROLLBACK TRANSACTION

SELECT * FROM park_state

-- Delete all cities with a population of less than 1,000 people from the city table.
BEGIN TRANSACTION

	DELETE FROM city
	WHERE population < 1000

ROLLBACK TRANSACTION



-- UPDATE

-- Rename Columbus, OH to Flavortown, OH
BEGIN TRANSACTION

	UPDATE
		city
	SET
		city_name = 'Flavortown'
	WHERE
		city_name = 'Columbus'
		AND state_abbreviation = 'OH'

ROLLBACK TRANSACTION


-- Update all of the cities to be in the state of Texas (TX), but then roll back the transaction.
BEGIN TRANSACTION

	UPDATE
		city
	SET
		state_abbreviation = 'TX'

ROLLBACK TRANSACTION

-- Increase the population of California by 1,000,000.
-- Change the capital of California to Anaheim.
BEGIN TRANSACTION

	UPDATE
		state
	SET
		population = population + 1000000,
		capital = 9 --(SELECT city_id FROM city WHERE city_name = 'Anaheim' AND state_abbreviation = 'CA') -- Returns 9, the City ID of Anaheim
	WHERE
		state_abbreviation = 'CA'

	SELECT population, capital FROM state WHERE state_abbreviation = 'CA'

ROLLBACK TRANSACTION



-- Change Ohio's nickname and adjust its population

SELECT
	SUM(population)
FROM
	city
WHERE
	state_abbreviation = 'OH' -- IO!

BEGIN TRANSACTION

	UPDATE
		state
	SET
		state_nickname = 'The place that''s there (It''s a Thursday in Flavornation)',
		population = (SELECT
							SUM(population)
						FROM
							city
						WHERE
							state_abbreviation = state.state_abbreviation
						)
	WHERE
		state_abbreviation = 'OH' -- IO!

	SELECT * FROM state WHERE state_abbreviation = 'OH'

ROLLBACK TRANSACTION


-- REFERENTIAL INTEGRITY

-- Try adding a city to the city table with "XX" as the state abbreviation.
INSERT INTO city (city_name, state_abbreviation, area)
VALUES ('Dotnettopolis', 'XX', 42)

-- Try deleting California from the state table.
DELETE FROM state WHERE state_abbreviation = 'CA'

-- Try deleting Disneyland from the park table. 
DELETE FROM park WHERE park_name LIKE 'Disney%'

-- Try again after deleting its record from the park_state table.
DELETE FROM park_state WHERE park_id = 64 -- 64 is Disneyland
DELETE FROM park WHERE park_name LIKE 'Disney%'


-- CONSTRAINTS

-- NOT NULL constraint
-- Try adding Smallville, KS to the city table without specifying its population or area.
INSERT INTO city (city_name, state_abbreviation)
VALUES ('Smallville', 'KS')

-- DEFAULT constraint
-- Try adding Smallville, KS again, specifying an area but not a population.
INSERT INTO city (city_name, state_abbreviation, area)
VALUES ('Smallville', 'KS', 1)


-- Retrieve the new record to confirm it has been given a default, non-null value for population.
SELECT * FROM city


-- UNIQUE constraint
-- Try changing California's nickname to "Vacationland" (which is already the nickname of Maine).
UPDATE state
SET
	state_nickname = 'Rich People Land (that probably have power (too soon?)(too soon))'
WHERE
	state_abbreviation = 'CA'

-- CHECK constraint
-- Try changing the census region of Florida (FL) to "Southeast" (which is not a valid census region).
UPDATE state
SET
	census_region = 'Gatortopia'
WHERE
	state_abbreviation = 'FL'


-- TRANSACTIONS Part 2


-- Demonstrate two different SQL connections trying to access the same table where one is inside of a transaction but hasn't committed yet.
BEGIN TRANSACTION

	UPDATE park
	SET has_camping = 1

ROLLBACK TRANSACTION
