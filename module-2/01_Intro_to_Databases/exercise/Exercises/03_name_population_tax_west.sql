-- 3. The name, population, and sales tax of the states in the "West" census region (13 rows)
SELECT
	s.state_name,
	s.population,
	s.sales_tax
FROM
	state s
WHERE
	s.census_region = 'West'
