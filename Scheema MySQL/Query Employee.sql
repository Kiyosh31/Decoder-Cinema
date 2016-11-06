#INSERT INTO employee(eName, ePassword, JobPosition_idJobPosition, active) VALUES() 

#SELECT * FROM employee

#SELECT * FROM employee WHERE idEmployee =

UPDATE employee SET active = true WHERE idEmployee = 1

#SELECT * FROM employee e INNER JOIN jobposition j ON e.JobPosition_idJobPosition = j.idJobPosition WHERE active = true

#SELECT idEmployee, eName, ePassword, Name FROM employee e INNER JOIN jobposition j ON e.JobPosition_idJobPosition = j.idJobPosition WHERE active = true

#UPDATE jobposition SET Name = 'Vendedor' Where idJobPosition = 2