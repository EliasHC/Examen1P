using System;

 class estudiante{

    public string nombre {set; get;}
    public string apellidos {set; get;}
    public string nombre_institucion {set;get;}
    public int cedula_identidad{set; get;}

    public void estudiante (string nombre, string apellidos, string nombre_institucion, int cedula_identidad)
    
    {

        
            this.nombre = nombre;
            this.apellidos=apellidos;
            this.nombre_institucion=nombre_institucion;
            this.cedula_identidad=cedula_identidad;

                Console.WriteLine("------------------------------");
                Console.WriteLine("nombre:"+nombre);
                Console.WriteLine("apellidos:" + apellido);
                Console.WriteLine("institucion es:"+ institucion);
                Console.WriteLine("La CI es:"+ cedula_identidad);
        }
}

 