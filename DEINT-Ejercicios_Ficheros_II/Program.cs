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

    //Ejercicio 4

    Console.WriteLine("EJERCICIO 4");

    Console.WriteLine("Introduzca ruta de algún direcctorio:");
    String ruta = Console.ReadLine();

    bool existe = Directory.Exists(ruta);

    if (existe)
    {

        Console.WriteLine("Introduzca extensión:");
        String extension = Console.ReadLine();
        var ficheros = Directory.EnumerateFiles(ruta, $"*{extension}", SearchOption.AllDirectories);

        Console.WriteLine($"Quieres borrar los ficheros con la extension {extension} (Si - 1, No - 0) \nFicheros afectados: {ficheros.Count()}");

        if (Console.ReadLine().Equals("1"))
        {
            foreach (String elem in ficheros)
            {
                File.Delete(elem);
            }

            Console.WriteLine("Archivos restantes:");
            String[] fich = Directory.GetFiles(ruta);

            foreach (var path in fich)
            {
                Console.WriteLine(path);
            }

        }
        else {
            Console.WriteLine("Acción de borrado cancelada");
        }

    }
    else
    {
        Console.WriteLine("El direcctorio no existe");
    }

}

void ejercicio5() {

    //Ejercicio 5

    Console.WriteLine("EJERCICIO 5");

    Console.WriteLine("Introduzca ruta de algún fichero:");
    String ruta = Console.ReadLine();

    if (File.Exists(ruta))
    {

        Console.WriteLine($"Introduzca la nueva extensión para el fichero {Path.GetFileName(ruta)}:");
        String extension = Console.ReadLine();

        File.Move(ruta, Path.Combine(ruta, ruta.Replace(Path.GetExtension(ruta), extension)));

    }
    else {
        Console.WriteLine("El fichero no existe");
    }

}

//ejercicio1();

//ejercicio2();

//ejercicio3();

//ejercicio4();

//ejercicio5();
