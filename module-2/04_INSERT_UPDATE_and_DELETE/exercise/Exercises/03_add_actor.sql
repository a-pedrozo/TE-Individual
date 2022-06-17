-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)
BEGIN TRANSACTION 
INSERT INTO person (person_id, person_name)
Values ((SELECT actor_id FROM movie_actor  WHERE actor_id = movie_id), 'Eric Stoltz')
SELECT * FROM movie WHERE title = 'Back to the Future'

ROLLBACK TRANSACTION 

