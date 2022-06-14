-- 19. The census region and the number of records in the state table (name column 'num_states') for each census region. Exclude ones that don't have a census region.
-- Order the results from highest to lowest.
-- (Note: DC is in a census region, but the territories aren't, so the sum of the counts will equal 51).
-- (4 rows)

SELECT
	s.census_region,
	COUNT(1) AS 'num_states'
FROM
	state s
WHERE
	s.census_region IS NOT NULL
GROUP BY 
	s.census_region
	
ORDER BY 
	COUNT (1) DESC
