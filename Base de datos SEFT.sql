use master;
go

drop database if exists SEFT; 
go

create database SEFT;
go

use SEFT;
go

create table Categoria(
ID_Categoria int identity(1,1) primary key,
NombreCatergoria varchar(75) not null
);
go

create table Producto(
ID_Producto int identity(1,1) primary key,
Nombre varchar(100) not null,
Precio decimal(6,2) not null check (Precio > 0),
Cantidad int not null check (Cantidad > 0),
Disponibilidad varchar(50) not null,
Total decimal (6,2) not null check(Total >= 0),
ID_Categoria int not null,

constraint FK_ID_Categoria
foreign key (ID_Categoria)
references Categoria (ID_Categoria)
on delete cascade
on update cascade,
);
go

create table Roles(
Id_Rol int identity(1,1) primary key,
NombreRol varchar(75) not null
);
go

create table Usuario(
username varchar(75) not null  primary key,
password varchar(256) not null,
Id_Rol int not null default(0),

constraint FK_Id_Rol
foreign key (ID_Rol)
references Roles(ID_Rol)
on delete cascade
on update cascade
);
go

create table Empleado(
ID_Empleado int identity(1,1) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Correo varchar(100) not null,
DUI varchar(50) not null unique,
Telefono varchar(50) not null unique,
username varchar(75) not null,

foreign key (username)
references Usuario (username)
on delete cascade
on update cascade
);
go

create table Cliente(
ID_Cliente int identity(1,1) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Edad int not null  check(Edad > 18),
DUI varchar(50) not null unique
);
go

create table Venta(
ID_Venta int identity(1,1) primary key,
ID_Empleado int not null,
ID_Cliente int not null,
FechaVenta varchar(100) not null,

constraint FK_ID_Empleado
foreign key (ID_Empleado)
references Empleado (ID_Empleado)
on delete cascade
on update cascade,

constraint FK_ID_Cliente
foreign key (ID_Cliente)
references Cliente (ID_Cliente)
on delete cascade
on update cascade
);
go

create table DetalleVenta(
ID_Detalle int identity(1,1) primary key,
ID_Venta int not null,
ID_Producto int not null,
Cantidad int not null check(Cantidad > 0),
Precio decimal(6,2) not null check(Precio > 0),
MetodoPago varchar(50) not null,
Subtotal decimal(6,2) not null,

constraint FK_ID_Venta
foreign key (ID_Venta)
references Venta (ID_Venta)
on delete cascade
on update cascade,

constraint FK_ID_Producto
foreign key (ID_Producto)
references Producto (ID_Producto)
on delete cascade
on update cascade
);
go

create table Factura(
ID_Factura int identity(1,1) primary key,
ID_Venta int not null,
Total decimal not null check(Total > 0),

constraint FK_ID_VentaF
foreign key (ID_Venta)
references Venta (ID_Venta)
on delete cascade
on update cascade
);
go

create table Pago(
ID_Pago int identity(1,1) primary key,
ID_Empleado int not null,
ID_TipoEmpleado int not null,
Salario decimal(6,2) not null check(Salario > 0),
Total decimal(6,2) check(Total > 0),

foreign key (ID_Empleado)
references Empleado (ID_Empleado),

foreign key (ID_TipoEmpleado)
references Roles (ID_Rol)
);
go

insert into Categoria values
('Consola'),
('Videojuego'),
('Mandos'),
('Accesorio');
/*ID_Categoria,
NombreCatergoria */
go

insert into Producto values
('Playstation 5', 1200, 5, 'Disponible', 6000, 1),
('Xbox Series X', 700, 1, 'Disponible', 700, 1),
('Mando playstation 5', 80, 10, 'Disponible', 800, 3),
('Playstation 4', 400, 3, 'Disponible', 1200, 1),
('Mando Playstation 4', 70, 10, 'Disponible', 700, 3),
('Teclado', 24, 8, 'Disponible', 192, 3),
('The last of us', 15, 8, 'Disponible', 120, 2),
('Nintendo Switch', 350, 5, 'Disponible', 1750, 1),
('Joycon nintendo switch', 70, 9, 'Disponible', 630, 3),
('Pokemon espada y escudo', 60, 6, 'Disponible', 360, 2);
/*ID_Product
Nombre
Precio
Cantidad
Disponibilidad
Total
ID_Categoria*/
go

