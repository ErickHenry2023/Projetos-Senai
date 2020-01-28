CREATE DATABASE Optus_Tarde;		--Estilos Musicais		

USE Optus_Tarde; 

CREATE TABLE EstilosMusicas (
		IdEstilosMusicas	INT PRIMARY KEY IDENTITY,
		Nome	VARCHAR(200) NOT NULL
);

CREATE TABLE Artistas (
	IdArtista INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200) NOT NULL,
	IdEstilosMusicas INT FOREIGN KEY REFERENCES EstilosMusicas(IdEstilosMusicas)
	);

	SELECT * FROM EstilosMusicas;
	SELECT * FROM Artistas;