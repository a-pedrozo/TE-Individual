-- 17. The titles and taglines of movies that are in the "Family" genre and Samuel L. Jackson has acted in (4 rows)

SELECT
	m.title,
	m.tagline
FROM
	movie m 
		INNER JOIN movie_actor ma ON m.movie_id = ma.movie_id
		INNER JOIN person p ON ma.actor_id = p.person_id
		INNER JOIN movie_genre mg ON m.movie_id = mg.movie_id
		INNER JOIN genre g ON mg.genre_id = g.genre_id
WHERE	
	p.person_name = 'Samuel L. Jackson'
	AND g.genre_name = 'Family'
