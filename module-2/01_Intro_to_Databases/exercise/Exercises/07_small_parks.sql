-- 7. The name, date established, and area of parks with an area less than 100 square kilometers (6 rows)
SELECT
	p.park_name,
	p.date_established,
	p.area
FROM
	park p
WHERE
	p.area < 100
