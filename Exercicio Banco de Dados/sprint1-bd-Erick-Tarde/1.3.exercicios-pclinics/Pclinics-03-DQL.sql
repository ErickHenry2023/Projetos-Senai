--DQL

USE Pclinics;

SELECT * FROM Clinica; 
SELECT * FROM Dono; 
SELECT * FROM TipoPet; 
SELECT * FROM Veterinario; 
SELECT * FROM Raca; 
SELECT * FROM Pet; 
SELECT * FROM Atendimento;


SELECT Veterinario.Nome as Veterinario, Veterinario.CRMV, Dono.Nome as Dono, Pet.Nome as Pet, Raca.Titulo as Raca, TipoPet.Titulo as Tipo, Atendimento.Data_ as Data, Atendimento.Descricao
FROM Atendimento
INNER JOIN Veterinario
ON Veterinario.IdVet = Atendimento.IdVet
INNER JOIN Pet
ON Atendimento.IdPet = Atendimento.IdPet
INNER JOIN Raca
ON Pet.IdRaca = Raca.IdRaca
INNER JOIN TipoPet
ON TipoPet.IdTipoPet = Raca.IdTipoPet
INNER JOIN Dono
ON Dono.IdDono = Pet.IdDono