-- 21. The name and nickname for all records in the state table with no official nickname (NULL) or nickname starts with the word "The" (13 rows)
SELECT
	s.state_name,
	s.state_nickname
FROM
	state s
WHERE
	s.state_nickname IS NULL 
	OR s.state_nickname LIKE 'The%'
