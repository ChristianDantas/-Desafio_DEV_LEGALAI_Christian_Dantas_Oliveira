--Create database Desafio_Legal
GO

USE Desafio_Legal
GO
--Tabela de usuario
Create Table Usuario(
		idUsuario INT PRIMARY KEY IDENTITY
		,nomeUsuario VARCHAR(255) NOT NULL
		,Senha VARCHAR(255) NOT NULL
		,areaInteresse VARCHAR(255)
		,Localização VARCHAR(255) NOT NULL
)
GO
--Tabela de Questionario
Create Table Questionario(
		idQuestionario INT PRIMARY KEY IDENTITY
		,idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario)
		,nomeQuestionario VARCHAR(255)
)
GO
--Tabela de Respostas
Create Table Respostas(
		idResposta INT PRIMARY KEY IDENTITY 
		,idQuestionario INT FOREIGN KEY REFERENCES Questionario(idQuestionario)
		,Questao VARCHAR(255)
		,Resposta1 VARCHAR(255)
		,Resposta2 VARCHAR(255)
		,Resultado BIT
)
GO

