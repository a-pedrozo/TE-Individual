-- 15. The name, state abbreviation, and population for cities that end with the word "City" (11 rows)
SELECT
	c.city_name,
	c.state_abbreviation,
	c.population
FROM
	city c
WHERE
	c.city_name LIKE '%City'
