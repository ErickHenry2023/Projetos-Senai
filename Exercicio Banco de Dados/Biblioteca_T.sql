--CRIAR BANCO DE DADOS--
CREATE DATABASE Biblioteca_Tarde;  --Executar primeiro o CREATE DATABASE--

USE Biblioteca_Tarde;		--Seleciono o Banco que quero utilizar--

--Criar Tabeleas (Entidade = Tabela)--

CREATE TABLE Autores (
	IdAutor		INT PRIMARY KEY IDENTITY,
	NomeAutor	VARCHAR(200) NOT NULL
);

CREATE TABLE Generos (
	IdGenero	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(200) 
);

CREATE TABLE Livros (
	IdLivro		INT PRIMARY KEY IDENTITY,
	Titulo		VARCHAR(255),
	IdAutor		INT FOREIGN KEY REFERENCES Autores (IdAutor), --Colocar as FK por ultimos--
	IdGenero	INT FOREIGN KEY REFERENCES Generos (IdGenero)
);
-------------------------EXERCICIO-------------------------
INSERT INTO Autores(NomeAutor)
		VALUES('Bram Stoker'),('Dale Carnegie'),('E. L. James'), ('Augusto dos Anjos')

	INSERT INTO Generos(Nome)
		VALUES('Poesia') , ('Fábula')

	INSERT INTO Livros(Titulo,IdAutor,IdGenero)
		VALUES('Drácula','2','1'),
		('Como Fazer Amigos e Influenciar Pessoas','1','2'),
		('Cinquenta Tons de Cinza','3','3'),
		('Eu','5','4'),
		('O Pote Vazio','4','5');

	UPDATE Livros SET Nome='Livro 1', DataLançamento='11/11/2011' WHERE IdAutor=2





-------------------------EXERCICIO-------------------------
--Atributo = Coluna--

SELECT * FROM Generos;
SELECT * FROM Autores;
SELECT * FROM Livros;


--ALTERAR ADICIONAR UMA NOVA COLUNA
ALTER TABLE Generos
ADD Descricao VARCHAR(255);

--ALTERAR "TIPO" DE DADO
ALTER TABLE Generos
ALTER COLUMN Descricao CHAR(100);

--ALTERAR EXLUIR COLUNA--
ALTER TABLE Generos
DROP COLUMN Descricao;

--Excluir
DROP TABLE Livros;

--Excluir BANCO DE DADOS
DROP DATABASE Biblioteca_Tarde;


-----------