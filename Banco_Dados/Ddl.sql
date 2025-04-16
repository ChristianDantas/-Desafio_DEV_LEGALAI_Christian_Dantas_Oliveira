--Create database Desafio_Legal

USE Desafio_Legal
GO

Create Table Usuario(
		idUsuario INT PRIMARY KEY IDENTITY
		,nomeUsuario VARCHAR(255) NOT NULL
		,Senha VARCHAR(255) NOT NULL
		,areaInteresse VARCHAR(255)
		,Localização VARCHAR(255) NOT NULL
)
GO

Create Table Questionario(
		idQuestionario INT PRIMARY KEY IDENTITY
		,idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario)
		,nomeQuestionario VARCHAR(255)
)
GO

Create Table Respostas(
		idResposta INT PRIMARY KEY IDENTITY
		,idQuestionario INT FOREIGN KEY REFERENCES Questionario(idQuestionario)
		,Resposta1 VARCHAR(255)
		,Resposta2 VARCHAR(255)
		,Resultado BIT
)
GO

