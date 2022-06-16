-- 19. The genre name and the number of movies in each genre. Name the count column 'num_of_movies'. 
-- (19 rows, expected result for Action is around 180).

SELECT 
	g.genre_name,
	SUM(m.movie_id) AS 'num_of_movies'
FROM 
	movie m 
	INNER JOIN movie_genre mg ON m.movie_id = mg.movie_id
	INNER JOIN genre g ON mg.genre_id = g.genre_id
GROUP BY 
	g.genre_name
ORDER BY 
	g.genre_name
