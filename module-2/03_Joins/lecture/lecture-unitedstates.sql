-- INNER JOIN

-- Write a query to retrieve the name and state abbreviation for the 2 cities named "Columbus" in the database


-- Modify the previous query to retrieve the names of the states (rather than their abbreviations).


-- Write a query to retrieve the names of all the national parks with their state abbreviations.
-- (Some parks will appear more than once in the results, because they cross state boundaries.)
SELECT
	p.park_name,
	ps.state_abbreviation
FROM	
	park p
	INNER JOIN park_state ps ON ps.park_id = p.park_id

-- The park_state table is an associative table that can be used to connect the park and state tables.
-- Modify the previous query to retrieve the names of the states rather than their abbreviations.
SELECT
	p.park_name,
	s.state_abbreviation,
	s.state_name
FROM	
	park p
	INNER JOIN park_state ps ON ps.park_id = p.park_id -- linking tables to each other 
	INNER JOIN state s ON s.state_abbreviation = ps.state_abbreviation 

-- Modify the previous query to include the name of the state's capital city.
SELECT
	p.park_name,
	s.state_abbreviation,
	s.state_name,
	c.city_name AS 'Capital City'
FROM	
	park p
	INNER JOIN park_state ps ON ps.park_id = p.park_id -- linking tables to each other 
	INNER JOIN state s ON s.state_abbreviation = ps.state_abbreviation 
	INNER JOIN city c ON c.city_id = s.capital

-- Modify the previous query to include the area of each park.
SELECT
	p.park_name,
	s.state_abbreviation,
	s.state_name,
	c.city_name AS 'Capital City',
	p.area
FROM	
	park p
	INNER JOIN park_state ps ON ps.park_id = p.park_id -- linking tables to each other 
	INNER JOIN state s ON s.state_abbreviation = ps.state_abbreviation 
	INNER JOIN city c ON c.city_id = s.capital

-- Write a query to retrieve the names and populations of all the cities in the Midwest census region.
SELECT
	c.city_name,
	c.population,
	s.census_region
FROM
	city c
	INNER JOIN state s ON s.state_abbreviation = c.state_abbreviation
	--INNER JOIN state s ON s.capital = c.city_id will fliter down to just capital cities 
WHERE 
	s.census_region = 'Midwest'

-- Write a query to retrieve the number of cities in the city table for each state in the Midwest census region.
SELECT 
	s.state_name,
	COUNT(*) AS 'Num Cities' -- will retrive one row with total of number of rows 
FROM 
	city c
	INNER JOIN state s ON s.state_abbreviation = c.state_abbreviation

WHERE
	s.census_region = 'Midwest'
GROUP BY 
	s.state_name
ORDER BY 
	'Num Cities' DESC,
	s.state_name

-- Modify the previous query to sort the results by the number of cities in descending order.



-- LEFT JOIN


-- Write a query to retrieve the state name and the earliest date a park was established in that state (or territory) 
SELECT 
	s.state_name,
	MIN(p.date_established) AS 'earliest park established'
FROM 
	park p 
	INNER JOIN park_state ps ON ps.park_id = p.park_id
	INNER JOIN state s ON s.state_abbreviation = ps.state_abbreviation

GROUP BY
		s.state_name
--for every record in the state table that has park records associated with it. left outer joining by capital 
SELECT
	c.city_name,
	c.population,
	s.census_region,
	s.state_name AS 'City is Captital of this state'
FROM
	city c
	LEFT OUTER JOIN state s ON s.capital = c.city_id -- does not filter, but may result in NULL columns when there is no match
	


-- Modify the previous query so the results include entries for all the records in the state table, even if they have no park records associated with them.



SELECT 
	s.state_name,
	MIN(p.date_established) AS 'earliest park established'
FROM 
	state s
	LEFT OUTER JOIN park_state ps ON ps.state_abbreviation = s.state_abbreviation
	LEFT OUTER JOIN park p ON p.park_id = ps.park_id

GROUP BY
		s.state_name
	


-- UNION

-- Write a query to retrieve all the place names in the city and state tables that begin with "W" sorted alphabetically. (Washington is the name of a city and a state--how many times does it appear in the results?)
SELECT 
	c.city_name AS 'Name', -- header of column will be taken by first query
	'City' AS 'TYPE' -- will give column type either city or state
FROM
	city c
WHERE 
	c.city_name LIKE 'W%'
UNION
SELECT 
	s.state_name,
	'State'
FROM 
	state s 
WHERE 
	s.state_name LIKE 'W%'
ORDER BY
	'Name'

-- Modify the previous query to include a column that indicates whether the place is a city or state.

