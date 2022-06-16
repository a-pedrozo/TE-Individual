-- 9. The titles of movies directed by James Cameron (6 rows)
SELECT 
	m.title,
	p.person_name
FROM	
	movie m
	INNER JOIN person p ON p.person_id = m.director_id

WHERE 
	p.person_name = 'James Cameron'
