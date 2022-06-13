-- 22. The name and sales tax for states and territories with sales tax greater than or equal to 2% and less than or equal to 5% (15 rows)
SELECT 
	s.state_name,
	s.sales_tax
FROM
	state s
WHERE
	s.sales_tax >= 2
	AND s.sales_tax <= 5
