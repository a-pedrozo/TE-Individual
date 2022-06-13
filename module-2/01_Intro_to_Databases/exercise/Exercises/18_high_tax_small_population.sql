-- 18. The name, population, and sales tax of all records in the state table with a sales tax of at least 7% or have a population of less than 1,000,000 (17 rows)
SELECT
	s.state_name,
	s.population,
	s.sales_tax
FROM
	state s
WHERE
	s.sales_tax >= 7
	OR s.population < 1000000
