-- 3. The name, population, area, and population density (name the column 'population_density') of cities with more than 5,000 people per square kilometer.
-- Population density is expressed as people per square kilometer. In other words, population divided by area.
-- Order the results by population density, highest number first.
-- (9 rows)
SELECT
	c.city_name,
	c.population,
	c.area,
	c.population / c.area AS 'population_density'
FROM
	city c
WHERE	
	c.population / c.area > 5000

ORDER BY
	c.population / c.area DESC
