-- 6. The genres of "The Wizard of Oz" (3 rows)
SELECT 
	g.genre_name
	--m.title
FROM 
	movie m 
	INNER JOIN movie_genre mg ON m.movie_id = mg.movie_id
	INNER JOIN genre g ON mg.genre_id = g.genre_id
WHERE
	m.title = 'The Wizard of OZ'

