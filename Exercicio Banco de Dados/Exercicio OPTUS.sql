CREATE DATABASE Optus_T;

USE Optus_T;

CREATE TABLE Estilos (
	IdEstilo INT PRIMARY KEY IDENTITY,
	Nome	VARCHAR(250) NOT NULL
);

CREATE TABLE Artistas (
	IdArtista INT PRIMARY KEY IDENTITY,
	Nome	VARCHAR(250) NOT NULL
);

CREATE TABLE Albuns (
	IdAlbum INT PRIMARY KEY IDENTITY,
	Nome	VARCHAR(200) NOT NULL, 
	DataLancamento	DATE,
	QtdMinutos BIGINT, 
	Visualizacao INT, 
	IdArtista	INT FOREIGN KEY REFERENCES Artistas(IdArtista),
	IdEstilo	INT FOREIGN KEY REFERENCES Estilos(IdEstilo)
);

CREATE TABLE TipoUsuario (
	IdTipoUsuario	INT PRIMARY KEY IDENTITY,
	Titulo	VARCHAR(200) NOT NULL,
);

CREATE TABLE Usuarios (
	IdEstilo	INT PRIMARY KEY IDENTITY,
	NOME	VARCHAR(200) NOT NULL
);


-- DML LINGUAGEM DE MANIPULACAO DE DADOS
SELECT * FROM Estilos; 
SELECT * FROM Artistas; 
SELECT * FROM Albuns; 
SELECT * FROM TipoUsuario; 
SELECT * FROM Usuarios; 

-- Comando de inserir dados
INSERT INTO Estilos (Nome)
VALUES ('Pagode'),('Samba'),('Rock');

INSERT INTO Artistas (Nome)
VALUES ('Anita'),('Zeca Pagodinho'),('Pitty');

INSERT INTO Albuns (Nome, DataLancamento, IdArtista)
VALUES ('Equilize', '29/01/2020', 'SP', );



-- Update ALTERAR Dados

UPDATE Artistas
SET Nome = 'ZECA'
WHERE IdArtista = 2;

-- DELETAR PAGAR DODOS
DELETE FROM Artistas
WHERE IdArtista = 5;

--LIMPAR TODOS OS DADOS DA TABELA
TRUNCATE TABLE Artistas;



--------EXERCICIO-------
INSERT INTO Estilos (Nome)
VALUES ('Gospel'), ('Electronica');

INSERT INTO Artistas (Nome)
VALUES ('Fernandinho'), ('Aline Barros');

INSERT INTO TipoUsuario (Titulo)
VALUES ('Usuario'), ('Adm');

INSERT INTO Usuarios (NOME)
VALUES ('Jose'),('Maria');

INSERT INTO Albuns (Nome, DataLancamento, QtdMinutos, Visualizacao, IdArtista,  IdEstilo)
VALUES ('Anita', '29/01/2020', 120, '2000', 2, 1);

INSERT INTO Albuns (Nome, DataLancamento, QtdMinutos, Visualizacao, IdArtista,  IdEstilo)
VALUES ('Mais Feliz', '29/01/1990', 90, '1500', 2, 2);

INSERT INTO Albuns (Nome, DataLancamento, QtdMinutos, Visualizacao, IdArtista,  IdEstilo)
VALUES ('Matriz', '29/01/2019', 180, '1000', 3, 3);

INSERT INTO Albuns (Nome, DataLancamento, QtdMinutos, Visualizacao, IdArtista,  IdEstilo)
VALUES ('Tempo', '29/01/2019', 180, '1000', 5, 4);

DELETE FROM Albuns
WHERE IdAlbum = 3;



UPDATE Artistas
SET Nome = 'Claudinho e Buchecha - Ao Vivo'
WHERE IdArtista = 1;











