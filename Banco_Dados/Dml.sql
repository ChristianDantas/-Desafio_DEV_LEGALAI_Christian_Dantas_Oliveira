USE Desafio_Legal
GO
--Inserindo dados de Interesse
INSERT INTO Interesse(nomeInteresse)
VALUES				('Tecnologia')

INSERT INTO Interesse(nomeInteresse)
VALUES				('Jogos')

--Inserindo dados de Usuario
INSERT INTO Usuario(idInteresse, nomeUsuario,Localizacao)
VALUES				(1,'Christian', 'São Paulo'),
					(2,'Gustavo', 'Bahia')

--Inserindo dados de Empresa
INSERT INTO Empresas(idInteresse, nomeEmpresa,Localizacao)
VALUES				(1,'Legal', 'São Paulo'),
					(2,'AWS', 'Bahia')
