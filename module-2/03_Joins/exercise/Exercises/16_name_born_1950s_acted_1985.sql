-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985 (20 rows)
SELECT
	p.person_name,
	p.birthday
FROM 
	person p 
	INNER JOIN movie_actor ma ON p.person_id = actor_id
	INNER JOIN movie m ON ma.movie_id = m.movie_id
WHERE
	p.birthday IN ('1950')
	AND m.release_date IN ('1985')
