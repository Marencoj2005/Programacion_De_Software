Decimal calcular_nomina(String tipo, DateTime inicio)
{
    decimal salario = 0; 
    Decimal smlv = 1750905;
    decimal catedra1 = 60000;
    decimal catedra2 = 50000;
    decimal catedra3 = 40000;
    decimal catedra4 = 30000;
    DateTime date_now = DateTime.Now;
    decimal retencion_en_la_fuente = salario * 0.05m;

    if (tipo == "catedra")
    {
        /*aqui procedo a crear el mecanismo para calcular la nomina para los profesores
         de cátedra
        
        los profesores de catedra en este caso se asumirá que trabajan 4 horas
        mas adelante se puede hacer más modificaciones a este detalle
         */
       
        Console.WriteLine("Que tipo de cátedra es el usuario?");
        char tipo_catedra = char.Parse(Console.ReadLine());

        switch (tipo_catedra)
        {
            case '1':
                salario = catedra1 * 4; //salario bruto por 4 horas de trabajo
                salario = salario - retencion_en_la_fuente;
                break;
        }
        //fijemos un salario base 

    }
    if (tipo == "tiempo completo")
    {
        Console.WriteLine("Ingrese el salario base del usuario");
        decimal sal_base = decimal.Parse(Console.ReadLine());
        int año_antiguedad = date_now.Year - inicio.Year;
        if (año_antiguedad >= 10)
        {

            salario = (smlv * (10 / 100)) + sal_base; //el 10% del minimo mas el salario base
          
        }
        else if (año_antiguedad >= 5 && año_antiguedad < 10)
        {
            salario = (smlv * (5 / 100)) + sal_base; //el 10% del minimo mas el salario base
        }
        else if (año_antiguedad >= 3 && año_antiguedad < 5) { }
        {
            salario = (smlv * (3 / 100)) + sal_base; //el 10% del minimo mas el salario base

        }
    }
    Console.WriteLine("Salario Bruto: " + salario);
    decimal descuento_salud = (salario * 0.04m);
    decimal descuento_pension = salario * 0.0375m;
    salario = salario - descuento_salud - descuento_pension - retencion_en_la_fuente;
    Console.WriteLine("Se descontó:");
    Console.WriteLine("Descuento en salud: " + descuento_salud);
    Console.WriteLine("Descuento en pensión: " + descuento_pension);
    Console.WriteLine("retencion en la fuente: " + retencion_en_la_fuente);


    return salario;  
}


string nombre = "";
DateTime fecha_inicio = DateTime.MinValue;
int documento_identidad = 0;
decimal salario = 0;
string tipo_cargo = "";

bool bucle = true;
while (bucle)
{

    Console.WriteLine("===== SISTEMA DE NÓMINA ======");
    Console.WriteLine("===== NOTA ======");
    Console.WriteLine("En vispera que el programa aún no guarda datos de forma persistente, se mostrará el ultimo registro dado; \n si usted hace un nuevo registro" +
        "el anterior al ultimo será ELIMINADO");
    Console.WriteLine("Registrar [r]");
    Console.WriteLine("Mostrar [m]");
    Console.WriteLine("Salir [s]");
    char opcion = char.Parse(Console.ReadLine());

    if (opcion == 'r')
    {
        int count = 0;

        while (true)
        {
            Console.WriteLine("Ingrese el nombre y apellido");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el documento de identidad");
            documento_identidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de cargo");
            tipo_cargo = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de entrada");
            Console.WriteLine("Debe tener el formato 'aaaa-mm-dd'");
            string fecha = Console.ReadLine();

            fecha_inicio = DateTime.Parse(fecha);

            salario = calcular_nomina(tipo_cargo, fecha_inicio);

            count++;

            Console.WriteLine("Registro exitoso");
            Console.WriteLine("¿Desea ingresar otro usuario?");
            Console.WriteLine("Sí [oprima cualquier tecla]");
            Console.WriteLine("No [n]");

            char opcion2 = char.Parse(Console.ReadLine());

            if (opcion2 == 'n')
            {
                Console.Clear();
                Console.WriteLine("Cantidad de registros realizados: " + count);
                break;
            }
        }
    }
    else if (opcion == 'm')
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Fecha de inicio: " + fecha_inicio);
        Console.WriteLine("Tipo de cargo: " + tipo_cargo);
        Console.WriteLine("Documento de identidad: " + documento_identidad);
        Console.WriteLine("Salario: " + salario);
    }
    else if (opcion == 's')
    {
        bucle = false;
    }
    else
    {
        Console.WriteLine("¡Opción inválida!");
    }

}