CREATE DATABASE Optus_T;

USE Optus_T;

--( DDL criaracao de tabelas)

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

ALTER TABLE Albuns  
ADD Localizacao  VARCHAR(100);


-- DML LINGUAGEM DE MANIPULACAO DE DADOS
SELECT * FROM Estilos; 
SELECT * FROM Artistas; 
SELECT * FROM Albuns; 
SELECT * FROM TipoUsuario; 
SELECT * FROM Usuarios; 

-- Comando de inserir dados
	--(DML COLOCAR DADOS)--

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


----------------------------

--DQL LINGUEANGEM DE CONSULTA DE DODOS

SELECT * FROM Artistas;		--P/ CONSULTA--

SELECT NOME FROM Artistas;	--P/ CONSULTA SÓ DE ATRIBUTO--

SELECT Nome, DataLancamento FROM Albuns;	--CONSULTAR ESPECIFICA-- 

-- Operadores < > =
SELECT * FROM Albuns WHERE IdAlbum = 1;			--COMPARACAO 

SELECT * FROM Albuns WHERE IdAlbum >1;


-- OR OU 

SELECT Nome, QtdMinutos FROM Albuns
WHERE (DataLancamento IS NULL) or (Localizacao IS NULL);

SELECT IdAlbum, Nome FROM Albuns
WHERE Nome LIKE 'Pitty%' -- comeco da frase

SELECT IdAlbum, Nome FROM Albuns
WHERE Nome LIKE '%Pitty' -- frase final

SELECT IdAlbum, Nome FROM Albuns
WHERE Nome LIKE '%Pitty%' -- no meio da frase

-- ORDENACAO
SELECT Nome  FROM Albuns 
ORDER BY Nome;

-- ORDENAR DO MAIR P/ MENOR
SELECT IdAlbum, Nome, QtdMinutos FROM Albuns
ORDER BY QtdMinutos; ---ORDENA A PARTIR DAQUI	--(OU ORDER BY QtdMinutos DESC )

SELECT IdAlbum, Nome, QtdMinutos, DataLancamento FROM Albuns
ORDER BY DataLancamento ASC;

-- COUNT 
SELECT COUNT(IdAlbum) FROM Albuns;		--QUANTAS LINHAS TEM NA TABELA


---------------------------------------------------------------------
SELECT * FROM Albuns WHERE IdArtista = 5;

SELECT Nome, DataLancamento FROM Albuns
WHERE DataLancamento = '2020/01/29';

---SELECT * FROM Albuns WHERE DataLancamento = '2020/01/29'---

SELECT Nome, IdArtista FROM Albuns 
WHERE IdEstilo = 2;

--SELECT * FROM Albuns ORDER BY DataLancamento ASC;

SELECT Nome, IdArtista, DataLancamento  FROM Albuns 
ORDER BY DataLancamento DESC;

--------COM INNER JOIN (JuNCAO DE DUAS OU MAIS TABELAS)--------
SELECT Artistas.Nome, Albuns.Nome FROM Artistas
INNER JOIN Albuns ON Artistas.IdArtista = Albuns.IdArtista
WHERE Albuns.IdArtista = 2;

SELECT * FROM  Artistas 
INNER JOIN Albuns ON Artistas.IdArtista = Albuns.IdArtista
WHERE DataLancamento = '2020/01/29'

SELECT Artistas.Nome as NomeArtista, Albuns.Nome as NomeAlbuns, Albuns.DataLancamento -- (Atribustos c/ apelido)
FROM Artistas 
INNER JOIN Albuns ON Artistas.IdArtista = Albuns.IdArtista
ORDER BY DataLancamento ASC;


SELECT Artistas.Nome as NomeArtista, Albuns.Nome as NomeAlbuns, Albuns.DataLancamento -- (Atribustos c/ apelido)
FROM Artistas 
INNER JOIN Albuns ON Artistas.IdArtista = Albuns.IdArtista
ORDER BY DataLancamento ASC;
--------COM INNER JOIN (JuNCAO DE DUAS OU MAIS TABELAS)--------
				
							--DESAFIO COM INNER JOIN, COM 3 TABELAS--
SELECT Artistas.Nome, Estilos.Nome		--ATRIBUTOS
FROM Artistas							--FUNCAO
INNER JOIN Albuns ON Artistas.IdArtista = Albuns.IdArtista		--PONTE
INNER JOIN Estilos ON Albuns.IdEstilo = Estilos.IdEstilo		--PONTE
WHERE Estilos.IdEstilo = 2;













	




























