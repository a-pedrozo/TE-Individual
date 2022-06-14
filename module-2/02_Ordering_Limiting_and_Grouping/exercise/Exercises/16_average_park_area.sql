-- 16. The average area of national parks that have camping. Name the column 'average_park_area'.
-- Expected answer is around 3,900.
-- (1 row)

SELECT
	AVG(p.area) AS 'average_park_area'
FROM
	park p

WHERE
	p.has_camping IN ('1')
