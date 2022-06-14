-- 15. The name and date established of the newest national park.
-- (1 row)

SELECT TOP 1 
	p.park_name,
	p.date_established
FROM	
	park p
ORDER BY
	p.date_established DESC
