-- En usuario root dentro de la máquina virtual
-- IP de servidor: 192.168.1.250
CREATE USER 'usuario1'@'%' IDENTIFIED BY '123456';

CREATE DATABASE asignacion;
USE asignacion;

GRANT ALL ON asignacion.* TO 'usuario1'@'%';
FLUSH PRIVILEGES;

-- Después de otorgar permisos, se conecta al usuario mediante MySQL Workbench
-- para ejecutar los comandos que continuan
#CREACION DE LAS JORNADAS
CREATE TABLE TBL_JORNADA(
ID_JORNADA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_JORNADA VARCHAR(255) NOT NULL,
HORARIO TIME NOT NULL
);

insert into TBL_JORNADA (NOMBRE_JORNADA, HORARIO) values ('Matutina', '8:13');
insert into TBL_JORNADA (NOMBRE_JORNADA, HORARIO) values ('vespertina', '13:19');
insert into TBL_JORNADA (NOMBRE_JORNADA, HORARIO) values ('sabatina', '13:40');
insert into TBL_JORNADA (NOMBRE_JORNADA, HORARIO) values ('Matutina', '13:49');

#CREACION DE CARRERAS
CREATE TABLE TBL_CARRERA(
ID_CARRERA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_CARRERA VARCHAR(255) NOT NULL,
CODIGO_CARRERA VARCHAR(255) NOT NULL UNIQUE,
PENSUM VARCHAR(255) NOT NULL
);
ALTER TABLE TBL_CARRERA ADD CONSTRAINT COD_CARRERA UNIQUE (CODIGO_CARRERA);
SHOW TABLES;
insert into TBL_CARRERA (NOMBRE_CARRERA, CODIGO_CARRERA, PENSUM) values ('Administración de Empresas', 'CCU202', 'Matemáticas');
insert into TBL_CARRERA (NOMBRE_CARRERA, CODIGO_CARRERA, PENSUM) values ('Administración de Empresas', 'CCU202', 'Física');
insert into TBL_CARRERA (NOMBRE_CARRERA, CODIGO_CARRERA, PENSUM) values ('Administración de Empresas', 'CCU303', 'Química');
insert into TBL_CARRERA (NOMBRE_CARRERA, CODIGO_CARRERA, PENSUM) values ('Administración de Empresas', 'CCU303', 'Biología');
UPDATE TBL_CARRERA SET CODIGO_CARRERA = 'CCU201' WHERE PENSUM = 'Física';
UPDATE TBL_CARRERA SET CODIGO_CARRERA = 'CCU304' WHERE PENSUM = 'Química';

#CREACION DE LA SEDE PARA MAYOR CONTROL
CREATE TABLE TBL_SEDE(
ID_SEDE INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_SEDE VARCHAR(255) NOT NULL,
UBICACION VARCHAR(255) NOT NULL
);

insert into TBL_SEDE (NOMBRE_SEDE, UBICACION) values ('Sede Central', 'Avenida B');
insert into TBL_SEDE (NOMBRE_SEDE, UBICACION) values ('Sede Norte', 'Avenida B');
insert into TBL_SEDE (NOMBRE_SEDE, UBICACION) values ('Sede Sur', 'Calle 30');
insert into TBL_SEDE (NOMBRE_SEDE, UBICACION) values ('Sede Este', 'Carrera 10');


#CREACION DE FACULTADES
CREATE TABLE TBL_FACULTAD(
ID_FACULTAD INT AUTO_INCREMENT PRIMARY KEY,
COD_CARRERA INT NOT NULL,
NOMBRE_FACU VARCHAR(255) NOT NULL,
EDIFICIOS VARCHAR(255) NOT NULL,
ID_SEDE INT NOT NULL,
ID_JORNADA INT NOT NULL,
ID_CARRERA INT NOT NULL,
FOREIGN KEY (ID_SEDE) REFERENCES TBL_SEDE(ID_SEDE),
FOREIGN KEY (ID_JORNADA) REFERENCES TBL_JORNADA(ID_JORNADA),
FOREIGN KEY (ID_CARRERA) REFERENCES TBL_CARRERA (ID_CARRERA)
);
insert into TBL_FACULTAD (COD_CARRERA, NOMBRE_FACU, EDIFICIOS, ID_SEDE, ID_CARRERA, ID_JORNADA) values (7, 'Facultad de Ciencias', 'torre', 1, 1, 1);
insert into TBL_FACULTAD (COD_CARRERA, NOMBRE_FACU, EDIFICIOS, ID_SEDE, ID_CARRERA, ID_JORNADA) values (4, 'Facultad de Ciencias', 'bloque', 2, 2, 2);
insert into TBL_FACULTAD (COD_CARRERA, NOMBRE_FACU, EDIFICIOS, ID_SEDE, ID_CARRERA, ID_JORNADA) values (65, 'Facultad de Ciencias', 'piso', 3, 3, 3);
insert into TBL_FACULTAD (COD_CARRERA, NOMBRE_FACU, EDIFICIOS, ID_SEDE, ID_CARRERA, ID_JORNADA) values (60, 'Facultad de Ingeniería', 'escalera', 4, 4, 4);

