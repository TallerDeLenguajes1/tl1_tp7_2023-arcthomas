using espacioEmpleado;

Cargos cargo1 = Cargos.Auxiliar;
DateTime fechaNac = new DateTime(2003, 4, 11);
DateTime fechaIng = new DateTime(2023, 6, 1);
Empleado empleado1 = new Empleado(cargo1, "José", "Ramirez", fechaNac, 'C', 'M', fechaIng);
Console.WriteLine(fechaNac);
empleado1.Antiguedad();
empleado1.Edad();
empleado1.CalcTmpJubilacion();