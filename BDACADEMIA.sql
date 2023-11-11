CREATE DATABASE BDAcademia
USE BDAcademia

CREATE TABLE Aluno (
    CodAluno        INT IDENTITY CONSTRAINT PKAluno PRIMARY KEY,
    Nome            VARCHAR(50) NOT NULL,
    CPF             CHAR(14) NOT NULL CONSTRAINT UQCpf UNIQUE,
    Email           VARCHAR(70) NULL,
    Telefone        VARCHAR(14)
)
go
CREATE TABLE Plano (
    CodPlano        INT IDENTITY CONSTRAINT PKPlano PRIMARY KEY,
    NomePlano       VARCHAR(100) NOT NULL,
    Preco           MONEY NOT NULL
)
go
CREATE TABLE Matricula (
    CodMatricula    INT IDENTITY CONSTRAINT PKMatricula PRIMARY KEY,
    CodAluno        INT CONSTRAINT FKAluno FOREIGN KEY REFERENCES Aluno (CodAluno),
    CodPlano        INT CONSTRAINT FKPlano FOREIGN KEY REFERENCES Plano (CodPlano),
    DataMatricula   DATE NOT NULL,
    DataVencimento  DATE NOT NULL
)
go
CREATE TABLE Usuario (
    CodUsuario      INT IDENTITY CONSTRAINT PKUsuario PRIMARY KEY,
    Nome            VARCHAR(50) NOT NULL,
    Email           VARCHAR(70) NOT NULL CONSTRAINT UQEmail UNIQUE,
    Senha           VARCHAR(40) NOT NULL
)

SELECT * FROM Usuario;