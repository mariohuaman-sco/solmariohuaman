
CREATE DATABASE SOL_MARIO_HUAMAN
go

USE  SOL_MARIO_HUAMAN
GO


CREATE TABLE Empleados (
Id int identity(1,1),
Dni varchar(8),
Nombres varchar(100),
Apellidos varchar(100),
Correo varchar(max),
NumeroCelular varchar(20),
Salario numeric(18,2),
IdDepartamento int,
EsJefe bit,

)
go

INSERT INTO Empleados (Dni,Nombres ,Apellidos ,Correo,NumeroCelular,Salario,IdDepartamento,EsJefe) values
('1000123','Rafael','Lopez Aliaga','rafael.lopez@gmail.com','92942424',4000,1,1),
('1000124','Keiko','Fujimori','keiko.fujimori@gmail.com','99646542',8500,1,0),
('1000125','Pedro','Castillo','pedro.castillo@gmail.com','96614317',1500,1,0),
('1000126','Hernando','De Soto','hernando.soto@gmail.com','92942424',600,1,0),
('1000127','George','Forsyth','george.forsty@gmail.com','988845421',999,1,0),
('1000128','Pedro','Acuña','pedro.acuña@gmail.com','999552321',10000,2,1)
go

CREATE TABLE Departamento (
IdDepartamento int identity(1,1),
Descripcion varchar(100),
IdJefe int)
go



insert into Departamento(Descripcion,IdJefe)
values ('SISTEMAS',1),
 ('RECURSOS HUMANOS',6)
 GO

SELECT * FROM Empleados
 SELECT * FROM Departamento


 ALTER TABLE Empleados ADD PRIMARY KEY (Id)

 ALTER TABLE Departamento ADD PRIMARY KEY (IdDepartamento)
 

 ALTER TABLE Empleados ADD   CONSTRAINT fk_departamentos FOREIGN KEY (IdDepartamento)
    REFERENCES Departamento(IdDepartamento)

