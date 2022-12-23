CREATE DATABASE ASantiagoEvalucacionTecnicaLumen;
GO
USE ASantiagoEvalucacionTecnicaLumen;
GO
CREATE TABLE Marca(
IdMarca INT PRIMARY KEY IDENTITY(1,1),
NombreMarca VARCHAR(100),
MarcaMostrarEnElHome BIT DEFAULT 0
);

CREATE TABLE Producto(
Sku INT PRIMARY KEY,
NombreProducto VARCHAR(250),
Precio DECIMAL,
IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
ProductoMostrarEnElHome BIT DEFAULT 0
);

CREATE TABLE Promocion(
IdPromocion INT PRIMARY KEY IDENTITY(1,1),
NombrePromocion VARCHAR(150),
FechaInicio DATETIME,
FechaTermino DATETIME
);
GO

INSERT INTO Marca (NombreMarca)VALUES ('Coca-Cola');
INSERT INTO Marca (NombreMarca)VALUES ('Bimbo')
INSERT INTO Marca (NombreMarca,MarcaMostrarEnElHome)VALUES ('Sabritas',1)
INSERT INTO Marca (NombreMarca,MarcaMostrarEnElHome)VALUES ('Samsung',1)

INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(123156,'Refresco Coca-Cola',16.5,1,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(320651,'Agua Ciel',10,1,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(971930,'Refresco Fanta',14.5,1,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(503015,'Refresco Sprite',14.5,1,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(817305,'Pan Blanco',35,2,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(866815,'Bimbuñuelos',16,2,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(150394,'Medias Noches',39,2,0)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(162300,'Sabritas Original',15,3,1)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(703280,'Cheetos',13,3,1)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(948716,'Ruffles',14.5,3,1)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(631056,'Refrigerador',15000,4,1)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(156910,'Monitor',7500,4,1)
INSERT INTO Producto (Sku,NombreProducto,Precio,IdMarca,ProductoMostrarEnElHome)VALUES(631560,'SSD 870',1600,4,1)

INSERT INTO Promocion (NombrePromocion,FechaInicio,FechaTermino)VALUES('PromocionDiciembre','2022-12-01 10:00:00','2022-12-23 10:00:00')
INSERT INTO Promocion (NombrePromocion,FechaInicio,FechaTermino)VALUES('BuenFin2021','2021-10-15 08:00:00','2021-10-19 00:00:00')
INSERT INTO Promocion (NombrePromocion,FechaInicio,FechaTermino)VALUES('Inicio2023','2023-01-01 00:00:00','2023-01-06 20:00:00')
INSERT INTO Promocion (NombrePromocion,FechaInicio,FechaTermino)VALUES('PromocionNavideña','2022-12-20 13:00:00','2022-12-25 13:00:00')


GO


CREATE PROCEDURE ProductoGetAllMostrar
AS
	SELECT  Sku,NombreProducto,Precio,Marca.IdMarca,Marca.NombreMarca,ProductoMostrarEnElHome 
FROM Producto 
INNER JOIN Marca ON Producto.IdMarca = Marca.IdMarca
WHERE ProductoMostrarEnElHome=1
ORDER BY IdMarca
GO


CREATE PROCEDURE ProductoGetAll
AS
	SELECT  Sku,NombreProducto,Precio,Marca.IdMarca,Marca.NombreMarca,ProductoMostrarEnElHome 
	FROM Producto 
	INNER JOIN Marca ON Producto.IdMarca = Marca.IdMarca
GO

CREATE PROCEDURE ProductoGetByMarca-- 2
@IdMarca INT
AS
	SELECT  Sku,NombreProducto,Precio,Marca.IdMarca,Marca.NombreMarca,ProductoMostrarEnElHome 
	FROM Producto 
	INNER JOIN Marca ON Producto.IdMarca = Marca.IdMarca
	WHERE Marca.IdMarca = @IdMarca
GO


CREATE PROCEDURE ProductoGetByNombre --'s'
@NombreProducto VARCHAR(250)
AS
	SELECT  Sku,NombreProducto,Precio,Marca.IdMarca,Marca.NombreMarca,ProductoMostrarEnElHome 
	FROM Producto 
	INNER JOIN Marca ON Producto.IdMarca = Marca.IdMarca
	WHERE NombreProducto LIKE '%' + @NombreProducto +'%'

GO

CREATE PROCEDURE PromocionGetAllActiva
AS
	SELECT IdPromocion,NombrePromocion,FechaInicio,FechaTermino
	FROM Promocion
	WHERE FechaInicio< GETDATE() AND FechaTermino> GETDATE()
	
GO

CREATE PROCEDURE MarcaGetAll
AS
	SELECT IdMarca,NombreMarca,MarcaMostrarEnElHome
	FROM Marca
GO
