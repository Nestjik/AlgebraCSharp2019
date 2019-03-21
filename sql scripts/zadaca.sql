USE Fakultet;

-- 3.2
SELECT imeNastavnik, prezNastavnik
FROM nastavnik;

-- 3.3
SELECT mbrStud, imeStud + prezStud as ImePrezime
FROM stud;

-- 3.4
SELECT DISTINCT imeStud
FROM stud
ORDER BY imeStud DESC;

-- 3.5
SELECT mbrStud
FROM ispit
WHERE sifPred=146 AND ocjena > 1;

-- 3.6
SELECT imeNastavnik, prezNastavnik, (koef+0.4)*800 as placa
FROM nastavnik;

-- 3.7
SELECT imeNastavnik, prezNastavnik, (koef+0.4)*800 as placa
FROM nastavnik
WHERE (koef+0.4)*800 < 3500 OR (koef+0.4)*800 > 8000
ORDER BY placa;

-- 3.8
SELECT *
FROM stud
WHERE imeStud LIKE '[aeiou]%[aeiou]  %';

-- 3.9
SELECT *
FROM stud
WHERE imeStud LIKE '[^aeiou]%[^ aeiou]  %';

-- 3.10
SELECT *
FROM stud
WHERE imeStud LIKE '[aeiou]%' OR imeStud LIKE '%[aeiou]  %';

-- 3.11
SELECT *
FROM stud
WHERE imeStud LIKE '%nk%' OR prezStud LIKE '%nk%';
