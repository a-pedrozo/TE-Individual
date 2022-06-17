-- 12. Create a "Bill Murray Collection" in the collection table. For the movies that have Bill Murray in them, set their collection ID to the "Bill Murray Collection". (1 row, 6 rows)

select movie_id, person_id
from movie_actor
inner join person on person_id = actor_id
where person_name = 'Bill Murray'

select *
from movie
where movie_id in (137,10315,10433,120467,399174,83666)

BEGIN TRANSACTION 
DELETE FROM collection WHERE collection_id = 895487

ROLLBACK TRANSACTION 

--BEGIN TRANSACTION 
INSERT INTO collection (collection_name)
VALUES ('Bill Murray Collection')
SELECT * FROM collection WHERE collection_name = 'Bill Murray Collection'
--895485
--ROLLBACK TRANSACTION 

--BEGIN TRANSACTION 
UPDATE movie
SET collection_id = 895487
WHERE movie_id = 137


UPDATE movie
SET collection_id = 895487
WHERE movie_id = 10433

UPDATE movie
SET collection_id = 895487
WHERE movie_id = 120467

UPDATE movie
SET collection_id = 895487
WHERE movie_id = 399174
UPDATE movie
SET collection_id = 895487
WHERE movie_id = 83666


UPDATE movie
SET collection_id = 895487
WHERE movie_id = 10315
--SELECT * FROM movie WHERE collection_id = 895487

--ROLLBACK TRANSACTION

BEGIN TRANSACTION 

UPDATE movie 
SET 
collection_id = (SELECT collection_id FROM collection WHERE collection_name = 'Bill Murray Collection')
WHERE 
	movie_id IN (SELECT 
	m.movie_id
FROM 
movie m 
INNER JOIN movie_actor ma ON ma.movie_id = m.movie_id
INNER JOIN person p ON p.person_id = ma.actor_id
WHERE 
	p.person_name = 'Bill Murray')

ROLLBACK TRANSACTION 
