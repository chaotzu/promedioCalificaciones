using System;

namespace promedioCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            string nombre; //nombre estudiante
            double c1 = 0, c2 = 0, c3 = 0; //calificaciones periodos
            bool tenemosDato = false;
            Console.WriteLine("Bienvenido, a continuación determinaremos si aprobaste o no el curso X");
            Console.WriteLine("Introduce tu nombre"); //Mostrar mensaje en consola
            nombre = Console.ReadLine(); //Asignar a nombre el valor escrito en consola por el usuario            
            while(!tenemosDato) //El codigo se repetirá hasta que tengamos un dato válido 
            {
                Console.WriteLine("Introduce la calificación del periodo 1");
                try{ //Try catch usado para manejar excepciones
                    c1 = double.Parse(Console.ReadLine()); //Convertimos a doble el valor introducido en consola, si falla la conversión se ira a catch
                    if(c1 >= 0 && c1 <= 10) //Si se convirtió correctamente pero el numero es negativo o mayor a 10 entonces no es valido
                        tenemosDato = true;
                    else{
                        throw new FormatException("Dato incorrecto"); //Creamos una exepción y se va a catch
                    }
                }catch(FormatException){
                    Console.WriteLine("Introduce un número entre 1 y 10");
                }
            }
            tenemosDato = false;
            //Repetir para cada calificación de cada periodo
            while(!tenemosDato) //El codigo se repetirá hasta que tengamos un dato válido 
            {
                Console.WriteLine("Introduce la calificación del periodo 2");
                try{ //Try catch usado para manejar excepciones
                    c2 = double.Parse(Console.ReadLine()); //Convertimos a doble el valor introducido en consola, si falla la conversión se ira a catch
                    if(c2 >= 0 && c2 <= 10) //Si se convirtió correctamente pero el numero es negativo o mayor a 10 entonces no es valido
                        tenemosDato = true;
                    else{
                        throw new FormatException("Dato incorrecto"); //Creamos una exepción y se va a catch
                    }
                }catch(FormatException){
                    Console.WriteLine("Introduce un número entre 1 y 10");
                }
            }
            tenemosDato = false;
            while(!tenemosDato) //El codigo se repetirá hasta que tengamos un dato válido 
            {
                Console.WriteLine("Introduce la calificación del periodo 3");
                try{ //Try catch usado para manejar excepciones
                    c3 = double.Parse(Console.ReadLine()); //Convertimos a doble el valor introducido en consola, si falla la conversión se ira a catch
                    if(c3 >= 0 && c3 <= 10) //Si se convirtió correctamente pero el numero es negativo o mayor a 10 entonces no es valido
                        tenemosDato = true;
                    else{
                        throw new FormatException("Dato incorrecto"); //Creamos una exepción y se va a catch
                    }
                }catch(FormatException){
                    Console.WriteLine("Introduce un número entre 1 y 10");
                }
            }
            double promedio = (c1 + c2 + c3) / 3; //sacar promedio
            if (promedio >= 6) //Si el promedio es mayor o igual a 6
                Console.WriteLine("Felicidades " + nombre + " has aprobado, tu promedio final es {0}", promedio); //mostrar en pantalla resultado
            else{
                Console.WriteLine("Lo siento " + nombre + " no has aprobado, tu promedio final es {0}", promedio);
            }

            Console.WriteLine("Pulsa cualquier tecla para salir"); 
            Console.ReadKey(); //Esperar pulsación de tecla para salir
            
        }
    }
}
