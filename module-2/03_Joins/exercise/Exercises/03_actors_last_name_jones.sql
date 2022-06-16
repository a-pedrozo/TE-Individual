-- 3. For all actors with the last name of "Jones", display the actor's name and movie titles they appeared in. Order the results by the actor names (A-Z). (48 rows)
SELECT
	p.person_name,
	m.title
	
FROM 
	person p 
	INNER JOIN movie_actor ma ON p.person_id = ma.actor_id
	INNER JOIN movie m ON ma.movie_id = m.movie_id
WHERE
	p.person_name LIKE ('% Jones')

