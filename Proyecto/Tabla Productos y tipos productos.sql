create database Proyecto_Inventario


use Proyecto_Inventario

--Tabla Producto , no incluye precio ya que se calcula , pendiente

create table Producto (
	idProducto int not null primary key ,
	desProducto varchar (50) not null , 
	codTipoProducto int not null , 
	costo decimal (9,2) not null ,
	porcUtilidad decimal (9,2) not null ,
	codProveedor int not null , 
	--Calcularprecio decimal (9,2) null
	)

	select * from Producto
	
---------------------------------------------------------
-- Procedimiento que inserta Productos
---------------------------------------------------------

CREATE PROCEDURE [dbo].[Insertar_Producto] 
	    @Id int ,  
		@descripcionprod Varchar(50) , 
		@Tipo int , 
		@Cost decimal (10,2), 
		@Utilidad decimal (10,2),
		@proveedor int 


AS
BEGIN
	
	INSERT INTO Producto (idProducto, desProducto, codTipoProducto, costo,porcUtilidad,codProveedor)

		VALUES(
		@Id,  
		@descripcionprod  , 
		@Tipo , 
		@Cost , 
		@Utilidad ,
		@proveedor
		)

END

GO

---------------------------------------------------------
-- creacion de tabla Tipo Producto
---------------------------------------------------------
Create table Tipo_Producto(

	Id int not null IDENTITY(1,1) primary key ,
	TipoProducto varchar (50) not null , 
	
	)

	Create table Tipo_Producto(

	Id int not null  primary key ,
	TipoProducto varchar (50) not null , 
	
	)
	
	--------------------------------------------------
	--Select
	--------------------------------------------------

	select * from Tipo_Producto	

	---------------------------------------------------
	------- Insert para ingresar tipos de productos para pruebas , se debe crear procedimiento para insertar valores
	-------en caso que se requiera cambiar el tipo de producto, necesita ventana de mantenimiento
	---------------------------------------------------

	INSERT INTO Tipo_Producto ( TipoProducto)
	values
	('Frutas'),
	('Verduras'),
	('Legumbres'),
	('Leguminosas')
	

	select * from Tipo_Producto


	-----------------------------------------------------
	---Procedimiento Eliminar Producto 
	-----------------------------------------------------


CREATE PROCEDURE [dbo].[Eliminar_Prod]
	@Id int
AS
BEGIN
	
	Delete from Producto where idProducto = @Id 
	
END

		
--------------------------------------------------------
--Procedimiento mostrar productos
--------------------------------------------------------

CREATE PROCEDURE [dbo].[Mostrar_Prod]
	
AS
BEGIN
	
	Select * from Producto  
	
END
GO

--------------------------------------------------------
--Procedimiento modificar producto
--------------------------------------------------------

CREATE PROCEDURE [dbo].[Actualizar_Prod]
		@Id int ,  
		@descripcionprod Varchar(50) , 
		@Tipo int , 
		@Cost decimal (10,2), 
		@Utilidad decimal (10,2),
		@proveedor int  
AS
BEGIN
	
	UPDATE Producto 

	SET 
		desProducto= @descripcionprod ,
		codTipoProducto =@Tipo, 
		costo = @Cost ,
		porcUtilidad = @Utilidad ,
		codProveedor = @proveedor 
		

	WHERE idProducto = @Id;
	
END
GO