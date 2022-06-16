-- 21. For every person in the person table with the first name of "George", list the number of movies they've been in--include all Georges, even those that have not appeared in any movies. Display the names in alphabetical order. (59 rows)
-- Name the count column 'num_of_movies'
SELECT 
	p.person_name,
	COUNT(1) AS 'num_of_movies'
FROM	
	person p 
	INNER JOIN movie_actor ma ON p.person_id = ma.actor_id
	INNER JOIN movie m ON ma.movie_id = m.movie_id
WHERE
	p.person_name LIKE ('George %')
		
GROUP BY 
	p.person_name
ORDER BY 
	COUNT(*) DESC,
	p.person_name 

--SELECT p.person_name, COUNT(1) AS 'Number with Name' FROM person p 
--WHERE p.person_name like 'George %' GROUP BY p.person_name ORDER BY COUNT(*) DESC
