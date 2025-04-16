USE Desafio_Legal
GO
--Inserindo dados de usuario
INSERT INTO Usuario(nomeUsuario,Senha, areaInteresse, Localização)
VALUES				('Christian','senha123','Inteligencia Artificial generico','São Paulo')

--Inserindo dados de questionario
INSERT INTO Questionario(idUsuario, nomeQuestionario)
VALUES				(1,'Inteligencia Artificial generica')

--Inserindo dados de Resposta
INSERT INTO Respostas(idQuestionario,Questao, Resposta1, Resposta2, Resultado)
VALUES				(1,'Você gosta de IA?', 'sim', 'não',NULL),
				(1,'Você Gosta de tecnologia?', 'sim','não',1)