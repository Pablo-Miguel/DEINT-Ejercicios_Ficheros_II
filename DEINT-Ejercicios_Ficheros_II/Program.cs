// See https://aka.ms/new-console-template for more information

void ejercicio1() {

    //Ejercicio 1

    Console.WriteLine("EJERCICIO 1");

    Console.WriteLine("Introduzca ruta de algún direcctorio:");
    String ruta = Console.ReadLine();
    bool existe = Directory.Exists(ruta);

    if (existe) {
        if (Directory.EnumerateFiles(ruta).Count() == 0)
        {
            Console.WriteLine("El direcctorio no tiene ficheros dentro");
        }
        else {
            DateTime date = DateTime.MinValue;
            String rutaNueva = "";
            foreach (String fich in Directory.GetFiles(ruta)) {
                
                if (File.GetLastAccessTime(fich) > date) { 
                    rutaNueva = fich;
                }
            }
            Console.WriteLine(File.ReadAllText(rutaNueva));
        }
    }
    else {
        Console.WriteLine("El direcctorio no existe");
    }

}

void ejercicio2() {

    //Ejercicio 2

    Console.WriteLine("EJERCICIO 2");

    Console.WriteLine("Introduzca ruta de algún direcctorio:");
    String ruta = Console.ReadLine();

    bool existe = Directory.Exists(ruta);

    if (existe)
    {
        if (Directory.EnumerateFiles(ruta).Count() == 0)
        {
            Console.WriteLine("El direcctorio no tiene ficheros dentro");
        }
        else
        {
            Console.WriteLine("Introduzca extensión:");
            String extension = Console.ReadLine();
            var ficheros = Directory.EnumerateFiles(ruta, $"*{extension}", SearchOption.AllDirectories);

            foreach (var arch in ficheros)
            {
                Console.WriteLine(File.ReadAllText(arch));
            }

        }
    }
    else
    {
        Console.WriteLine("El direcctorio no existe");
    }

}

void ejercicio3()
{

    //Ejercicio 3

    Console.WriteLine("EJERCICIO 3");

    Console.WriteLine("Introduzca ruta de algún direcctorio:");
    String ruta = Console.ReadLine();

    bool existe = Directory.Exists(ruta);

    if (existe)
    {
        Console.WriteLine("Introduzca nombre para un subdirecctorio");
        String nombre = Console.ReadLine();
        Directory.CreateDirectory(Path.Combine(ruta, nombre));
        String subRuta = Path.Combine(ruta, nombre);
        Console.WriteLine("Introduzca extensión:");
        String extension = Console.ReadLine();
        var ficheros = Directory.EnumerateFiles(ruta, $"*{extension}", SearchOption.AllDirectories);

        foreach (var arch in ficheros)
        {
            try {
                File.Copy(arch, Path.Combine(subRuta, Path.GetFileName(arch)));
            }
            catch (Exception ex) { 
            
            }
        }

    }
    else
    {
        Console.WriteLine("El direcctorio no existe");
    }

}

void ejercicio4()
{

    //Ejercicio 4 C:\Users\Dam\Desktop\prueba

    Console.WriteLine("EJERCICIO 3");

    Console.WriteLine("Introduzca ruta de algún direcctorio:");
    String ruta = Console.ReadLine();

    bool existe = Directory.Exists(ruta);

    if (existe)
    {
        


    }
    else
    {
        Console.WriteLine("El direcctorio no existe");
    }

}

//ejercicio1();

//ejercicio2();

//ejercicio3();

ejercicio4();
