-- 4. The name, population, and nickname of the states in the "Northeast" census region (9 rows)
SELECT
	s.state_name,
	s.population,
	s.state_nickname

FROM
	state s
WHERE
	s.census_region = 'Northeast'
