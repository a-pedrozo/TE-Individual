-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)
--BEGIN TRANSACTION 
INSERT INTO genre(genre_name)
VALUES ('Sports')

SELECT * FROM genre
--ROLLBACK TRANSACTION

BEGIN TRANSACTION 
UPDATE movie 
SET movie_id = 11775
WHERE 
	title = 'Coach Carter'

SELECT * FROM movie WHERE movie_id = 11775
ROLLBACK TRANSACTION
