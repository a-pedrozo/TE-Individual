-- 12. Create a "Bill Murray Collection" in the collection table. For the movies that have Bill Murray in them, set their collection ID to the "Bill Murray Collection". (1 row, 6 rows)

select movie_id, person_id
from movie_actor
inner join person on person_id = actor_id
where person_name = 'Bill Murray'

select *
from movie
where movie_id in (137,10315,10433,120467,399174,83666)

