-- 17. The name, population, and area of all records in the state table with no census region (NULL) and area less than 5000 square kilometers (3 rows)
SELECT
	s.state_name,
	s.population,
	s.area
FROM
	state s
WHERE
	s.census_region IS NULL
	AND s.area < 5000
