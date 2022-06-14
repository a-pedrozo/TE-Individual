-- 18. The count of the number of cities (name column 'num_cities') and the state abbreviation for each state and territory (exclude state abbreviation DC).
-- Order the results by state abbreviation.
-- (55 rows)
SELECT
	c.state_abbreviation,
	COUNT(1) AS 'num_cities'
FROM
	city c
WHERE 
	c.state_abbreviation <> 'DC'
GROUP BY
	c.state_abbreviation
ORDER BY
	c.state_abbreviation
	
