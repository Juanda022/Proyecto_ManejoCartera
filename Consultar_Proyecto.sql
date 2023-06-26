use Proyecto
---------------GENERAL-----------------
CREATE PROCEDURE CONSULTAR_USUARIO
AS
SELECT*FROM USUARIO

CREATE PROCEDURE CONSULTAR_CARGO
AS
SELECT*FROM CARGO

CREATE PROCEDURE CONSULTAR_COMPROBANTE
AS
SELECT*FROM COMPROBANTE

CREATE PROCEDURE CONSULTAR_FORMAS_PAGOS
AS
SELECT*FROM FORMAS_PAGOS

CREATE PROCEDURE CONSULTAR_PROVEEDORES
AS
SELECT*FROM PROVEEDORES

CREATE PROCEDURE CONSULTAR_EMPLEADO
AS
SELECT*FROM EMPLEADO

CREATE PROCEDURE CONSULTAR_FACTURA_COMPRA
AS
SELECT*FROM FACTURA_COMPRA

CREATE PROCEDURE CONSULTAR_CLIENTE
AS
SELECT*FROM CLIENTE

CREATE PROCEDURE CONSULTAR_FACTURA_VENTA
AS
SELECT*FROM FACTURA_VENTA

CREATE PROCEDURE CONSULTAR_RECIBO_CAJA
AS
SELECT*FROM RECIBO_CAJA

CREATE PROCEDURE CONSULTAR_PAGOS
AS
SELECT*FROM PAGOS
----------------ESPECIFICO---------------------
CREATE PROCEDURE CONSULTAR_INIUSUARIO_ESPECIFICO
@CONUSUARIO_INISESION varchar(50)
AS
SELECT Usuario_Usuario,Contraseņa_Usuario,Nombre_Usuario,Rol_Usuario,Estado_Usuario
from USUARIO
where @CONUSUARIO_INISESION=Usuario_Usuario

CREATE PROCEDURE CONSULTAR_CARGO_ESPECIFICO
@CONCODIGO_CARGO varchar(10)
AS
SELECT Codigo_Cargo,Nombre_Cargo,Estado_Cargo
from CARGO
where @CONCODIGO_CARGO=Codigo_Cargo

CREATE PROCEDURE CONSULTAR_COMPROBANTE_ESPECIFICO
@CONRAZON_COMPROBANTE varchar(70)
AS
SELECT Razon_Comprobante,Fecha_Comprobante,Nombre_Comprobante,Estado_Comprobante
from COMPROBANTE
where @CONRAZON_COMPROBANTE=Razon_Comprobante

CREATE PROCEDURE CONSULTAR_FORMAS_PAGOS_ESPECIFICO
@CONCODIGO_FORMAPG varchar(10)
AS
SELECT Codigo_FormaPG,Nombre_FormaPG,Estado_FormaPG
from FORMAS_PAGOS
where @CONCODIGO_FORMAPG=Codigo_FormaPG

CREATE PROCEDURE CONSULTAR_PROVEEDORES_ESPECIFICO
@CONCODIGO_PROVEEDORES numeric
AS
SELECT Codigo_Proveedores,Direccion_Proveedores,Telefono_Proveedores,Nombre_Proveedores,Razon_Comprobante_Proveedores_FK,Estado_Proveedores
from PROVEEDORES
where @CONCODIGO_PROVEEDORES=Codigo_Proveedores

CREATE PROCEDURE CONSULTAR_EMPLEADO_ESPECIFICO
@CONCODIGO_EMPLEADO numeric
AS
SELECT Codigo_Empleado,Id_Empleado,Nombre_Empleado,Direccion_Empleado,Telefono_Empleado,FechaNaci_Empleado,Genero_Empleado,Salario_Empleado,Usuario_Usuario_Empleado_FK,Codigo_Cargo_Empleado_FK,Codigo_Proveedores_Empleado_FK
from EMPLEADO
where @CONCODIGO_EMPLEADO=Codigo_Empleado

CREATE PROCEDURE CONSULTAR_FACTURA_COMPRA_ESPECIFICO
@CONCODIGO_FACTC numeric
AS
SELECT Codigo_FactComp,Codigo_Empleado_FactComp_FK,Codigo_Proveedores_FactComp_FK,Fecha_FactComp,Valor_FactComp,Estado_FactComp
from FACTURA_COMPRA
where @CONCODIGO_FACTC=Codigo_FactComp

CREATE PROCEDURE CONSULTAR_CLIENTE_ESPECIFICO
@CONCODIGO_CLIENTE numeric
AS
SELECT Codigo_Cliente,Id_Cliente,Nombre_Cliente,Direccion_Cliente,Telefono_Cliente,Genero_Cliente,Codigo_Empleado_Cliente_FK,Estado_Cliente
from CLIENTE
where @CONCODIGO_CLIENTE=Codigo_Cliente

CREATE PROCEDURE CONSULTAR_FACTURA_VENTA_ESPECIFICO
@CONCODIGO_FACTV numeric
AS
SELECT Codigo_FactVent,Codigo_Empleado_FactVent_FK,Codigo_Cliente_FactVent_FK,Fecha_FactVent,Valor_FactVent,Estado_FactVent
from FACTURA_VENTA
where @CONCODIGO_FACTV=Codigo_FactVent

CREATE PROCEDURE CONSULTAR_RECIBO_CAJA_ESPECIFICO
@CONCODIGO_RECICAJA numeric
AS
SELECT Codigo_ReciCaja,Codigo_Cliente_ReciCaja_FK,Codigo_FactVent_ReciCaja_FK,Fecha_ReciCaja,Valor_ReciCaja,Descripcion_ReciCaja,Estado_ReciCaja
from RECIBO_CAJA
where @CONCODIGO_RECICAJA=Codigo_ReciCaja

CREATE PROCEDURE CONSULTAR_PAGOS_ESPECIFICO
@CONNUMERO_PAGOS int
AS
SELECT Numero_Pagos,Valor_Pagos,Codigo_FormaPG_Pagos_FK,Fecha_Pagos,Codigo_Empleado_Pagos_FK,Codigo_Cliente_Pagos_FK,Codigo_FactVent_Pagos_FK,Codigo_FactComp_Pagos_FK,Estado_Pagos
from PAGOS
where @CONNUMERO_PAGOS=Numero_Pagos 