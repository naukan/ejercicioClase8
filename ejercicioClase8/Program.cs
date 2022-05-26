Console.Write("Ingrese la cantidad alumnos: ");

int cantAlu = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingrese la cantidad notas por alumno: ");

int cantNotas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantNotas, cantAlu];
double[] promedio = new double[cantAlu];

for (int i = 0; i < cantAlu; i++)
{
    Console.WriteLine($"Notas del alumno No.{i + 1}");

    for (int j = 0; j < cantNotas; j++)
    {
        Console.WriteLine($"Ingrese el valor de la nota No.{j + 1}: ");
        numeros[j, i] = int.Parse(Console.ReadLine());
        promedio[i] += numeros[j, i];
    }
    promedio[i] = promedio[i] / cantNotas;
}

for (int i = 0; i < cantAlu; i++)
{
    Console.WriteLine($"Las notas del alumno No.{i + 1} son: ");

    for (int j = 0; j < cantNotas; j++)
    {
        Console.WriteLine($" {numeros[j, i]}");
    }
    
}

for (int i = 0; i < cantAlu; i++)
{
    Console.WriteLine($"El promedio del alumno No.{i + 1} es: {promedio[i]}");

}

Console.ReadLine();