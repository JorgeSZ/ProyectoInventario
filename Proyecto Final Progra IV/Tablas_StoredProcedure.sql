

create table Persona(
ID int not null primary key,
Nombre varchar(50) not null,
Apellido1 varchar(50) not null,
Apellido2 varchar(50) not null,
FechaNacimiento date not null
)

create table Usuario(
ID_Usuario  int not null primary key identity(1,1),
Usuario varchar(50) not null ,
Contrasenna varchar(50) not null,
ID_Persona int
Foreign key (ID_persona) references Persona(ID)
) 



CREATE PROCEDURE SP_Login
(
@us NVARCHAR(50),  @pass NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  Usuario, Contrasenna
FROM dbo.Usuario
WHERE Usuario=@us AND Contrasenna=@pass
end
