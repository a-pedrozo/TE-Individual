-- SELECT
-- Use a SELECT statement to return a literal string
SELECT
	'Hello Module 2',
	'.NET CBUS 17 is awesome'


-- Use a SELECT statement to add two numbers together (and label the result "sum")
SELECT
	40 + 2


-- SELECT ... FROM
-- Write queries to retrieve...

-- The names from all the records in the state table
SELECT
	s.state_name
FROM
	state s

-- The names and populations of all cities
SELECT
	c.city_name,
	c.population
FROM
	city c

-- All columns from the park table
SELECT
	p.* -- Give me all columns from the Park table (THIS IS BAD. ONLY DO THIS WHEN EXPLORING DATA!)
FROM
	park p



-- SELECT __ FROM __ WHERE
-- Write queries to retrieve...

-- The names of cities in California (CA)
SELECT
	c.city_name
FROM
	city c
WHERE
	c.state_abbreviation = 'CA'


-- The names and state abbreviations of cities NOT in California
SELECT
	c.city_name,
	c.state_abbreviation
FROM
	city c
WHERE
	c.state_abbreviation <> 'CA' -- != works, but is not the recommended way

-- The names and areas of cities smaller than 25 square kilometers 
SELECT
	c.area,
	c.city_name
FROM
	city c
WHERE
	c.area < 25 -- Assuming area is square km

-- The names from all records in the state table that have no assigned census region
SELECT
	s.state_name
FROM
	state s
WHERE
	s.census_region IS NULL -- = NULL will NEVER return any results. Never do "= NULL", do "IS NULL" instead

-- The names and census regions from all records in the state table that have an assigned census region
SELECT
	s.state_name,
	s.census_region
FROM
	state s
WHERE
	s.census_region IS NOT NULL -- Always do "IS NOT NULL" instead of "<> NULL" or "!= NULL"

-- WHERE with AND/OR
-- Write queries to retrieve...

-- The names, areas, and populations of cities smaller than 25 sq. km. with more than 100,000 people
SELECT
	c.city_name,
	c.area,
	c.population
FROM
	city c
WHERE
	c.area < 25 -- assuming km
	AND c.population > 100000 -- assuming numbers are individual populations (not thousands)

-- The names and census regions of all states (and territories and districts) not in the Midwest 
-- region (including those that don't have any census region)
SELECT
	s.state_name,
	s.census_region
FROM
	state s
WHERE
	s.census_region <> 'Midwest'
	OR s.census_region IS NULL

-- What are the UNIQUE values of census_region
SELECT DISTINCT -- Distinct says that each row in the result set must be completely unique (ignore duplicates)
	s.census_region
FROM
	state s

-- The names, areas, and populations of cities in California (CA) or Florida (FL)
SELECT
	c.city_name,
	c.area,
	c.population
FROM
	city c
WHERE
	c.state_abbreviation = 'CA'
	OR c.state_abbreviation = 'FL'

SELECT
	c.city_name,
	c.area,
	c.population
FROM
	city c
WHERE
	c.state_abbreviation IN ('CA', 'FL') -- equivalent to 'CA' OR 'FL'

-- The names, areas, and populations of cities in New England -- Connecticut (CT), Maine (ME), Massachusetts (MA), New Hampshire (NH), Rhode Island (RI) and Vermont (VT)
SELECT
	c.city_name,
	c.area,
	c.population
FROM
	city c
WHERE
	c.state_abbreviation IN ('CT', 'ME', 'MA', 'NH', 'RI', 'VT')


-- SELECT statements involving math
-- Write a query to retrieve the names and areas of all parks in square METERS
-- (the values in the database are stored in square kilometers)
-- Label the second column "area_in_square_meters"
SELECT
	100 AS 'Value' -- re-labels this column in the result set

SELECT
	p.park_name,
	p.area AS 'Area in KM',
	p.area * 1000000 AS 'Area in Meters'
FROM
	park p




-- All values vs. distinct values

-- Write a query to retrieve the names of all cities and notice repeats (like Springfield and Columbus)
SELECT
	c.city_name
FROM
	city c

-- Do it again, but without the repeats (note the difference in row count)
SELECT DISTINCT
	c.city_name
FROM
	city c


-- LIKE
-- Write queries to retrieve...
SELECT
	c.city_name
FROM
	city c
WHERE
	c.city_name = 'Columbus'

-- The names of all cities that begin with the letter "A"
SELECT
	c.city_name
FROM
	city c
WHERE
	c.city_name LIKE 'A%' -- starts with 'A'

-- The names of all cities that end with "Falls"
SELECT
	c.city_name
FROM
	city c
WHERE
	c.city_name LIKE '%Falls'

-- The names of all cities that contain a space
SELECT
	c.city_name
FROM
	city c
WHERE
	c.city_name LIKE '% %' -- must have a space. Anything before or after is fine

-- BETWEEN
-- Write a query to retrieve the names and areas of parks of at least 100 sq. kilometers but no more than 200 sq. kilometers
SELECT
	p.park_name,
	p.area
FROM
	park p
WHERE
	p.area >= 100
	AND p.area <= 200

SELECT
	p.park_name,
	p.area
FROM
	park p
WHERE
	p.area BETWEEN 100 AND 200

-- DATES
-- Write a query to retrieve the names and dates established of parks established before 1900
SELECT
	p.park_name,
	p.date_established
FROM
	park p
WHERE
	p.date_established < '1900-01-01' -- Jan 1 1900

SELECT
	p.park_name,
	p.date_established
FROM
	park p
WHERE
	p.date_established BETWEEN '1900-01-01' AND '1942-12-31'
