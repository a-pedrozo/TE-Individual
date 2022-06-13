-- 5. The name, state abbreviation, and population of cities with a population greater than 1,000,000 people (10 rows)

SELECT 
	c.city_name,
	c.population,
	c.state_abbreviation
FROM 
	city c
WHERE
	c.population > 1000000
