using Entidades.Clase25;
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);

public delegate void LimiteSueldoMejoradorDel(Empleado sender, EmpleadoEventArgs e);
// siempre publica, se especifica que es un delegado, la firma del metodo puede ser cualquiera