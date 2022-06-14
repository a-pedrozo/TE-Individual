-- 21. The census region, and the average, minimum, and maximum population of states and districts in each census region. Exclude ones that don't have a census region.
-- Name the population columns 'average_population, 'min_population', and 'max_population'.
-- Order the results from lowest to highest average population.
-- (4 rows)

SELECT 
	s.census_region,
	
	
	
	state s
WHERE
	s.census_region IS NOT NULL
	
	
ORDER BY 
	AVG(s.population)
