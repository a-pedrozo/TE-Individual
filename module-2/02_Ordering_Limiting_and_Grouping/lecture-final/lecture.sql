-- ORDERING RESULTS

-- Populations of all states from smallest to largest.
SELECT
	s.state_name,
	s.population
FROM
	state s
ORDER BY
	s.population ASC -- ASC is ascending (A-Z) and ASC is assumed if not stated
					 -- DESC is descending (Z-A) and must be explicitly stated

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT
	s.state_name,
	s.census_region
FROM
	state s
ORDER BY
	s.census_region DESC, -- Order first by census region
	s.state_name		  -- In the event of a tie, next order by the state name

-- The biggest park by area
SELECT
	p.park_name,
	p.area
FROM
	park p
ORDER BY
	p.area DESC


-- LIMITING RESULTS

-- The 10 largest cities by populations
SELECT TOP 10
	c.city_name,
	c.population
FROM
	city c
ORDER BY
	c.population DESC

-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.
SELECT TOP 20 
	p.park_name,
	p.date_established
FROM
	park p
ORDER BY
	p.date_established ASC,
	p.park_name

-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.
SELECT
	c.city_name + ', ' + c.state_abbreviation AS 'Mailing Address'
FROM
	city c

-- All park names and area
SELECT
	p.park_name + ' Area: ' + FORMAT(p.area, 'N') + ' Established: ' + CONVERT(varchar, p.date_established)
FROM
	park p

-- The census region and state name of all states in the West & Midwest sorted in ascending order.
SELECT
	s.census_region,
	s.state_name
FROM
	state s
WHERE
	s.census_region IN ('West', 'Midwest')
ORDER BY
	s.census_region,
	s.state_name

-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.
SELECT
	AVG(s.population) AS 'Average Population',
	MIN(s.population) AS 'Min Pop',
	MAX(s.population) AS 'Max Pop'
FROM
	state s

-- Total population in the West and South census regions
SELECT
	SUM(s.population) AS 'Total Population'
FROM
	state s
WHERE
	s.census_region IN ('West', 'South')

-- The number of cities with populations greater than 1 million
SELECT
	COUNT(*) AS 'Number of Cities' -- could also do COUNT(1) or COUNT(c.population)
FROM
	city c
WHERE
	c.population > 1000000

SELECT
	* -- * is bad. Don't use *
FROM
	city c
WHERE
	c.population > 1000000
-- The number of state nicknames.
SELECT
	COUNT(s.state_nickname) -- Counting the nicknames that are not null
FROM
	state s

-- The area of the smallest and largest parks.
SELECT
	MIN(p.area) AS 'Smallest Size',
	MAX(p.area) AS 'Largest Size'
FROM
	park p


-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.
SELECT
	c.state_abbreviation,
	COUNT(1) AS 'Number of Cities'
FROM
	city c
GROUP BY
	c.state_abbreviation
ORDER BY
	COUNT(1) DESC

-- Determine the average park area depending upon whether parks allow camping or not.
SELECT
	p.has_camping,
	AVG(p.area) AS 'Average Area'
FROM
	park p
GROUP BY
	p.has_camping

-- Sum of the population of cities in each state ordered by state abbreviation.
SELECT
	SUM(c.population) AS 'Total Population',
	c.state_abbreviation
FROM
	city c
GROUP BY
	c.state_abbreviation
ORDER BY
	c.state_abbreviation

-- The smallest city population in each state ordered by city population.
SELECT
	c.state_abbreviation,
	MIN(c.population) AS 'Smallest Population'
FROM
	city c
GROUP BY
	c.state_abbreviation
ORDER BY
	MIN(c.population) ASC


-- SUBQUERIES

-- Select the name and population of every state, but include the average population as a column for reference
SELECT
	s.state_name,
	s.population,
	-- Can't do this! AVG(s.population) AS 'Average Population'
	(SELECT AVG(s2.population) FROM state s2) AS 'Average Population'
FROM
	state s

-- Select the name, state, and population of every city, and include the maximum and minimum populations for cities in that state
SELECT
	c.city_name,
	c.state_abbreviation,
	c.population,
	(SELECT MAX(c2.population) FROM city c2 WHERE c2.state_abbreviation = c.state_abbreviation) AS 'State Maximum',
	(SELECT MIN(c2.population) FROM city c2 WHERE c2.state_abbreviation = c.state_abbreviation) AS 'State Minimum'
FROM
	city c
ORDER BY
	c.state_abbreviation
