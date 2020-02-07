-- DQL

USE Gufi_Tarde;
GO

SELECT * FROM TipoUsuario
SELECT * FROM TipoEvento
SELECT * FROM Usuario
SELECT * FROM Instituicao
SELECT * FROM Evento
SELECT * FROM Presenca
--1
SELECT NomeUsuario, Email, TipoUsuario.TituloTipoUsuario, Genero, DataNascimento, Genero
FROM Usuario
INNER JOIN TipoUsuario
ON TipoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario

--2
SELECT CNPJ, NomeFantasia, Endereco
FROM Instituicao

--3
SELECT TituloTipoEvento 
FROM TipoEvento

--4
SELECT NomeEvento, TipoEvento.TituloTipoEvento, DataEvento, 
CASE WHEN AcessoLivre = 1 THEN 'Publico' ELSE 'Privado' END AS TipoAcesso, Descricao, 
Instituicao.NomeFantasia, Instituicao.CNPJ, Instituicao.Endereco
FROM Evento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao

--5
SELECT NomeEvento, TipoEvento.TituloTipoEvento, DataEvento, 
CASE WHEN AcessoLivre = 1 THEN 'Publico' ELSE 'Privado' END AS TipoAcesso, Descricao, 
Instituicao.NomeFantasia, Instituicao.CNPJ, Instituicao.Endereco
FROM Evento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao
WHERE AcessoLivre = 1

--6 / 8
SELECT NomeEvento, TipoEvento.TituloTipoEvento, DataEvento, 
CASE WHEN AcessoLivre = 1 THEN 'Publico' ELSE 'Privado' END AS TipoAcesso, Descricao, 
Instituicao.NomeFantasia, Instituicao.CNPJ, Instituicao.Endereco,
Usuario.NomeUsuario, Usuario.Email, Usuario.Genero, Usuario.DataNascimento

FROM Evento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Evento.IdTipoEvento
INNER JOIN Instituicao ON Instituicao.IdInstituicao = Evento.IdInstituicao
INNER JOIN Presenca ON Evento.IdEvento = Presenca.IdEvento
INNER JOIN Usuario ON Usuario.IdUsuario = Presenca.IdUsuario

WHERE Usuario.IdUsuario = 2 
AND Situacao = 'Confirmada'

--7





















