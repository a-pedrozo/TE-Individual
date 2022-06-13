-- SELECT
-- Use a SELECT statement to return a literal string
SELECT
	'Hello Module 2',
	'.NET CBUS 17 is awesome'
-- Use a SELECT statement to add two numbers together (and label the result "sum")
SELECT
	420 + 69


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
	p.* -- this is bad! only do this when exploring data!
FROM
	park p
	

-- SELECT __ FROM __ WHERE
-- Write queries to retrieve...

-- The names of cities in California (CA)
SELECT
	c.city_name,
	c.state_abbreviation
FROM	
	city c
WHERE -- how to retrieve certian data in database
	c.state_abbreviation = 'CA'
-- The names and state abbreviations of cities NOT in California
SELECT
	c.city_name,
	c.state_abbreviation
FROM
	city c
WHERE
	c.state_abbreviation <> 'CA' -- != works, but is not the recommended way,  prefered method is <>
-- The names and areas of cities smaller than 25 square kilometers 
SELECT
	c.area,
	c.city_name
FROM
	city c
WHERE
	c.area < 25 -- assuming area is sq km 
-- The names from all records in the state table that have no assigned census region
SELECT
	s.state_name
FROM
	state s
WHERE 
	s.census_region IS NULL --ISNULL is different that NULL , = NULL will never return any value 
-- The names and census regions from all records in the state table that have an assigned census region
SELECT
	s.state_name, -- make sure to use , when selecting more than one colum
	s.census_region
FROM
	state s
WHERE
	s.census_region IS NOT NULL -- always do IS NOT NULL, never use <> NULL or != NULL will compile but never return value 


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
	AND c.population > 100000 --assuming numbers are individual populations (not thousands) 
	-- will use AND and not , when setting conditions for searching 
-- The names and census regions of all states (and territories and districts) not in the Midwest region 
--(including those that don't have any census region)

SELECT
	s.state_name,
	s.census_region
FROM
	state s
WHERE
	s.census_region <> 'Midwest' -- not case sensitive 
	OR s.census_region IS NUll -- not have to capitalize IS NULL preference

-- what are the UNIQUE valies of census_region
SELECT DISTINCT -- will say data in rows must be unique (ignores duplicates) 
	s.census_region
FROM	
	state s


-- The names, areas, and populations of cities in California (CA) or Florida (FL)
SELECT
	c.city_name,
	c.population,
	c.area
FROM
	city c
WHERE
	c.state_abbreviation = 'CA'
	OR c.state_abbreviation = 'FL'


SELECT
	c.city_name,
	c.population,
	c.area
FROM
	city c
WHERE
	c.state_abbreviation IN ('CA' , 'FL') -- equivilent to 'CA' OR 'FL'

-- The names, areas, and populations of cities in New England -- 
--Connecticut (CT), Maine (ME), Massachusetts (MA), New Hampshire (NH), Rhode Island (RI) and Vermont (VT)
SELECT
	c.city_name,
	c.population,
	c.area
FROM
	city c
WHERE
	c.state_abbreviation IN ('ME' , 'CT', 'MA', 'NH', 'RI', 'VT') 


-- SELECT statements involving math
-- Write a query to retrieve the names and areas of all parks in square METERS
-- (the values in the database are stored in square kilometers)
-- Label the second column "area_in_square_meters"
SELECT
	100 AS 'VALUE' -- relables column in result set
SELECT
	p.park_name,
	p.area AS 'Area in KM',
	p.area * 1000000 AS 'Area in meters'
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
	c.city_id
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
	c.city_name LIKE '% %' -- must have a space anything before or after is fine


-- BETWEEN
-- Write a query to retrieve the names and areas of parks of at least 100 sq. kilometers but no more than 200 sq. kilometers
SELECT
	p.park_name,
	p.area
FROM 
	park p
WHERE
	p.area >= 100
	AND p.area <= 100

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
	p.date_established < '19000101'

SELECT
	p.park_name,
	p.date_established
FROM 
	park p
WHERE
	p.date_established BETWEEN '19000101' AND '19421231'
