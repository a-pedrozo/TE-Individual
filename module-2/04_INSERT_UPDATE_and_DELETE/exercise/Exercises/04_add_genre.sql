-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)
--BEGIN TRANSACTION 
INSERT INTO genre(genre_name)
VALUES ('Sports')

--SELECT * FROM movie WHERE movie_id = 7214
SELECT* FROM movie WHERE title = 'Coach Carter'
--ROLLBACK TRANSACTION

--BEGIN TRANSACTION 
INSERT INTO movie_genre (movie_id, genre_id)
VALUES (7214,11771)
--ROLLBACK TRANSACTION


