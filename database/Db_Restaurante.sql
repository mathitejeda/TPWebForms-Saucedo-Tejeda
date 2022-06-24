create database Restaurante

use Restaurante


create table TipoUsuarios(
 ID smallint not null primary key identity (1, 1),
 Nombre varchar(50) not null,
 Nivel bit not null,
)

Create Table Usuarios(
    ID smallint not null primary key identity (1, 1),
	IDTipo smallint not null foreign key references TipoUsuarios(ID),
	Nombre varchar(50) not null,
	Apellidos varchar(50) not  null,
	Usuario varchar(50) not null,
	Contrasenia varchar(50) not null,
)
GO


create Table Mesas(
    ID bigint not null primary key identity (1, 1),
    Ocupada bit not null default 0,
	IDMozo smallint foreign key references Usuarios(ID),
)
GO

Create Table Tipo(
ID smallint not null primary key identity (1, 1),
Nombre varchar(50)
)
Go

create table Insumos(
ID bigint not null primary key identity (1, 1),
Nombre varchar(50) not null,
precio money not null,
stock bigint not null,
IDTipo smallint Foreign key references Tipo(ID)
)
Go

Create Table Insumos_x_Mesa(
    IDMesa bigint not null foreign key references Mesas(ID),
    IDInsumo bigint not null foreign key references Insumos(ID),
)