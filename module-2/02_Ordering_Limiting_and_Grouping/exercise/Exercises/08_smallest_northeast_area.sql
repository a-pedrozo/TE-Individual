-- 8. The area of the smallest state in the "Northeast" census region. Name the column 'smallest_northeast_area'.
-- Expected answer is around 4,000
-- (1 row)

SELECT TOP 1
	MIN(s.area) AS 'smalleset_northeast_area'
	
FROM
	state s
WHERE 
	s.census_region IN ('Northeast')
GROUP BY
	s.area
ORDER BY MIN(s.area) ASC
