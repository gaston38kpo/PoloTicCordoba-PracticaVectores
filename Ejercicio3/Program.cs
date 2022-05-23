//////////////////////////////////
//      CLASE 7 - TAREA 3       //
// ALUMNO:  GIACOBINI GASTON    //
// FECHA:   18/05/2022          //
//////////////////////////////////

Console.Title = "PoloTic Cordoba - Tarea 3 - GIACOBINI GASTÓN 2022 - v1.0";
Console.WindowHeight = 35;
Console.WindowWidth = 125;

int MATRIX_SIZE = 10;
double[] userNumbers = new double[MATRIX_SIZE];

double totalAccumulated = 0;
double biggestNumber = 0;
double smallestNumber = 0;


for (int index = 0; index <= userNumbers.Length; index++)
{

    Console.Clear();

    // Al finalizar el bucle cambia su color el dibujo ascii
    if (index < userNumbers.Length) Console.ForegroundColor = ConsoleColor.DarkCyan;
    else Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($@"            ████    ████████                    
          ██▓▓▓▓████▓▓▓▓▓▓▓▓██                  
          ██▓▓▓▓▓▓▓▓██████▓▓▓▓██      ▒▒▒▒      
          ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████  ▒▒▓▓▒▒▒▒    
    ▒▒▓▓▒▒██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██  ▒▒▓▓▓▓▒▒  
    ▒▒▓▓▒▒██░░░░░░░░            ██    ▒▒  ▓▓▓▓▒▒
    ▒▒▓▓▒▒██░░  ░░    ▓▓▓▓  ▓▓  ██    ▒▒    ▓▓▒▒
      ▓▓  ██░░  ░░  ▓▓    ▓▓  ▓▓██    ▒▒    ▓▓▒▒
    ████████░░      ▓▓    ▓▓  ▓▓██    ▒▒    ▓▓▒▒
    ██▒▒▒▒▒▒██        ▓▓▓▓  ▓▓  ██    ▒▒  ▓▓▒▒           ░      
    ██▒▒██████      ░░░░░░░░░░  ██    ▒▒  ██▒▒    ░
    ████▓▓▓▓▓▓██      ██████  ████████▒▒██▓▓██                  ░░
    ██    ▓▓▓▓▓▓██    ░░░░░░██▓▓  ▓▓  ▒▒▓▓██▓▓██          ░░ 
    ██▓▓    ▓▓▓▓▓▓████░░░░░░▓▓▓▓  ▓▓▓▓▒▒▓▓██▓▓██                   ░
  ██    ▓▓  ██▓▓▓▓▒▒▒▒▒▒░░▓▓▓▓    ▓▓  ▒▒▓▓██▓▓██ {string.Join("░", userNumbers)} ▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▓█
  ██▓▓▓▓██████▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓████████▒▒██████  
  ██▓▓    ████▓▓▓▓▓▓▓▓▒▒▓▓▓▓██        ▒▒  ▓▓▒▒          ░         ░░
  ██▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██        ▒▒  ▓▓▒▒       ░░      ░░
    ██████  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒██        ▒▒    ▓▓▒▒  ░
          ██▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒██      ▒▒    ▓▓▒▒
        ██▒▒▒▒▒▒▓▓▓▓██▓▓▓▓▒▒▒▒▒▒██    ▒▒    ▓▓▒▒
      ████▒▒▒▒▒▒▒▒██  ██▒▒▒▒▒▒▒▒████  ▒▒▓▓▓▓▒▒  
  ████▓▓▓▓▓▓▓▓▓▓██      ██▓▓▓▓▓▓▓▓▓▓████▒▒▒▒    
██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██      ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██      
██████████████████      ██████████████████     
");

    // Condicion para que el for haga una vuelta mas para actualizar la interfaz y evitar el overflow de la matriz en la ultima vuelta
    if (index < userNumbers.Length)
    {

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"\t\tPor favor ingrese {MATRIX_SIZE} numeros ({index + 1}/{MATRIX_SIZE}): ");

        double userNumber = double.Parse(Console.ReadLine());
        userNumbers[index] = userNumber;

        // En la primer vuelta inicializo ambos con el primer valor obtenido para luego comparar
        if (index != 0)
        {
            biggestNumber = (userNumbers[index] > biggestNumber) ? userNumbers[index] : biggestNumber;
            smallestNumber = (userNumbers[index] < smallestNumber) ? userNumbers[index] : smallestNumber;
        }
        else
            biggestNumber = smallestNumber = userNumber;


        totalAccumulated += userNumbers[index];

    }
}

Console.ForegroundColor = ConsoleColor.DarkGray;
foreach (char c in "\t\t\tPresione cualquier tecla para ir a los resultados...")
{
    Console.Write(c);
    Thread.Sleep(30);
}
Console.ReadKey();


