/*
Query the list of CITY names from STATION which have vowels (i.e., a, e, i, o, and u) as both their first and last characters. 
Your result cannot contain duplicates.

works with MS SQL SERVER
*/

SELECT  CITY 
FROM    STATION 
WHERE   LOWER(RIGHT(CITY, 1)) IN ('a','e','i','o','u' )
AND     LOWER(SUBSTRING(CITY, 1, 1)) IN ('a','e','i','o','u')