create database EMPRESA_LAB_J_D

use EMPRESA_LAB_J_D

create table empleado(emp_no int not null constraint pk_emp_no primary key,
apellido varchar(40),
oficio varchar(40),
dir varchar(60),
fecha_alt varchar(100),
salario money,
comision decimal,
depto_no int
)
 
 drop table empleado

create table departamentos(dept_no int  not null,
dnombre varchar(50),
loc varchar(60)
)

select*from departamentos


drop table departamentos

 select*from departamentos

delete from departamentos

