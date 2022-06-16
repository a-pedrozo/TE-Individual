-- 8. The genres of movies that Robert De Niro has appeared in that were released in 2010 or later (6 rows)

SELECT
	g.genre_name,
	m.release_date
FROM 
	person p
	INNER JOIN movie_actor ma ON p.person_id = ma.movie_id
	INNER JOIN movie m ON ma.movie_id = m.movie_id
	INNER JOIN movie_genre mg ON m.movie_id = mg.movie_id
	INNER JOIN genre g ON mg.genre_id = g.genre_id
WHERE
	p.person_name = 'Robert De Niro'
	AND m.release_date >= '01-01-2010'
	

