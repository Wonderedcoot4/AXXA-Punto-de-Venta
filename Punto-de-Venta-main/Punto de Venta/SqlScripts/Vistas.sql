use ProyectoMAD
go
create view vwInventary
as
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripci�n], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], D.unidadMedida [Unidad de Medida], A.merma[Merma], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], 
A.idDesc [id Descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin
join uniMedidaPro D
ON D.idMedida = A.uniMedida

go
create view vwEmpleados
as
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contrase�a], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser
go
create view vwEmpleados2
as
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contrase�a], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser

go

create view vwDescuento
as
SELECT Descuento.idDesc [Id Descuento], descFecha.fechaIni [Inicia], descFecha.fechaFin [Termina], Descuento.cantidad [Porcentaje], P.nombrePro [Nombre Producto], P.idProduct [Codigo] from Descuento
	join descFecha
	on descFecha.idFechaDesc = Descuento.idDesc
	join Producto P
	on Descuento.idDesc = P.idDesc

go

create view vwVenta
as
Select Recibo.fechaVenta [Fecha de Venta], DP.nombreDep [Departamento], VD.CodProducto [Codigo del Articulo], VD.PrecioUnitario [Precio Unitario],
SUM (VD.UnidadesVendidas) [Unidades Vendidas], SUM (VD.Subtotal) [Subtotal], DS.cantidad [Descuento],
SUM (VD.totalVenta) [Venta], SUM (VD.Utilidad) [Utilidad], CP.noCajaCP [Caja] from Recibo
join VentaDetalle VD
on Recibo.noVenta = VD.noDeVenta
join Departamento DP
on VD.DepartamentoId = DP.idDepa
left join Descuento DS
on VD.DescuentoId = DS.idDesc
join Caje_Pro CP
on Recibo.claveCajePro = CP.idCajePro
group by DP.nombreDep, Recibo.fechaVenta, VD.CodProducto, VD.PrecioUnitario,  DS.cantidad,  CP.noCajaCP;

go


create view vwCajero
as
Select Recibo.fechaVenta [Fecha de Venta], U.nombreU [Cajero], DP.nombreDep [Departamento],
SUM (VD.UnidadesVendidas) [Unidades Vendidas], SUM (VD.Subtotal) [Suma Venta], SUM (VD.Utilidad) [Utilidad] from Recibo
join VentaDetalle VD
on Recibo.noVenta = VD.noDeVenta
join Departamento DP
on VD.DepartamentoId = DP.idDepa
join Caje_Pro CP
on CP.idCajePro = Recibo.claveCajePro
join Usuario U
on CP.claveCajeroCP = U.idUser
group by Recibo.fechaVenta, U.nombreU, DP.nombreDep;

go

create view vwTicketsPorNum
as
Select Recibo.noVenta [Num],Recibo.fechaVenta [Fecha], Recibo.MontoPago [Monto Pago], Recibo.total [Total], Vd.CodProducto [Codigo], Vd.PrecioUnitario [Precio Unitario],
Vd.Subtotal [Subtotal], Vd.UnidadesVendidas [Se llevo], depa.nombreDep [Departamento], vd.Utilidad [Utilidad], P.nombrePro [Producto], DS.cantidad [Descuento], CP.noCajaCP [Caja] from Recibo
JOIN VentaDetalle Vd
on Recibo.noVenta = vd.noDeVenta
join Departamento depa
on vd.DepartamentoId = depa.idDepa
join Producto P
on P.idProduct = Vd.CodProducto
join Departamento Dp
on Dp.idDepa = Vd.DepartamentoId
left join Descuento DS
on DS.idDesc = VD.DescuentoId
join Caje_Pro CP
on Recibo.claveCajePro = CP.idCajePro
where Dp.devoluDepa = 'Si'
go
create view vwEmpleado
as
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contrase�a], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser