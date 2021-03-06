CREATE DATABASE RoleTopWST;
GO
USE RoleTopWST;
GO

CREATE TABLE Usuario (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Email VARCHAR(255) NOT NULL UNIQUE,
	Senha VARCHAR(255) NOT NULL,
	Apelido VARCHAR(255) NOT NULL UNIQUE,
);
GO
CREATE TABLE Selecao (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Foto IMAGE,
);
GO
CREATE TABLE Jogo(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	SelecaoCasa INT FOREIGN KEY REFERENCES Selecao(Id) NOT NULL,
	SelecaoVisitante INT FOREIGN KEY REFERENCES Selecao(Id) NOT NULL,
	Data DATETIME NOT NULL,
	Descricao VARCHAR(255) NOT NULL,
);
GO
CREATE TABLE Show(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Data DATETIME NOT NULL,
	Descricao VARCHAR(255) NOT NULL,
	NumeroPessoas INT NOT NULL,
);
GO
CREATE TABLE Evento (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Jogo INT FOREIGN KEY REFERENCES Jogo(Id),
	Show INT FOREIGN KEY REFERENCES Show(Id),
);
GO
CREATE TABLE Estadio (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Evento INT FOREIGN KEY REFERENCES Evento (Id) NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	Foto IMAGE,
	Latitude DECIMAL NOT NULL,
	Longitude DECIMAL NOT NULL,
	Cidade VARCHAR (255) NOT NULL,
	UF CHAR (2) NOT NULL,
);