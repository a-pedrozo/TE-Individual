-- 9. The name, abbreviation, population, and sales tax of all states and territories with a sales tax greater than 6.6% (9 rows)
SELECT
	s.state_name,
	s.state_abbreviation,
	s.population,
	s.sales_tax
FROM
	state s
WHERE
	s.sales_tax > 6.6
