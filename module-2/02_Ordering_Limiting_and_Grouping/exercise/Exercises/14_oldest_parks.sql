-- 14. The name and date established of the top 10 oldest national parks.
-- Order the results with the oldest park first.
-- (10 rows)

SELECT TOP 10
	p.park_name,
	p.date_established
FROM	
	park p
ORDER BY 
	p.date_established
