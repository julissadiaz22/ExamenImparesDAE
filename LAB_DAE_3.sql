use LAB3_JD;

select*from departamentos;

select* from empleado;
SELECT MAX(Salario) AS SalarioMaximo FROM empleado
SELECT MIN(Salario) AS SalarioMaximo FROM empleado
CREATE VIEW SalariosMaxMin AS
SELECT MAX(Salario) AS SalarioMaximo, MIN(Salario) AS SalarioMinimo FROM Empleado;

SELECT * FROM Sal;

SELECT AVG(salario) AS SalarioMedio FROM empleado


SELECT dept_no, COUNT(*) AS CantidadEmpleados 
FROM empleado GROUP BY dept_no


delete from empleado

SELECT dept_no, COUNT(*) AS CantidadEmpleados, AVG(salario) AS SalarioPromedio FROM empleado GROUP BY dept_no

SELECT dept_no, COUNT(*) AS CantidadEmpleados, AVG(salario) AS SalarioPromedio FROM empleado GROUP BY dept_no

delete from empleado where dept_no=10

 