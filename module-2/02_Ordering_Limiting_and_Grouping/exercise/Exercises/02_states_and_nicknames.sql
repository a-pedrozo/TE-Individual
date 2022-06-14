-- 2. The name and nickname of all states and territories that have a nickname (not NULL).
-- The name and nickname should be returned as a single column named 'state_and_nickname' and should contain values such as "New Jersey (Garden State)".
-- Order the results alphabetically by nickname.
-- (51 rows)

SELECT 
	s.state_name + '(' + s.state_nickname + ')' AS 'state_and_nickname'
FROM
	state s
 WHERE
	s.state_nickname IS NOT NULL
ORDER BY 
	s.state_nickname


