
CREATE PROCEDURE pa_SELECT_ARCHIVOEVIDENCIA
AS
SELECT idArchivoEvidencia,id_Estudiante,FK_idAsignatura,FK_idprofesor, nombre,ruta,fecha,observacion
FROM ArchivoEvidencia
GO

CREATE PROCEDURE pa_ARCHIVOEVIDENCIA_INSERTAR
(@idArchivoEvidencia int ,
@id_Estudiante int ,
@FK_idAsignatura int ,
@FK_idprofesor int ,
@nombre char(50) ,
@ruta char(100) ,
@fecha date ,
@observacion char(50) )
AS
INSERT INTO ArchivoEvidencia (idArchivoEvidencia,id_Estudiante,FK_idAsignatura,FK_idprofesor,nombre,ruta,fecha,observacion)
VALUES( @idArchivoEvidencia,@id_Estudiante,@FK_idAsignatura,@FK_idprofesor,@nombre,@ruta,@fecha,@observacion)
SELECT @@IDENTITY AS Id
RETURN
GO

CREATE PROCEDURE pa_ARCCHIVOEVIDENCIA_UPDATE
(@idArchivoEvidencia int ,
@id_Estudiante int ,
@FK_idAsignatura int ,
@FK_idprofesor int ,
@nombre char(50) ,
@ruta char(100) ,
@fecha date ,
@observacion char(50) )
AS
UPDATE ArchivoEvidencia
SET idArchivoEvidencia=@idArchivoEvidencia, id_Estudiante=@id_Estudiante,FK_idAsignatura=@FK_idAsignatura,FK_idprofesor=@FK_idprofesor,nombre=@nombre,ruta=@ruta,fecha=@fecha,observacion=@observacion
WHERE idArchivoEvidencia =@idArchivoEvidencia
GO
CREATE PROCEDURE pa_ARCHIVOEVIDENCIA_DELETE
( @idArchivoEvidencia int
)
AS
DELETE FROM ArchivoEvidencia WHERE idArchivoEvidencia= @idArchivoEvidencia
GO
CREATE PROCEDURE pa_SELECT_ARTICULO
AS
SELECT idArticulo,FK_idNumeral,nombre, observacion
FROM Articulo
GO

