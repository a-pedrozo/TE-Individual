-- 14. The state name, nickname, and census region for states that start with the word "New" (4 rows)
SELECT
	s.state_name,
	s.state_nickname,
	s.census_region
FROM
	state s
WHERE
	s.state_name LIKE 'New%'
