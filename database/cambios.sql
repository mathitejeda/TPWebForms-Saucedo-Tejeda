use restaurante

create table pedido
(
    ID int not null primary key identity(1,1),
    idmesa int not null foreign key references mesas(id),
    total money DEFAULT(0),
    estado bit default(1)
)

GO

create table detallePedido
(
    idinsumo int foreign key references insumos(id),
    idpedido int foreign key references pedido(id),
    cantidad int default(1),
    precio money not null,
)

GO

create trigger TR_NUEVO_PEDIDO on pedido
after insert
as
begin
    declare @idpedido int
    declare @idmesa int
    declare @pedidos int

    select @idpedido=id
    from inserted

    select @idmesa=idmesa
    from inserted

    select @pedidos=count(*)
    from pedido
    where idmesa = @idmesa and estado=1

    if @pedidos > 0
    BEGIN
        delete from pedido where ID=@idpedido
        RAISERROR('No se puede crear un pedido si existen pedidos abiertos',1,1)
    END

end

GO