CREATE PROCEDURE pa_ARTICULO_INSERTAR
( @idArticulo int,
@FK_idNumeral int,
@Nombre char(50),
@observacion char(50))
AS
INSERT INTO Articulo ( idArticulo,FK_idNumeral,Nombre,observacion)
VALUES( @idArticulo,@FK_idNumeral,@Nombre,@observacion)
SELECT @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_ARTICULO_UPDATE
( @idArticulo int,
@FK_idNumeral int,
@Nombre char(50),
@observacion char(50))
AS
UPDATE Articulo
SET idArticulo=@idArticulo,FK_idNumeral=@FK_idNumeral,Nombre=@Nombre,observacion=@observacion
WHERE idArticulo=@idArticulo
GO
CREATE PROCEDURE pa_ARTICULO_DELETE
(@idArticulo int
)
AS
DELETE FROM Articulo WHERE idArticulo= @idArticulo
GO
CREATE PROCEDURE pa_SELECT_ASIGNATURA
AS
SELECT IdAsignatura, Fk_idSemestre,Fk_idPrograma,nombre
FROM Asignatura
GO
CREATE PROCEDURE pa_ASIGNATURA_INSERTAR
(@idAsignatura INT,
@FK_idSemestre INT,
@FK_idPrograma INT,
@nombre VARCHAR(50))
AS
INSERT INTO Asignatura(IdAsignatura, Fk_idSemestre,Fk_idPrograma,nombre)
VALUES (@idAsignatura,@FK_idSemestre,@FK_idPrograma,@nombre)
SELECT @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_ASIGNATURA_UPDATE
(@idAsignatura INT,
@FK_idSemestre INT,
@FK_idPrograma INT,
@nombre VARCHAR(50))
AS
UPDATE Asignatura
SET idAsignatura= @idAsignatura, FK_idSemestre=@FK_idSemestre, FK_idPrograma=@FK_idPrograma,nombre=@nombre
WHERE idAsignatura =@idAsignatura
GO
CREATE PROCEDURE pa_ASIGNATURA_DELETE
( @idAsignatura int
)
AS
DELETE FROM Asignatura WHERE idAsignatura=@idAsignatura
GO
create procedure pa_SELECT_CAPITULO
AS
SELECT idCapitulo,Fk_idArticulo,nombre,observacion
FROM capitulo
GO
CREATE PROCEDURE pa_CAPITULO_INSERTAR
(@idCapitulo int,
@Fk_idArticulo int,
@Nombre char(50),
@observacion char(50))
AS
INSERT INTO capitulo (idCapitulo, FK_idArticulo, Nombre, observacion)
VALUES (@idCapitulo,@Fk_idArticulo,@Nombre,@observacion)
select @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_CAPITULO_UPDATE
(@idCapitulo int,
@Fk_idArticulo int,
@Nombre char(50),
@observacion char(50))
AS
UPDATE capitulo
SET idCapitulo=@idCapitulo,FK_idArticulo=@Fk_idArticulo,Nombre=@Nombre,observacion=@observacion
WHERE idCapitulo=@idCapitulo
GO
CREATE PROCEDURE pa_CAPITULO_DELETE
(@idCapitulo int
)
AS
DELETE FROM capitulo WHERE idCapitulo=@idCapitulo
GO
create procedure pa_SELECT_CONDICION
AS
SELECT idCondicion,Fk_idCapitulo,nombre,observacion
FROM Condicion
GO
CREATE PROCEDURE pa_CONDICION_INSERTAR
(@idCondicion int,
@Fk_idCapitulo int,
@Nombre char(50),
@observacion char(50))
AS
INSERT INTO condCondicion(idCondicion, FK_idCapitulo, Nombre, observacion)
VALUES (@idCondicion,@Fk_idCapitulo,@Nombre,@observacion)
select @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_CONDICION_UPDATE
(@idCondicion int,
@Fk_idCapitulo int,
@Nombre char(50),
@observacion char(50))
AS
UPDATE Condicion
SET idCondicion=idCondicion,FK_idCapitulo=@Fk_idCapitulo,Nombre=@Nombre,observacion=@observacion
WHERE idCondicion=@idCondicion
GO
CREATE PROCEDURE pa_CONDICION_DELETE
(@idCondicion int
)
AS
DELETE FROM Condicion WHERE idCondicion=@idCondicion
GO
CREATE PROCEDURE pa_SELECT_PROGRAMA
AS
SELECT idPrograma,nombre
FROM Programa
GO
CREATE PROCEDURE pa_PROGRAMA_INSERT
(@idPrograma INT,
@nombre VARCHAR(50))
AS
INSERT INTO Programa (idPrograma,nombre)
VALUES (@idPrograma,@nombre)
SELECT @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_PROGRAMA_UPDATE
(@idPrograma INT,
@nombre VARCHAR(50))
AS
UPDATE Programa
SET idPrograma=@idPrograma, nombre=@nombre
WHERE idPrograma=@idPrograma
GO
CREATE PROCEDURE pa_PROGRAMA_DELETE
(@idPrograma int
)
AS 
DELETE FROM Programa WHERE idPrograma=@idPrograma
GO
CREATE PROCEDURE pa_SELECT_TIPOEVIDENCIA
AS
SELECT idTipoEvidencia,nombre,observacion
FROM TipoEvidencia
GO
CREATE PROCEDURE pa_TIPOEVIDENCIA_INSERTAR
(@idTipoEvidencia int,
@nombre char(50),
@observacion char(500))
AS
INSERT INTO TipoEvidencia (idTipoEvidencia,nombre,observacion)
VALUES( @idTipoEvidencia,@nombre,@observacion)
SELECT @@IDENTITY AS Id
RETURN
GO
CREATE PROCEDURE pa_TIPOEVIDENCIA_UPDATE
(@idTipoEvidencia int,
@nombre char(50),
@observacion char(500))
AS
UPDATE TipoEvidencia
SET idTipoEvidencia=@idTipoEvidencia,nombre=@nombre,observacion=@observacion
WHERE idTipoEvidencia=@idTipoEvidencia
GO
CREATE PROCEDURE pa_TIPOEVIDENCIA_DELETE
(@idTipoEvidencia int
)
AS
DELETE FROM TipoEvidencia WHERE idTipoEvidencia=@idTipoEvidencia
GO
CREATE PROCEDURE pa_SELECT_Estudiante
AS
SELECT idEstudiante,FK_idAsignatura,nombre,apellido,x,y
FROM Estudiante
GO
CREATE PROCEDURE pa_SELECT_EVIDENCIA
AS
SELECT idEvidencia,FK_idArchivoEvidencia,id_TipoEvidencia,titulo,autor,fecha
FROM Evidencia
GO
CREATE PROCEDURE pa_SELECT_FACULTAD
AS
SELECT idFacultad,FK_idPrograma,nombre
from FacultaD
GO
CREATE PROCEDURE pa_SELECT_NUMERAL
AS
SELECT idNumeral,FK_idArchivoEvidencia,nombre,observacion
from Numeral
GO
CREATE PROCEDURE pa_SELECT_PROFESOR
AS
SELECT idProfesor,FK_idAsignatura,nombre,apellido,x,y
FROM Profesor
GO