use Examen

Select * From Album;

Select * From Cancion;

Create table Persona(
id int identity primary key,
Nombre varchar(50),
Apellido varchar(50),
Telefono int,
Album varchar(50),
Cancion varchar(50)
)

--Mostrar Personas...
CREATE PROCEDURE spr_mostrarPersonas
AS BEGIN
	SELECT * FROM Persona;
END

--Inserar Personas...
CREATE PROCEDURE spr_insertarPersonas
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono int,
@Album varchar(50),
@Cancion varchar(50)
AS BEGIN
	INSERT INTO Persona Values(@Nombre,@Apellido,@Telefono,@Album,@Cancion);
END

--Modificar Personas...
CREATE PROCEDURE spr_modificarPersonas
@id int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono int,
@Album varchar(50),
@Cancion varchar(50)
AS BEGIN
	UPDATE Persona SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Album=@Album, Cancion=@Cancion WHERE id=@id;
END

CREATE PROCEDURE spr_eliminarPersona
@id int
AS BEGIN
	DELETE FROM Persona WHERE id=@id;
END


EXEC spr_mostrarPersonas

EXEC spr_eliminarPersona 3

EXEC spr_insertarPersonas 'Pedddro','Pablo',33333,'ddd','hhddh'

EXEC spr_modificarPersonas 1, 'Pedddro', 'Pablo', 33333, 'ddd', 'hhddh';

INSERT INTO Prueba Values('Uno','Dos',33333,'ddd','hhddh');

UPDATE Persona SET Nombre='ddd', Apellido='ddd', Telefono=666, Album='ddd', Cancion='ddd' WHERE id=4;