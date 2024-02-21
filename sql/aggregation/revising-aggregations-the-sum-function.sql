/*
Query the total population of all cities in CITY where District is California.

works with MS SQL
*/

SELECT SUM(POPULATION) FROM CITY WHERE DISTRICT like 'California'