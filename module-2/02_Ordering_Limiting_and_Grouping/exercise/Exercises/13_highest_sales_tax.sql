-- 13. The state (or territory) name and sales tax for the top five highest sales of tax of all states and territories. 
-- Order the results by sales tax with the highest number first, then by state name alphabetically.
-- (5 rows)

SELECT TOP 5
	s.state_name,
	s.sales_tax
FROM	
	state s
GROUP BY 
	s.sales_tax,
	s.state_name
ORDER BY 
	s.sales_tax DESC,
	s.state_name
