-- 12. Create a "Bill Murray Collection" in the collection table. For the movies that have Bill Murray in them, set their collection ID to the "Bill Murray Collection". (1 row, 6 rows)

--BEGIN TRANSACTION 

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

--ROLLBACK TRANSACTION 
