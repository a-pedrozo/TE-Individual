-- 8. Remove "Penn Jillette" from the person table 
-- You'll have to remove data from another table before you can make him "disappear" (Get it? Because he's a magician...) (1 row each)

BEGIN TRANSACTION 
DELETE 
FROM 
DELETE 
FROM person 
WHERE person_name = 'Penn Jillette'
--SELECT * FROM person WHERE person_name = 'Penn Jillette'
ROLLBACK TRANSACTION 
