use Master
go
-- Buscamos la base de datos agenda, si no esta vacia, eliminarla
if db_id ('agenda') is not null
	drop database agenda
go

-- Creamos la base de datos
create database agenda;
go
use agenda;
go

-- Crear las tablas
create table distritos(
coddistrito int primary key identity(1,1),
nomdistrito nvarchar(50) NULL);
go

create table amigos(
codamigo int primary key identity(1,1),
coddistrito int not null references distritos(coddistrito) on update cascade on delete cascade,
nombre nvarchar(50) not null,
dni nvarchar(8) not null,
fecnac smalldatetime,
sexo nvarchar(10) not null,
direccion nvarchar(100),
telefono nvarchar(50));
go