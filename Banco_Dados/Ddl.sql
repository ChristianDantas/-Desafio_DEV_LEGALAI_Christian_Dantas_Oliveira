--Create database Desafio_Legal
GO

USE Desafio_Legal
GO

--Tabela de Interesse
Create table Interesse(
		idInteresse INT PRIMARY KEY IDENTITY
		,nomeInteresse VARCHAR(255) NOT NULL
)

--Tabela de usuario
Create Table Usuario(
		idUsuario INT PRIMARY KEY IDENTITY
		,idInteresse INT FOREIGN KEY REFERENCES Interesse(idInteresse)
		,nomeUsuario VARCHAR(255) NOT NULL
		,Localizacao VARCHAR(255) NOT NULL
)
GO

--Tabela de Empresas
Create Table Empresas(
		idEmpresas INT PRIMARY KEY IDENTITY
		,idInteresse INT FOREIGN KEY REFERENCES Interesse(idInteresse)
		,nomeEmpresa VARCHAR(255) NOT NULL
		,Localizacao VARCHAR(255) NOT NULL 
)
GO