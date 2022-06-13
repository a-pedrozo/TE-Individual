-- 23. The name and date established of parks opened in the 1960s (6 rows)
SELECT
	p.park_name,
	p.date_established
FROM
	park p
WHERE
	p.date_established BETWEEN 01-01-1960 AND 12-31-1960
