```
SELECT rating, COUNT(*) FROM film
GROUP BY rating
ORDER BY rating;


SELECT replacement_cost, COUNT(*) FROM film
GROUP BY replacement_cost
HAVING (COUNT(replacement_cost) > 50)


SELECT store_id, COUNT(*) FROM customer
GROUP BY store_id;


SELECT country_id, COUNT(*) FROM city
GROUP BY country_id
ORDER BY COUNT(*) DESC
LIMIT 1;
```
