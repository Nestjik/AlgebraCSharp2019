-- USE master;
-- CREATE DATABASE videoteka;
USE videoteka;

CREATE TABLE clanovi (
	id INT IDENTITY(1,1),
	ime varchar(25) NOT NULL,
	prezime varchar(25) NOT NULL,
	PRIMARY KEY(id)
	);

CREATE TABLE filmovi (
	id INT IDENTITY(1,1),
	ime_filma varchar(25) UNIQUE NOT NULL,
	cijena MONEY NOT NULL,
	PRIMARY KEY(id)
	);

CREATE TABLE posudba (
	id INT IDENTITY(1,1),
	clan_id INT,
	film_id INT,
	vrijeme_posudbe TIMESTAMP,
	vrijeme_vracanja DATETIME,
	PRIMARY KEY(id),
	FOREIGN KEY (clan_id) REFERENCES clanovi(id) ON DELETE CASCADE,
	FOREIGN KEY (film_id) REFERENCES filmovi(id) ON DELETE CASCADE
	);