// INTERFAZ CON LOS RESULTADOS.

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(
    @"                                          ██████              
            ██▒▒██    ████████████████▓▓████▒▒████                  
          ████▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████▒▒██                  
        ██▓▓████▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒████");

// ----------------------- RESULTADO 1 ------------------------------- //
// --------------- MOSTRAR LOS NUMEROS INGRESADOS -------------------- //
Console.Write("            Numeros: ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine($"{{{string.Join(", ", userNumbers)}}}");
// ------------------------------------------------------------------- //


Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(
    @"      ██▓▓▒▒▒▒████▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒██
      ██▒▒▒▒▒▒██▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒██              
    ██▓▓▒▒▒▒██▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████");

// ----------------------- RESULTADO 2 ------------------------------- //
// ------------------ SUMAR TODOS LOS NUMEROS ------------------------ //
Console.Write("          Valor Sumados: ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(totalAccumulated);
// ------------------------------------------------------------------- //


Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(@"    ██▓▓▒▒▒▒▓▓▓▓▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒██              
  ██▓▓▒▒▒▒▒▒██▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒      ▒▒▒▒▒▒██      
  ██▓▓▒▒▒▒▒▒██▒▒▒▒▒▒▓▓▒▒    ░░▒▒░░  ▒▒  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒██");

// ----------------------- RESULTADO 3 ------------------------------- //
// ----------------------- MAYOR NUMERO ------------------------------ //
Console.Write("        Mayor Número: ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(biggestNumber);
// ------------------------------------------------------------------- //


Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(@"  ██▓▓▒▒▒▒▒▒██▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓  ▓▓▓▓▒▒▒▒▓▓▒▒▒▒██      
  ██▓▓▒▒▒▒▒▒██▒▒▒▒██▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒    ░░▓▓▒▒▒▒▒▒▓▓▒▒██            
  ██▓▓▒▒▒▒▒▒██▒▒▒▒██▒▒▒▒▒▒▓▓    ▒▒▓▓        ▒▒▒▒▒▒██▒▒██");

// ----------------------- RESULTADO 4 ------------------------------- //
// ----------------------- MENOR NUMERO ------------------------------ //
Console.Write("        Menor Número: ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(smallestNumber);
// ------------------------------------------------------------------- //


Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(@"  ██▓▓▒▒▒▒▒▒██▒▒████▒▒▒▒▒▒      ▓▓    ▒▒████▓▓▒▒▒▒████              
  ██▓▓▒▒▒▒▒▒██▒▒████▓▓▓▓██████  ▓▓      ▓▓░░▓▓▒▒▒▒██          
  ██▓▓▒▒▒▒▒▒████████▒▒  ░░  ▓▓        ▒▒▒▒  ▓▓▒▒██  ████  ████");

// ----------------------- RESULTADO 5 ------------------------------- //
// ------------------------ PROMEDIO --------------------------------- //
Console.Write("  Promedio: ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(totalAccumulated / userNumbers.Length);
// ------------------------------------------------------------------- //


Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(@"  ██▒▒▒▒▒▒▒▒████▒▒██▒▒    ▓▓▒▒        ▓▓▓▓  ▓▓▒▒████▒▒████▒▒██
  ██▒▒▒▒▒▒▒▒██  ████░░    ▓▓▒▒        ░░░░  ▓▓██▓▓██▒▒██▒▒▒▒██
  ██▒▒▒▒▒▒▒▒██    ██      ░░░░            ▓▓██▓▓▒▒██▒▒▒▒▒▒██  
  ██▒▒▒▒▒▒▒▒██      ████                ████▒▒▒▒▓▓██▒▒▒▒██    
  ██▒▒▒▒▒▒▒▒▒▒██        ██░░░░░░░░░░▓▓░░  ██▒▒▒▒██  ▒▒██      
  ██▒▒▒▒▒▒▒▒▓▓██      ██░░  ░░░░░░░░▒▒░░██▓▓████    ██        
  ██▒▒▒▒▒▒▒▒▓▓██    ██▓▓░░▓▓░░░░░░░░▒▒░░██████    ▓▓██        
  ██▒▒▒▒▒▒▒▒▒▒██  ████████▒▒▓▓░░░░▒▒██▒▒░░██    ██▒▒▓▓▓▓      
  ██▒▒▒▒▒▒▒▒▒▒▓▓██████████████▒▒▓▓██████▒▒██  ██▒▒▒▒▓▓██      
    ██▒▒▒▒▒▒▒▒▓▓████  ████████████████████▓▓▓▓▒▒▒▒▒▒▓▓██      
    ██▓▓▒▒▒▒▒▒▓▓██  ████▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓████▒▒▒▒▒▒▓▓██      
      ██▒▒▒▒▒▒▓▓██      ██████████████████    ██▓▓▓▓██        
        ██▓▓▓▓██        ██▓▓██      ██▓▓██      ████          
          ████            ████        ████                    
");

Console.ResetColor();
