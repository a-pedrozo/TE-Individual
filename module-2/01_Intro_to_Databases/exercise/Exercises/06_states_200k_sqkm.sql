-- 6. The name, abbreviation, population, and area of states with an area greater than 200,000 square kilometers (16 rows)
SELECT
	s.state_name,
	s.state_abbreviation,
	s.population,
	s.area
FROM
	state s
WHERE
	s.area > 200000