#CREACION DE CURSOS
CREATE TABLE TBL_CURSOS(
ID_CURSOS INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_C VARCHAR(255) NOT NULL,
HORARIO DATETIME NOT NULL,
REQUISITOS VARCHAR(255) NOT NULL,	
CREDITOS INT NOT NULL,
SALON VARCHAR(255) NOT NULL,
SECCION VARCHAR(255) NOT NULL,
LABORATORIO VARCHAR(255) NOT NULL,
ID_FACULTAD INT NOT NULL,
FOREIGN KEY (ID_FACULTAD) REFERENCES TBL_FACULTAD(ID_FACULTAD)
);
SELECT * FROM TBL_CURSOS;
ALTER TABLE TBL_CURSOS ADD COLUMN ID_SEMESTRE INT NOT NULL;
ALTER TABLE TBL_CURSOS DROP COLUMN NO_SEMESTRE;
ALTER TABLE TBL_CURSOS ADD CONSTRAINT FK_CURSO FOREIGN KEY (ID_SEMESTRE) REFERENCES TBL_SEMESTRE (ID_SEMESTRE);
DELETE FROM TBL_CURSOS;
insert into TBL_CURSOS (NOMBRE_C, HORARIO, REQUISITOS, CREDITOS, SALON, SECCION, LABORATORIO, ID_FACULTAD, ID_SEMESTRE) values ('Matemáticas', '2005-04-15 8:05', 'Calculo', 20, 'Salón 102', 'A', 'no', 1, 5);
insert into TBL_CURSOS (NOMBRE_C, HORARIO, REQUISITOS, CREDITOS, SALON, SECCION, LABORATORIO, ID_FACULTAD, ID_SEMESTRE) values ('Matemáticas', '2005-04-16 10:26', 'Geografia', 80, 'Salón 104', 'C', 'no', 2, 6);
insert into TBL_CURSOS (NOMBRE_C, HORARIO, REQUISITOS, CREDITOS, SALON, SECCION, LABORATORIO, ID_FACULTAD, ID_SEMESTRE) values ('Matemáticas', '2005-04-19 8:24', 'Ciencias Naturales', 97, 'Salón 102', 'A', 'no', 3, 7);
insert into TBL_CURSOS (NOMBRE_C, HORARIO, REQUISITOS, CREDITOS, SALON, SECCION, LABORATORIO, ID_FACULTAD, ID_SEMESTRE) values ('Matemáticas', '2005-04-20 7:50', 'Ingles basico', 5, 'Salón 105', 'D', 'no', 4, 8);
select *from TBL_CURSOS;
select *from TBL_SEMESTRE;
select *from TBL_CARRERA;
select *from TBL_USUARIOS;
select *from TBL_FACULTAD;
select *from TBL_ESTUDIANTE;
select *from TBL_BOLETA;

#CREACION DE CATEDRATICOS
CREATE TABLE TBL_CATEDRATICO(
ID_CATEDRATICO INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE VARCHAR(255) NOT NULL,
APELLIDO VARCHAR(255) NOT NULL,
FECHA_NAC DATE NOT NULL,
CARNE INT NOT NULL UNIQUE,
CORREO_ELECTRONICO VARCHAR(255) NOT NULL UNIQUE,
TELEFONO INT NOT NULL UNIQUE,
ID_CURSOS INT,
ID_CARRERA INT,
FOREIGN KEY (ID_CURSOS) REFERENCES TBL_CURSOS(ID_CURSOS),
FOREIGN KEY (ID_CARRERA) REFERENCES TBL_CARRERA(ID_CARRERA)
);


#CREACION DE SEMESTRES
CREATE TABLE TBL_SEMESTRE(
ID_SEMESTRE INT AUTO_INCREMENT PRIMARY KEY,
CALENDARIO DATE NOT NULL, -- se dejo como date porque no es necesario el tiempo para este campo
NO_SEMESTRE INT NOT NULL
);
ALTER TABLE TBL_SEMESTRE DROP FOREIGN KEY tbl_semestre_ibfk_1;
select *from TBL_SEMESTRE;
select *
ALTER TABLE TBL_SEMESTRE DROP COLUMN ID_CURSOS
from information_schema.table_constraints
where constraint_schema = 'asignacion';
DELETE FROM TBL_SEMESTRE WHERE ID_CURSOS;
 
