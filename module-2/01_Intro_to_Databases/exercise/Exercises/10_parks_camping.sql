-- 10. The name and area of parks that have an area less than or equal to 700 square kilometers and provides camping (21 rows)
SELECT
	p.park_name,
	p.area,
	p.has_camping

FROM
	park p 
WHERE
	p.area <= 700
	AND p.has_camping = 'True'
