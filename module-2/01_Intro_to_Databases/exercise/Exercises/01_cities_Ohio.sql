-- 1. The name and population of all cities in Ohio (OH) (6 rows)
SELECT
	c.city_name,
	c.population
FROM
	city c
WHERE
	c.state_abbreviation = 'OH'
