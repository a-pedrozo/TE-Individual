-- ORDERING RESULTS

-- Populations of all states from smallest to largest.
	SELECT
		s.population,
		s.state_name
	FROM	
		state s
	ORDER BY
		s.population DESC	-- ASC is assending a-z  this is the default 
							--DESC is descending z-a and must be explicity stated

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT 
	s.state_name,
	s.census_region
FROM 
	state s
ORDER BY
	s.census_region DESC,	-- order first by census reigion 
	s.state_name			-- in the event of a tie, order by state name 
	
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
SELECT TOP 10		-- this limits the results to top 10 rows
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
	p.date_established,	-- organize first by date established 
	p.park_name					-- then organize by park name


-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.
SELECT
	c.city_name + ',' + c.state_abbreviation AS 'Mailing Address' -- this is how to concatenate two columns together converts to string
	
FROM
	city c


-- All park names and area
SELECT
	p.park_name + ' Area:' + FORMAT(p.area, 'N') 
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


-- Total population in the West and South census regions


-- The number of cities with populations greater than 1 million


-- The number of state nicknames.


-- The area of the smallest and largest parks.



-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.


-- Determine the average park area depending upon whether parks allow camping or not.


-- Sum of the population of cities in each state ordered by state abbreviation.


-- The smallest city population in each state ordered by city population.



-- SUBQUERIES

-- Select the name and population of every state, but include the average population as a column for reference

-- Select the name, state, and population of every city, and include the maximum and minimum populations for cities in that state
