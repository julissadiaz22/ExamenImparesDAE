create database EMPRESA_JD

use EMPRESA_JD

create table EMPLEADO(emp_no int identity not null constraint pk_emp_no primary key,
apellido varchar(30),
oficio varchar(30),
dir varchar(60),
fecha_alt date,
salario money,
comision decimal,
depto_no int
)

drop table EMPLEADO;

create table DEPARTAMENTOS(depto_no int identity not null constraint pk_depto_no primary key,
dnombre varchar(50),
loc varchar(60)
)

 select*from DEPARTAMENTOS;




