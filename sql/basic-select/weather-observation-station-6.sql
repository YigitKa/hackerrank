/*
Query the list of CITY names starting with vowels (i.e., a, e, i, o, or u) from STATION. 
Your result cannot contain duplicates.

works with MS SQL SERVER
*/

SELECT  CITY 
FROM    STATION 
WHERE   SUBSTRING(CITY,1,1) IN ('A','E','I','O','U')