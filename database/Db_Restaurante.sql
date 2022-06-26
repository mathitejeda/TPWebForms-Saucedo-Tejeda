create database Restaurante

Go

use Restaurante

GO

create table TipoUsuarios(
 ID smallint not null primary key identity (1, 1),
 Nombre varchar(50) not null,
 Nivel bit not null,
)

Create Table Usuarios(
    ID int not null primary key identity (1, 1),
	IDTipo smallint not null foreign key references TipoUsuarios(ID),
	Nombre varchar(50) not null,
	Apellidos varchar(50) not  null,
	Usuario varchar(50) not null,
	Contrasenia varchar(50) not null,
)
GO


create Table Mesas(
    ID int not null primary key identity (1, 1),
    Ocupada bit not null default 0,
	IDMozo int foreign key references Usuarios(ID),
)
GO

Create Table Tipo(
ID smallint not null primary key identity (1, 1),
Nombre varchar(50)
)
Go

create table Insumos(
ID int not null primary key identity (1, 1),
Nombre varchar(50) not null,
precio money not null,
stock int not null,
IDTipo smallint Foreign key references Tipo(ID)
)
Go

Create Table Insumos_x_Mesa(
    IDMesa int not null foreign key references Mesas(ID),
    IDInsumo int not null foreign key references Insumos(ID),
)