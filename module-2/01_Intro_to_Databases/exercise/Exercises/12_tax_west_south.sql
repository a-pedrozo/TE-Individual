-- 12. The state name, nickname, and sales tax from records in the state table in the "West" and "South" census regions with a sales tax that isn't 0% (26 rows)
SELECT
	s.state_name,
	s.state_nickname,
	s.sales_tax
FROM
	state s
WHERE
	s.census_region IN ('West', 'South')
	AND s.sales_tax <> 0
