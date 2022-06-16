-- 1. The titles and release dates of movies that Tom Hanks has appeared in (47 rows)
SELECT 
	m.title,
	m.release_date
	--p.person_name
FROM 
	movie m
	INNER JOIN movie_actor ma ON m.movie_id = ma.movie_id
    INNER JOIN person p ON ma.actor_id = p.person_id

WHERE
	p.person_name = 'Tom Hanks'





