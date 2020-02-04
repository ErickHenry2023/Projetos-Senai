--DML

USE Pclinics;

SELECT * FROM Clinica; 
SELECT * FROM Dono; 
SELECT * FROM TipoPet; 
SELECT * FROM Veterinario; 
SELECT * FROM Raca; 
SELECT * FROM Pet; 
SELECT * FROM Atendimento; 

INSERT INTO Clinica (RazaoSocial, Endereco)
VALUES ('Pclinics', 'Alameda Barão de Limeira, 539');

INSERT INTO Veterinario (Nome, CRMV, IdClinica)
VALUES	('Diogo', '202351-M', 1),
		('Danilo', '202350-Y', 1),
		('Saulo', '204063-A', 1),
		('Carol', '202350-0', 1);

INSERT INTO Dono (Nome)	
VALUES ('Matheus Souza'),
	('Davi'),
	('Lucas Pandolfi'),
	('Erick');

INSERT INTO TipoPet (Titulo)
VALUES ('Porquinho da india')
		('Gato'),
		('Cachorro'),
		('Topolino ');

INSERT INTO Raca ( Titulo, IdTipoPet)
VALUES	('Cuy', 1),
		('Persa', 2),
		('Pug', 3),
		('Camundongo', 4);

INSERT INTO Pet (Nome, Telefone, IdDono, IdRaca)
VALUES ('Pulguento', '99123-3211', 2,2),
		('Sarnento', '99232-6423', 3,3),
		('Ratatouille ', '9977006-321', 4,4);

INSERT INTO Atendimento (Data_, Descricao, IdVet, IdPet)
VALUES ('03/02/2020','Tudo em ordem', 1, 1),
	('04/02/2020','Doença grave detectada', 7, 20),
	('05/02/2020','Vai morrer', 8, 21),
	('06/02/2020','Tem mais alguns dias de vida', 9, 22);









