-- 10. The names of directors who have directed a movie over 3 hours [180 minutes] (15 rows)
SELECT DISTINCT
	p.person_name
FROM 
	movie m 
	INNER JOIN person p ON m.director_id = p.person_id
WHERE
	m.length_minutes >180