insert into Roles values
('Administrador'),
('Bodeguero'),
('Cajero');
/*ID_TipoEmpleado
NombreTipo*/
go
/*
insert into Usuario values
('Pedro1', '1234', 1),
('Carlos1', '4321',1),
('Diego1', '2134',1),
('Marcos1', '1432',1),
('Alejandro1', '1423',1),
('Gerardo1', '2341',1),
('Alvaro1', '3214',1),
('Fabian1', '1243',1),
('Kevin1', '3214',1),
('German1', '4231',1);*/
/*ID_Usuario
NombreUsuario
Contraseña*/
go
/*
insert into Empleado values
('Pedro', 'Valle', 'pedro@gmail.com','00177341-9', '1234-4543', 'Pedro1'),
('Carlos', 'Garcia', 'Carlos@gmail.com','00173676-8', '6423-9836', 'Carlos1'),
('Diego', 'Arriaza', 'Diego@gmail.com','00173621-7', '9936-2771', 'Diego1'),
('Marcos', 'Torres', 'Marcos@gmail.com','00173675-9','1836-8927', 'Marcos1'),
('Alejandro', 'Murcia', 'Alejandro@gmail.com','00179876-7', '1234-2345', 'Alejandro1'),
('Gerardo', 'Osorio', 'Gerardo@gmail.com','00173236-6', '7782-1289', 'Gerardo1'),
('Alvaro', 'Ortega', 'Alvaro@gmail.com','00173213-8', '7876-1635', 'Alvaro1'),
('Fabian', 'Rivas', 'Fabian@gmail.com','00173126-9', '2455-2225', 'Fabian1'),
('Kevin', 'Perez', 'Kevin@gmail.com','00173761-7', '2654-7565', 'Kevin1'),
('German', 'Gonzales', 'German@gmail.com','00933676-9', '2123-4354', 'German1');*/
/*
ID_Empleado,
Nombre,
Apellido,
Correo,
DUI,
Telefono,
username*/
go


insert into Cliente values
('Jose', 'Rodriguez', 25, '0567848-7'),
('Rene', 'Chiquillo', 21, '0011974-8'),
('Edgardo', 'Ehlerman', 22, '0017318-9'),
('Paolo', 'Urquilla', 24, '00171238-6'),
('Carla', 'Martinez', 26, '00176788-8'),
('Jeancarlos', 'Vasquez', 27, '00181748-7'),
('Ricardo', 'Iraheta', 29, '00172912-9'),
('Adrian', 'Guerra', 20, '00172123-6'),
('Antonio', 'Banderas', 19, '00863848-6'),
('Nelson', 'perez', 23, '001728267-9');
/*ID_Cliente
Nombre
Apellido
Edad
DUI*/
go
/*
insert into Venta values
(1, 10, '10 de mayo'),
(2, 9, '2 de julio'),
(8, 8, '30 de agosto'),
(3, 7, '17 de mayo'),
(6, 6, '11 de enero'),
(7, 5, '22 de septiembre'),
(9, 4, '27 de noviembre'),
(10, 3, '6 de octubre'),
(4, 2, '9 de diciembre'),
(5, 1, '19 de abril');*/
/*ID_Venta
ID_Empleado
ID_Cliente
FechaVenta*/
go
/*
insert into DetalleVenta values
(5, 5, 1, 70 ,'efectivo', 70),
(2, 1, 1, 1.200 ,'Targeta', 1200),
(1, 10, 3, 180 ,'efectivo', 180),
(3, 2, 2, 1400 ,'Targeta', 1400),
(4, 4, 6, 2400 ,'Targeta', 2400),
(6, 2, 1, 700 ,'Targeta', 700),
(7, 7, 2, 30 ,'efectivo', 30),
(8, 8, 2, 700 ,'Targeta', 700),
(9, 9, 4, 280 ,'efectivo', 280),
(10, 3, 4, 320 ,'efectivo', 320);*/
/*ID_Detalle
ID_Venta
ID_Producto
Cantidad
Precio
MetodoPago
Subtotal*/
go
/*
insert into Factura values
(1, 180),
(5, 70),
(2, 1200),
(4, 2400),
(3, 1400),
(6, 700),
(7, 30),
(8, 700),
(10, 320),
(9, 280);*/
/*ID_Factura
ID_Venta
Total*/
go
/*
insert into Pago values
(1, 3, 800, 800),
(2, 2, 1000, 1000),
(3, 1, 1200, 1200),
(4, 1, 1200, 1200),
(5, 2, 1000, 1000),
(6, 3, 800, 800),
(7, 1, 1200, 1200),
(8, 1, 1200, 1200),
(9, 2, 1000, 1000),
(10, 2, 1200, 1200);*/
/*ID_Pago
ID_Empleado
ID_TipoEmpleado
Salario
Total*/
go

SELECT Empleado.ID_Empleado as ID, Empleado.nombre as Nombre, Empleado.apellido as Apellido, DUI as Dui, Empleado.Correo as Correo, 
Empleado.Telefono as Telefono, Empleado.username as [Nombre de Usuario], Roles.NombreRol as Rol from Empleado
INNER JOIN Usuario on Usuario.username = Empleado.username
INNER JOIN Roles on Usuario.id_Rol = Roles.Id_Rol

