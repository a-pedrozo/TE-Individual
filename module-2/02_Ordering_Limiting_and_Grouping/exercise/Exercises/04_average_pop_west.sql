-- 4. The average population of states in the "West" census region. Name the column 'average_population'.
-- Expected answer is around 6,000,000
-- (1 row)

SELECT 
	AVG(s.population) AS 'average_population'
FROM 
	state s
WHERE 
	s.census_region IN ('West')
