/*
Query the list of CITY names from STATION that do not end with vowels. 
Your result cannot contain duplicates.

works with MS SQL SERVER
*/

SELECT  DISTINCT CITY 
FROM    STATION 
WHERE   LOWER(RIGHT(CITY, 1)) NOT IN ('a','e','i','u','o')