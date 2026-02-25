Console.Write("¿Cuántos números desea ingresar? ");
int n = int.Parse(Console.ReadLine());

int numero;
int positivos = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        positivos++;
    }
}

Console.WriteLine("Cantidad de números positivos: " + positivos);
