//Ejercicios con Arrays de 1 Dimensión

// 1- Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.

using System;
Random random = new Random();
int[] array1 = new int[10];
for (int i = 0; i < 10; i++)
{
    array1[i] = random.Next(1, 100);
    
   
}
int mayor= array1[0];
int menor= array1[0];

foreach (int numero in array1)
{
    Console.WriteLine(numero);
}

foreach (int numero in array1)
{
    if (numero > mayor)
        mayor = numero;
    if (numero < menor)
        menor = numero;
}

Console.WriteLine($"Mayor: {mayor}");
Console.WriteLine($"Menor: {menor}");



// 2- Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.
    {
        string[] nombres = new string[8];
        int contador = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        foreach (string nombre in nombres)
        {
            if (!string.IsNullOrEmpty(nombre) && (nombre[0] == 'A' || nombre[0] == 'a'))
            {
                contador++;
            }
        }

        Console.WriteLine($"Cantidad de nombres que empiezan con 'A': {contador}");
    }




// 3- Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.
int[] array2 = new int[10];
for (int i = 0 ; i < 10 ; i++)
{
    Console.WriteLine($"ingrese numero {i + 1}");
    array2[i] =int.Parse(Console.ReadLine());

}
int positivos = 0;
int negativos = 0;
int ceros = 0;
foreach (int numeros in array2)
{
    if (numeros > 0)
        { positivos++; }
    else if (numeros < 0)
        { negativos++; }
    else 
          {  ceros++; }
}
Console.WriteLine($"La cantidad de numeros positivos es de {positivos}");
Console.WriteLine($"La cantidad de numeros negativos es de {negativos}");
Console.WriteLine($"La cantidad de numeros ceros es de {ceros}");



// 4- Crear un array con los días de la semana y mostrar solo los días laborales.
string[] array3 = new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

foreach (string str in array3)
{
    if (str != "Sábado" && str != "Domingo")
    {
        Console.WriteLine($"{str} : Día Laboral");
    }
}



// 5- Cargar un array de 5 números. Crear un segundo array con los mismos valores pero 
// Esta incompleto (preguntar)




// Ejercicios con Arrays de 2 Dimensiones (Matrices)

// 1- Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
int[,] matriz = new int[3, 3];
for (int i = 0; i < 3; i++) // filas
{
    for (int j = 0; j < 3; j++) // columnas
    {
        Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 3; i++) // Recorre las filas
{
    int sumaFila = 0;

    for (int j = 0; j < 3; j++) // Recorre las columnas de la fila
    {
        sumaFila += matriz[i, j]; //suma de las filas
    }

    Console.WriteLine($"La suma de la fila {i + 1} es: {sumaFila}");
}




// 2- Cargar una matriz de 3x3. Mostrar la fila con mayor suma.

{
   
    {
        int[,] matriz = new int[3, 3];

        
        for (int i = 0; i < 3; i++) // filas
        {
            for (int j = 0; j < 3; j++) // columnas
            {
                Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        int[] sumasFilas = new int[3];

        
        for (int i = 0; i < 3; i++) 
        {
            sumasFilas[i] = 0; 
            for (int j = 0; j < 3; j++) 
            {
                sumasFilas[i] += matriz[i, j]; //suma de las filas
            }
        }

        
        int filaMayorSuma = 0;
        for (int i = 1; i < 3; i++) 
        {
            if (sumasFilas[i] > sumasFilas[filaMayorSuma])
            {
                filaMayorSuma = i; 
            }
        }

     
        Console.WriteLine($"La fila con la mayor suma es la fila {filaMayorSuma + 1} con una suma de {sumasFilas[filaMayorSuma]}");
    }
}



// 3- Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.


{
    int[,] matriz = new int[3, 3];

       
        for (int i = 0; i < 3; i++) // filas
        {
            for (int j = 0; j < 3; j++) // columnas
            {
                Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        for (int i = 0; i < 3; i++) // filas
        {
            for (int j = 0; j < 3; j++) // columnas
            {
                if (matriz[i, j] < 0) 
                {
                    matriz[i, j] = 0; //reemplazo los numeros negativos por cero
                }
            }
        }

        
        Console.WriteLine("Matriz después de reemplazar los negativos por cero:");
        for (int i = 0; i < 3; i++) // filas
        {
            for (int j = 0; j < 3; j++) // columnas
            {
                Console.Write(matriz[i, j] + " ");
            }
            
        }
    }





// Ejercicios listas
// 1- Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.
{
    List<int> numeros = new List<int>(); 
    int sumaTotal = 0;

   
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        int numero = int.Parse(Console.ReadLine());
        numeros.Add(numero);
    }

    
    foreach (int numero in numeros)
    {
        sumaTotal += numero;
    }

   
    Console.WriteLine($"La suma total de los números es: {sumaTotal}");
}




// 2- Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.
{
    List<int> numeros = new List<int>();


    for (int i = 0; i < 7; i++)
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        int numero = int.Parse(Console.ReadLine());
        numeros.Add(numero);
    }
    Console.Write("Ingrese otro número para verificar si está en la lista: ");
    int numeroBusqueda = int.Parse(Console.ReadLine());

    bool encontrado = false;
    foreach (int numero in numeros)
    {
        while (numero == numeroBusqueda)
        {
            encontrado = true;
            Console.WriteLine("El número está en la lista.");
            break;
        }
        if ( numero != numeroBusqueda )
        {
            Console.WriteLine("El número NO está en la lista.");
        }
    }
}






// 3- Generar una lista con 10 números aleatorios entre 1 y 100. Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor. Mostrar la lista resultante.
{
    Random random = new Random();
    List<int> numeros = new List<int>();

    
    for (int i = 0; i < 10; i++)
    {
        int numero = random.Next(1, 101);
        numeros.Add(numero);
    }

  
    Console.WriteLine("Lista original:");
    for (int i = 0; i < numeros.Count; i++) // count es como el lenght
    {
        Console.Write(numeros[i] + " ");
    }

    Console.WriteLine("Ingrese un valor límite: ");
    int limite = int.Parse(Console.ReadLine());

   
    List<int> nuevaLista = new List<int>();
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] >= limite)
        {
            nuevaLista.Add(numeros[i]);
        }
    }

    Console.WriteLine("Lista después de eliminar los menores al límite:");
    for (int i = 0; i < nuevaLista.Count; i++)
    {
        Console.Write(nuevaLista[i] + " ");
    }
}
