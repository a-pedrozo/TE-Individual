-- 15. The title of the movie and the name of director for movies where the director was also an actor in the same movie (73 rows)
SELECT 
	m.title,
	d.person_name
FROM 
	movie m 
	INNER JOIN movie_actor ma ON m.movie_id = ma.movie_id
	INNER JOIN person p ON ma.actor_id = p.person_id
	INNER JOIN person d ON m.director_id = d.person_id
WHERE
	p.person_name = d.person_name
