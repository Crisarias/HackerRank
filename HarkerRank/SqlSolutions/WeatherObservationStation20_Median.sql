/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT CASE WHEN COUNT(0)%2=0 THEN (SELECT CAST(ROUND(S.LAT_N,4) AS DECIMAL(28,4)) FROM STATION S WHERE ((SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N > LAT_N) + 1) = (SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N < LAT_N) OR (SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N > LAT_N) = ((SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N < LAT_N) + 1)) ELSE (SELECT CAST(ROUND(S.LAT_N,4) AS DECIMAL(28,4)) FROM STATION S WHERE (SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N > LAT_N) = (SELECT COUNT(LAT_N) FROM STATION WHERE S.LAT_N < LAT_N))  END FROM STATION;




