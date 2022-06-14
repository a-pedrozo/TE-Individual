-- 20. The state abbreviation, and population of the largest city (name column 'city_population') of all states, territories, and districts.
-- Order the results from highest to lowest populations.
-- (56 rows)

SELECT
	c.state_abbreviation,
	MAX(c.population) AS 'city_population'
FROM
	city c
GROUP BY
	c.state_abbreviation
ORDER BY
	MAX(c.population) DESC
