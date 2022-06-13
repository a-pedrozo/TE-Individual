-- 11. The name, state, and population of all cities in Colorado (CO) or Arizona (AZ) (22 rows)
SELECT
	c.city_name,
	c.population,
	c.state_abbreviation
	
FROM
	city c
	
WHERE
	c.state_abbreviation IN ('CO', 'AZ')
