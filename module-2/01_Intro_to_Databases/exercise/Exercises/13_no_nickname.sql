-- 13. The name, abbreviation, and population of all records in the state table with no official nickname (NULL) (5 rows)
SELECT
	s.state_name,
	s.state_abbreviation,
	s.population
FROM
	state s
WHERE s.state_nickname IS NULL
