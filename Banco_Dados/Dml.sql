USE Desafio_Legal
GO
--Inserindo dados de usuario
INSERT INTO Usuario(nomeUsuario,Senha, areaInteresse, Localiza��o)
VALUES				('Christian','senha123','Inteligencia Artificial generico','S�o Paulo')

--Inserindo dados de questionario
INSERT INTO Questionario(idUsuario, nomeQuestionario)
VALUES				(1,'Inteligencia Artificial generica')

--Inserindo dados de Resposta
INSERT INTO Respostas(idQuestionario,Questao, Resposta1, Resposta2, Resultado)
VALUES				(1,'Voc� gosta de IA?', 'sim', 'n�o',NULL),
				(1,'Voc� Gosta de tecnologia?', 'sim','n�o',1)