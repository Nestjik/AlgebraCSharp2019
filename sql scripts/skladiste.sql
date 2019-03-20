-- USE master;
-- CREATE DATABASE skladiste;
USE skladiste;

CREATE TABLE voditelji (
	id INT IDENTITY(1,1),
	ime varchar(25) NOT NULL,
	prezime varchar(25) NOT NULL,
	PRIMARY KEY(id)
	);

CREATE TABLE radnici (
	id INT IDENTITY(1,1),
	voditelj_id INT NOT NULL,
	ime varchar(25) NOT NULL,
	prezime varchar(25) NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(voditelj_id) REFERENCES voditelji(id) ON DELETE CASCADE
	);

CREATE TABLE proizvodi (
	voditelj_id INT,
	proizvod varchar(25) NOT NULL,
	PRIMARY KEY(voditelj_id),
	FOREIGN KEY(voditelj_id) REFERENCES voditelji(id) ON DELETE CASCADE
	);

CREATE TABLE skladisno_mjesto (
	voditelj_id INT,
	mjesto varchar(25) NOT NULL,
	PRIMARY KEY(voditelj_id),
	FOREIGN KEY(voditelj_id) REFERENCES voditelji(id) ON DELETE CASCADE,
	CONSTRAINT chk_mjesto CHECK(mjesto='Zagreb' OR mjesto='Rijeka' OR mjesto='Sisak')
	);
