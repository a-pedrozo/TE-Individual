-- MovieDB
-- After running the script to set up the MovieDB database, make sure it is selected in SSMS and confirm it is working correctly by writing queries to retrieve...

-- The names of all the movie genres
SELECT g.genre_names * FROM genre g


-- The titles of all the Comedy movies (ID: 35)
SELECT 
	m.title
FROM 
	movie m
	INNER JOIN movie_genre mg ON mg.movie_id = m.movie_id
	INNER JOIN genre g ON g.genre_id = mg.genre_id
WHERE 
	g.genre_name = 'Comedy'