DELETE FROM TBL_SEMESTRE;
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-2-9', 8);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-9-9', 8);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-11-22', 7);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-11-08', 4);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-2-9', 8);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-9-9', 8);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-11-22', 7);
insert into TBL_SEMESTRE (CALENDARIO, NO_SEMESTRE) values ('2023-11-08', 4);


#CREACION DE ESTUDIANTE
CREATE TABLE TBL_ESTUDIANTE (
ID_ESTUDIANTE INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
FECHA_NAC DATE NOT NULL,
CARNE VARCHAR(255) NOT NULL UNIQUE,
CREDITOS_ACUMULADOS INT NOT NULL,
ID_CARRERA INT,
ID_CURSOS INT,
SECCION VARCHAR(10) NOT NULL,
FOREIGN KEY (ID_CARRERA) REFERENCES TBL_CARRERA(ID_CARRERA),
FOREIGN KEY (ID_CURSOS) REFERENCES TBL_CURSOS(ID_CURSOS)
);

#CREACION DE TESORERIA
CREATE TABLE TBL_TESORERIA(
ID_TESORERIA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_PAGO VARCHAR(255) NOT NULL,
MONTO DECIMAL(8,2) NOT NULL,
FECHA_PAGO TIMESTAMP DEFAULT NOW(), -- creamos este comando para que registre la hora y fecha de cuando se hace el pago
ID_ESTUDIANTE INT NOT NULL,
FOREIGN KEY (ID_ESTUDIANTE) REFERENCES TBL_ESTUDIANTE(ID_ESTUDIANTE)
);

#CREACION DE USUARIOS PARA LA APLICACION
CREATE TABLE TBL_USUARIOS(
ID_USUARIO INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_USUARIO VARCHAR(255) NOT NULL,
CONTRASEÑA VARCHAR(255) NOT NULL,
CORREO_ELECTRONICO VARCHAR(255) NOT NULL UNIQUE,
TIPO_USUARIO ENUM('ESTUDIANTE', 'CATEDRATICO', 'ADMINISTRADOR') NOT NULL, -- se dejo estos 3 roles para nosotros
FECHA_CREACION TIMESTAMP DEFAULT NOW(), -- se puso este campo para tener registro de los usuarios
ID_CATEDRATICO INT, 
CARNE VARCHAR(255), 
FOREIGN KEY (ID_CATEDRATICO) REFERENCES TBL_CATEDRATICO (ID_CATEDRATICO),
FOREIGN KEY (CARNE) REFERENCES TBL_ESTUDIANTE (CARNE) -- hace referencia a estudiantes y catedraticos
);
select *from TBL_ESTUDIANTE WHERE ID_ESTUDIANTE;
-- Contraseña: 123
INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO)
VALUES
('admin1', '08A0390A303A03308F0F405A00B03E0DD01306606107F0C20B502A0BB0410D80270440AB08407708009C05C0E50280FE', 'administrador1@umg.com', 'ADMINISTRADOR');
select *from TBL_USUARIOS;

#CREACION DE BOLETAS PARA LA INFORMACION DE PAGO
CREATE TABLE TBL_BOLETA(
ID_BOLETA INT PRIMARY KEY,
NOMBRE_PAGO VARCHAR(255),
MONTO DECIMAL(8,2),
FECHA_REALIZADA TIMESTAMP DEFAULT NOW(),
CARNE VARCHAR(255),
NOMBRE_ESTUDIANTE VARCHAR(255),
APELLIDO_ESTUDIANTE VARCHAR(255),
CODIGO_CARRERA VARCHAR(255),
ID_FACULTAD INT,
ID_TESORERIA INT,
ID_SEMESTRE INT,
FOREIGN KEY (CARNE) REFERENCES TBL_ESTUDIANTE(CARNE),
FOREIGN KEY (CODIGO_CARRERA) REFERENCES TBL_CARRERA(CODIGO_CARRERA),
FOREIGN KEY (ID_FACULTAD) REFERENCES TBL_FACULTAD(ID_FACULTAD),
FOREIGN KEY (ID_TESORERIA) REFERENCES TBL_TESORERIA(ID_TESORERIA),
FOREIGN KEY (ID_SEMESTRE) REFERENCES TBL_SEMESTRE(ID_SEMESTRE)
);
SELECT *FROM TBL_BOLETA;
DROP TABLE TBL_BOLETA;