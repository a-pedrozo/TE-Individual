-- 2. The name and area of all cities in Pennsylvania (PA) (4 rows)
SELECT
	p.city_name
FROM
	city p
WHERE
	p.state_abbreviation = 'PA'
