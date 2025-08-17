using System;
namespace Programa;

class ProgramaTp{
    static void Main(){

        int opcionUsuario = 0;
        bool hayVueltas = false;
        int cantidadVueltas = 0;
        int intentos = 0;
        double tiempoS1 = 0;
        double tiempoS2 = 0;
        double tiempoS3 = 0;
        double tiempoTotal = 0;
        double penalizacion = 0;
        double mejorVuelta = double.MaxValue;
        Random random = new Random();
        double acumuladorPenalizaciones= 0;
        double acumuladorSector1= 0;
        double acumuladorSector2= 0;
        double acumuladorSector3= 0;
        double acumuladorTiempodeVueltas=0;
        double promedioS1 = 0;
        double promedioS2 = 0;
        double promedioS3 = 0;
        double promedioTiempoTotal = 0;
        double promedioPenalizaciones = 0;
        string dniCorrecto = null ;
        string contraseñaCorrecta = null ;
        string usuario = null ;
        bool sesionIniciada = false;                 


            
        Console.WriteLine("Bienvenid@ al programa de simulación de F1");   
        Console.WriteLine("Elija una opción");   
        
        

        do {

            
            Console.WriteLine ("Selccione la opción 1 para simular vueltas ");
            Console.WriteLine ("Selccione la opción 2 para mostrar reporte ");
            Console.WriteLine ("Selccione la opción 3 para iniciar sesion");
            Console.WriteLine ("Selccione la opción 4 para cerrar sesion");
            Console.WriteLine ("Selccione la opción 5 registrar usuario");
            Console.WriteLine ("Selccione la opción 6 para salir");
            if (sesionIniciada==true) {
                Console.WriteLine ("Tenés tu sesion iniciada como: "+usuario);
            }
            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            switch (opcionUsuario){
            
            case 1:            
            
                Console.WriteLine("A continuación, por favor seleccione la cantidad de vueltas que desea simular:");
                cantidadVueltas = int.Parse(Console.ReadLine());
                hayVueltas=true;
                //ingreso de cantidad de vueltas por parte del usuario            

                while (cantidadVueltas > 0 && cantidadVueltas > intentos)
                {
                    for (int i = 0; i < cantidadVueltas; i++)
                    {
                        intentos++;
                        tiempoS1 = (random.Next(20,41));
                        acumuladorSector1+= tiempoS1;
                        tiempoS2 = (random.Next(20,41));
                        acumuladorSector2+= tiempoS2;
                        tiempoS3 = (random.Next(20,41));
                        acumuladorSector3+= tiempoS3;
                        penalizacion = 5 - (random.NextDouble()* 5);
                        acumuladorPenalizaciones+=penalizacion;
                        tiempoTotal = (tiempoS1 + tiempoS2 + tiempoS3 + penalizacion);
                        acumuladorTiempodeVueltas+=tiempoTotal;
                        Console.WriteLine("En la vuelta número " + intentos + " el tiempo total fue de " + tiempoTotal.ToString("F3"));

                        if (tiempoTotal < mejorVuelta) {                        
                            mejorVuelta=tiempoTotal;
                            Console.WriteLine("la mejor vuelta hasta ahora es: "+mejorVuelta);

                            if (intentos > 1)
                            {
                                Console.WriteLine("Esta fue la mejor vuelta hasta el momento con un tiempo de " + tiempoTotal.ToString("F3"));
                            }
                        }
                    
                        promedioS1 = acumuladorSector1 / cantidadVueltas;
                        promedioS2 = acumuladorSector2 / cantidadVueltas;
                        promedioS3 = acumuladorSector3 / cantidadVueltas;
                        promedioTiempoTotal = acumuladorTiempodeVueltas / cantidadVueltas;
                        promedioPenalizaciones = acumuladorPenalizaciones/cantidadVueltas;          
           
                    }//Aca termina el ciclo FOR      
                } //Aca termina el ciclo while                 
                break;


            case 2: 
                if (hayVueltas==true){
                    Console.WriteLine("¡REPORTE!");
                    Console.WriteLine("Tiempo promedio Sector 1: " + promedioS1 + "s" + "\n" +
                    "Tiempo promedio Sector 2: " + promedioS2 + "s" + "\n" +
                    "Tiempo promedio Sector 3: " + promedioS3 + "s" + "\n" + 
                    "Tiempo promedio total de vueltas: " + promedioTiempoTotal + "s" + "\n" + 
                    "Cantidad de penalizaciones: " + acumuladorPenalizaciones + "\n" + 
                    "Tiempo promedio de penalizaciones: " + promedioPenalizaciones + "s" + "\n" + 
                    "Mejor vuelta registrada: " + mejorVuelta + "s");  
                } else {
                    Console.WriteLine ("Nada que reportar");
                }

                break;

            case 3:
                int intentosDeinicioSesion = 3; 
                if (sesionIniciada==false) {
                    for (int i = 3; i > 0; i--) {
                        intentosDeinicioSesion--;    
                        Console.WriteLine("Ingrese su dni");
                        string dniIngresadoUsuario = Console.ReadLine();

                        Console.WriteLine("Ingrese su contraseña");
                        string contraseñaIngresadaUsuario = Console.ReadLine();

                        if (dniIngresadoUsuario == dniCorrecto && contraseñaIngresadaUsuario == contraseñaCorrecta) {
                            sesionIniciada = true;
                            Console.WriteLine("Sesión iniciada correctamente");
                            Console.WriteLine("Hola: "+ usuario);
                            break;
                            }
                        else {
                            Console.WriteLine("ERROR!! DNI Y/O CONTRASEÑA INCORRECTA");                    
                            }

                        if (intentosDeinicioSesion == 0) //intentos igual a cero para que en el intento 0 se acabe
                            {
                                Console.WriteLine("Haz superado el máximo de intentos");
                            }
                    }

                } else {
                    Console.WriteLine("Sesión ya iniciada");
                    Console.WriteLine("Bienvenido: "+ usuario);
                    }
                break;

            case 4:
                
                contraseñaCorrecta = null;
                usuario = null;
                sesionIniciada = false;
                Console.WriteLine("Datos de sesion borrados correctamente");            

                break;

            case 5:
                bool control=false;
            
                if (control==false){
            
                    Console.WriteLine("Ingrese su DNI de 8 caracteres");
                    string intentoDni = Console.ReadLine();
                    bool validacionDNI = ValidarDni(intentoDni);

                    if (validacionDNI==true) {
                        dniCorrecto = intentoDni;
                        control =true;
                        } else {
                        Console.WriteLine ("Los DNI Formato de DNI incorrecto");
                        Console.WriteLine ("Los datos no pudieron validarse correctamente");                
                        break;
                        }     

                }

                if (control==true) {
                    Console.WriteLine("Ingrese su Contraseña debe tener 3 numeros, 1 mayuscula 1 minuscula y tener exacamente 8 caracteres");    
                    string intentoContrasena = Console.ReadLine();
                    bool validacionContrsena = ValidarContraseña(intentoContrasena);

                    if (validacionContrsena==true) {
                        contraseñaCorrecta = intentoContrasena;
                        Console.WriteLine ("La contraseña pudo validarse correctamente");
                        Console.WriteLine ("Ingrese ahora su nombre de usuario para registrarse");
                        usuario = Console.ReadLine();
                        Console.WriteLine ("Usuario Registrado " + usuario);
                        Console.WriteLine("Ya puede iniciar sesión");
                    }else {
                    Console.WriteLine ("La contraseña no pudo validarse correctamente");
                    control =false;
                    break;
                    }

                }          

                break;
            

            case 6:
                opcionUsuario=6;
            
                break;

        }

        } while (opcionUsuario!=6);

        Console.Write("Gracias por utilizar nuestro simulador de vueltas");         
        



    //Final de funcion Main ↓
    }


    static bool ValidarContraseña(string contraseña) //Funcion que valida los requisitos de la contraseña y devuelve true o false
    {
        if (contraseña == null) return false; 
        if (contraseña == "") return false;
        if (contraseña.Length != 8) return false;

        //Variables
        int numeros = 0;
        bool hayMayus = false;
        bool hayMinus = false;

        foreach (char c in contraseña)
        {
            if (char.IsDigit(c))numeros++; //Revisa que si haya caracteres numericoss
            if (char.IsUpper(c))hayMayus= true ; //Revisa que haya mayúsuculas
            if (char.IsLower(c)) hayMinus= true ; //Lo mismo pero con minúsculas
        }
        return numeros >= 3 && hayMayus && hayMinus; //Valida todo
    }

    static bool ValidarDni(string dni)//Funcion que valida el DNI
    {
        if (dni == null) return false; //        

        if (dni.Length != 8) return false;

        foreach(char c in dni)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }
} //Final de Class ProgramaTP
