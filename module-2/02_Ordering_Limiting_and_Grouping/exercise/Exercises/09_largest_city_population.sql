-- 9. The population of the city with the highest population. Name the column 'largest_city_population'.
-- Expected answer is around 8,300,000
-- (1 row)

SELECT TOP 1
	MAX(c.population) AS 'largest_city_population'
	
FROM 
	city c
GROUP BY
	c.city_name

ORDER BY
		MAX(c.population) DESC

