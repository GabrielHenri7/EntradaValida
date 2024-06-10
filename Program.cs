Console.Clear();
 
Console.WriteLine("--->> ATIVIDADE ENTRADA VÁLIDA <<---");
 
int resolução;
do 
{
 
    Console.Write("\nDigite um número: ");
    resolução = Convert.ToInt32(Console.ReadLine())!;
 
}
while(resolução < 0 || resolução >= 10);
 
if (resolução== 0)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nOperação cancelada");
    Console.ResetColor();
}
 
else
{
    Console.WriteLine($"\nNúmero escolhido = {resolução}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nVolte logo!");
    Console.ResetColor();
}
