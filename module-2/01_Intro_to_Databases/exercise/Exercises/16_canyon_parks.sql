-- 16. The name, date established, and area of parks that contain the string "Canyon" anywhere in the name (5 rows)
SELECT
	p.park_name,
	p.date_established
	
FROM
	park p 
WHERE
	p.park_name LIKE '%Canyon%'
