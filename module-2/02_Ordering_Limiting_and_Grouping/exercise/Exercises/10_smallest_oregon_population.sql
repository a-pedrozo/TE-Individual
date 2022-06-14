-- 10. The population of the city with the smallest population in Oregon (OR). Name the column 'smallest_oregon_population'.
-- Expected answer is around 100,000
-- (1 row)
SELECT TOP 1
	c.city_name,
	(c.population) AS 'smallest_oregon_population'
FROM
	city c
WHERE
	c.state_abbreviation IN ('OR')
ORDER BY 
	c.population

	
