-- film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?

SELECT COUNT(length) from film where length > (SELECT AVG(length) from film);

-- film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?

SELECT COUNT(rental_rate) from film where rental_rate = (SELECT MAX(rental_rate) from film);

-- film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.

select * from film
where (rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) from film));

-- payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.

select first_name, last_name, customer.customer_id, count from customer
INNER JOIN 
(select customer_id, COUNT(customer_id) from payment group by customer_id) AS TF 
ON customer.customer_id = TF.customer_id
ORDER BY count desc;
