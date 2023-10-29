/*Llamando la clase Superheroe*/
SuperHeroe superHeroe1 = new SuperHeroe();
superHeroe1.nombre = "Doctor Strange";
superHeroe1.identidadsecreta = "Stephen Vincent Strang";
superHeroe1.ciudad = "Nueva York";
superHeroe1.superpoder.nombre = "Control de la magia";
superHeroe1.superpoder.descripcion = "Teletransportación, generación de ilusiones, proyección de energía";
superHeroe1.superpoder.nivel = 10;
/*-----------------------------------------------------------------------------------*/
SuperHeroe superHeroe2 = new SuperHeroe();
superHeroe2.nombre = "Capitana Marvel";
superHeroe2.identidadsecreta = "Carol Danvers";
superHeroe2.ciudad = "Boston";
superHeroe2.superpoder.nombre = "Fuerza y resistencia sobrehumana";
superHeroe2.superpoder.descripcion = "Gran durabilidad física, " +
    " su resistencia a la mayoría de las toxinas y venenos";
superHeroe2.superpoder.nivel = 10;
/*-----------------------------------------------------------------------------------*/
SuperHeroe superHeroe3 = new SuperHeroe();
superHeroe3.nombre = "Shazam";
superHeroe3.identidadsecreta = "Billy Batson";
superHeroe3.ciudad = "Minnesota";
superHeroe3.superpoder.nombre = "Tiene un control ilimitado sobre el rayo";
superHeroe3.superpoder.descripcion = "Puede proyectarlo, manipularlo y utilizarlo de cualquier forma que se le ocurra";
superHeroe3.superpoder.nivel = 9;

/* Imprensión de los datos */
    Console.WriteLine($"Super Heroe :"+ "   " + superHeroe1.nombre);
    Console.WriteLine($"Identidad Secreta :" + "   " + superHeroe1.identidadsecreta);
    Console.WriteLine($"Ciudad :"+ "   " + superHeroe1.ciudad);
    Console.WriteLine($"¿Puede Volar? :"+ "   " + superHeroe1.puedevolar);
    Console.WriteLine($"Super Poder :"+ "   " + superHeroe1.superpoder.nombre);
    Console.WriteLine($"Descripción del poder :"+ "   " + superHeroe1.superpoder.descripcion);
    Console.WriteLine($"Nivel :"+ "   " + superHeroe1.superpoder.nivel);
    Console.WriteLine("---------------------------------------------------------------------------------------------");
    Console.WriteLine($"Super Heroe :" + "   " + superHeroe2.nombre);
    Console.WriteLine($"Identidad Secreta :" + "   " + superHeroe2.identidadsecreta);
    Console.WriteLine($"Ciudad :" + "   " + superHeroe2.ciudad);
    Console.WriteLine($"¿Puede Volar? :" + "   " + superHeroe2.puedevolar);
    Console.WriteLine($"Super Poder :" + "   " + superHeroe2.superpoder.nombre);
    Console.WriteLine($"Descripción del poder :" + "   " + superHeroe2.superpoder.descripcion);
    Console.WriteLine($"Nivel :" + "   " + superHeroe2.superpoder.nivel);
    Console.WriteLine("---------------------------------------------------------------------------------------------");
    Console.WriteLine($"Super Heroe :" + "   " + superHeroe3.nombre);
    Console.WriteLine($"Identidad Secreta :" + "   " + superHeroe3.identidadsecreta);
    Console.WriteLine($"Ciudad :" + "   " + superHeroe3.ciudad);
    Console.WriteLine($"¿Puede Volar? :" + "   " + superHeroe3.puedevolar);
    Console.WriteLine($"Super Poder :" + "   " + superHeroe3.superpoder.nombre);
    Console.WriteLine($"Descripción del poder :" + "   " + superHeroe3.superpoder.descripcion);
    Console.WriteLine($"Nivel :" + "   " + superHeroe3.superpoder.nivel);




/*
 Clase Super heroe 
 */
public class SuperHeroe
{
    public string  nombre {get; set;}
    public string   identidadsecreta {get; set;}
    public string  ciudad {get; set;}
    public bool puedevolar   {get; set;}

    public Superpoder superpoder { get; set;}

    /*
     * El constructor de la clase Super heroe
     */
    public SuperHeroe()
    {
        puedevolar = true;
        superpoder = new Superpoder();
    }
};

public class Superpoder
{
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public int? nivel { get; set; }
};



