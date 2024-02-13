int[] materias = new int[5];
Console.WriteLine("Add your grade for the following subjects:");
Console.WriteLine("Spanish:");
materias[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Math:");
materias[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Chemistry:");
materias[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Sciences:");
materias[3] = int.Parse(Console.ReadLine());
Console.WriteLine("History:");
materias[4] = int.Parse(Console.ReadLine());

int suma = 0;
for (int i = 0; i < materias.Length; i++)
{
    suma += materias[i];
}
int resultado = suma * 2;
Console.WriteLine("The sum of the scores is: " + resultado);

if (resultado > 70)
{
    Console.WriteLine("Approved!!");
}
else
{
    Console.WriteLine("Reprobate :(");
}
Console.ReadKey();
