Console.Clear();

int fator1;
int fator2;
int produto;

Console.WriteLine("----Tabuada multiplicativa----");

Console.Write("Digite o número que irá ser multiplicado: ");
fator1 = Convert.ToInt32(Console.ReadLine());

fator2 = 0;


while(fator2 <= 10)
{
produto = fator1 * fator2;
Console.WriteLine($" {fator1} x {fator2} = {produto}");
fator2 += 1;
}

Console.Write("Clique para continuar...");
Console.ReadKey();