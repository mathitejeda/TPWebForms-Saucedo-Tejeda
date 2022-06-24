insert into tipousuarios (nombre,nivel) values (administrador,1)
insert into tipousuarios (nombre,nivel) values (mesero,2)

GO

insert into usuarios(IDTipo, nombre,apellidos, usuario,Contrasenia) values (1,juan,eladmin,juancito,4321)
insert into usuarios(IDTipo, nombre,apellidos, usuario,Contrasenia) values (2,john,mozo,john,1234)

go

insert into mesa(ocupada,IDMozo) values (0,2)
insert into mesa(ocupada,IDMozo) values (1,2)
insert into mesa(ocupada,IDMozo) values (0,2)
insert into mesa(ocupada,IDMozo) values (1,2)

go

insert into tipo(nombre) values ("bebida") --cambiar a tipoinsumo
insert into tipo(nombre) values ("entrada") --cambiar a tipoinsumo
insert into tipo(nombre) values ("comida") --cambiar a tipoinsumo
insert into tipo(nombre) values ("postre") --cambiar a tipoinsumo

go

insert into insumo(nombre,precio,stock,idtipo) values("pepsi",150,1000,1)
insert into insumo(nombre,precio,stock,idtipo) values("coca",150,1000,1)
insert into insumo(nombre,precio,stock,idtipo) values("pan",50,1000,2)
insert into insumo(nombre,precio,stock,idtipo) values("fideos con tuco",500,1000,3)
insert into insumo(nombre,precio,stock,idtipo) values("milanesa",300,1000,3)
insert into insumo(nombre,precio,stock,idtipo) values("helado",250,1000,4)