-- 8. The name and population of cities in California (CA) with a population less than 150,000 people (37 rows)
SELECT
	c.city_name,
	c.population
FROM
	city c
WHERE
	c.state_abbreviation = 'CA'
	AND c.population < 150000
