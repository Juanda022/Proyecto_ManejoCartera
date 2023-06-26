create database Proyecto
use Proyecto

select*from USUARIO
create table USUARIO(
Usuario_Usuario varchar(50)primary key not null,
Contraseña_Usuario varchar(20)not null,
Nombre_Usuario varchar(35)not null,
Rol_Usuario varchar(35)not null,
Estado_Usuario varchar(10)not null
)

create table CARGO(
Codigo_Cargo varchar(10)primary key not null,
Nombre_Cargo varchar(20)not null,
Estado_Cargo varchar(10) not null
)

create table COMPROBANTE(
Razon_Comprobante varchar(70) primary key not null,
Fecha_Comprobante datetime not null,
Nombre_Comprobante varchar(40)not null,
Estado_Comprobante varchar(10)not null
)

create table FORMAS_PAGOS(
Codigo_FormaPG Varchar(10)primary key not null,
Nombre_FormaPG Varchar(20)not null,
Estado_FormaPG Varchar(10)not null
)

create table PROVEEDORES(
Codigo_Proveedores numeric primary key not null,
Direccion_Proveedores varchar(45)not null,
Telefono_Proveedores numeric not null,
Nombre_Proveedores varchar(35)not null,
Razon_Comprobante_Proveedores_FK  varchar(70) foreign key(Razon_Comprobante_Proveedores_FK)references COMPROBANTE(Razon_Comprobante) not null,
Estado_Proveedores varchar(10)not null
)

Create table EMPLEADO(
Codigo_Empleado numeric primary key not null,
Id_Empleado numeric not null,
Nombre_Empleado varchar(30)not null,
Direccion_Empleado varchar(25)not null,
Telefono_Empleado Numeric not null,
FechaNaci_Empleado datetime not null,
Genero_Empleado varchar(10)not null,
Salario_Empleado float not null,
Usuario_Usuario_Empleado_FK varchar(50) foreign key(Usuario_Usuario_Empleado_FK)references USUARIO(Usuario_Usuario) not null,
Codigo_Cargo_Empleado_FK varchar(10) foreign key(Codigo_Cargo_Empleado_FK)references CARGO(Codigo_Cargo)not null,
Estado_Empleado varchar(10)not null,
Codigo_Proveedores_Empleado_FK numeric foreign key(Codigo_Proveedores_Empleado_FK)references PROVEEDORES(Codigo_Proveedores) not null
)


Create table FACTURA_COMPRA(
Codigo_FactComp numeric primary key not null,
Codigo_Empleado_FactComp_FK numeric foreign key(Codigo_Empleado_FactComp_FK)references EMPLEADO(Codigo_Empleado)not null,
Codigo_Proveedores_FactComp_FK numeric foreign key(Codigo_Proveedores_FactComp_FK)references PROVEEDORES(Codigo_Proveedores) not null,
Fecha_FactComp datetime not null,
Valor_FactComp Float not null,
Estado_FactComp Varchar(10) not null
)

Create table CLIENTE(
Codigo_Cliente numeric primary key not null,
Id_Cliente numeric not null,
Nombre_Cliente varchar(30)not null,
Direccion_Cliente varchar(25)not null,
Telefono_Cliente Numeric not null,
Genero_Cliente varchar(10)not null,
Codigo_Empleado_Cliente_FK numeric foreign key(Codigo_Empleado_Cliente_FK)references EMPLEADO(Codigo_Empleado)not null,
Estado_Cliente varchar(10)not null
)

Create table FACTURA_VENTA(
Codigo_FactVent numeric primary key not null,
Codigo_Empleado_FactVent_FK numeric foreign key(Codigo_Empleado_FactVent_FK)references EMPLEADO(Codigo_Empleado)not null,
Codigo_Cliente_FactVent_FK numeric foreign key(Codigo_Cliente_FactVent_FK)references CLIENTE(Codigo_Cliente)not null,
Fecha_FactVent datetime not null,
Valor_FactVent float not null,
Estado_FactVent varchar(10)not null
)

Create table RECIBO_CAJA(
Codigo_ReciCaja numeric identity primary key not null,
Codigo_Cliente_ReciCaja_FK numeric foreign key(Codigo_Cliente_ReciCaja_FK)references CLIENTE(Codigo_Cliente)not null,
Codigo_FactVent_ReciCaja_FK numeric foreign key(Codigo_FactVent_ReciCaja_FK)references FACTURA_VENTA(Codigo_FactVent)not null,
Fecha_ReciCaja datetime not null,
Valor_ReciCaja float not null,
Descripcion_ReciCaja varchar(50)not null,
Estado_ReciCaja varchar(10)not null
)

Create table PAGOS(
Numero_Pagos int identity primary key not null,
Valor_Pagos float not null,
Codigo_FormaPG_Pagos_FK varchar(10) foreign key(Codigo_FormaPG_Pagos_FK)references FORMAS_PAGOS(Codigo_FormaPG)not null,
Fecha_Pagos datetime not null,
Codigo_Empleado_Pagos_FK numeric foreign key(Codigo_Empleado_Pagos_FK)references EMPLEADO(Codigo_Empleado)not null,
Codigo_Cliente_Pagos_FK numeric foreign key(Codigo_Cliente_Pagos_FK)references CLIENTE(Codigo_Cliente)not null,
Codigo_FactVent_Pagos_FK numeric foreign key(Codigo_FactVent_Pagos_FK)references FACTURA_VENTA(Codigo_FactVent)not null,
Codigo_FactComp_Pagos_FK numeric foreign key(Codigo_FactComp_Pagos_FK)references FACTURA_COMPRA(Codigo_FactComp)not null,
Estado_Pagos varchar(10) not null
)

select*from USUARIO