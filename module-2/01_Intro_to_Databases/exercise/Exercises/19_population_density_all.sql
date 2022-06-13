-- 19. The name, population, area, and population density (name the column 'population_density') of all states, territories, and districts (56 rows)
-- Population density is expressed as people per square kilometer. In other words, population divided by area.
SELECT
	s.state_name,
	s.population,
	s.area,
	s.population / s.area AS 'population_density'
	
FROM
	state s

	
	

