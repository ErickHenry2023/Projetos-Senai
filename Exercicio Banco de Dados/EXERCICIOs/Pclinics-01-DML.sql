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

INSERT INTO Dono (Nome)
VALUES ('Matheus Souza');

INSERT INTO TipoPet (Titulo)
VALUES ('Porquinho da india');

INSERT INTO Veterinario (Nome, CRMV, IdClinica)
VALUES ('Diogo', '202351-M', 1);

INSERT INTO Raca ( Titulo, IdTipoPet)
VALUES ('Cuy', 1);




