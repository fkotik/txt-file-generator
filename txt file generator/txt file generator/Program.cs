using System.Text;

Console.WriteLine("Укажите путь к папке где будут генерироваться файлы");
string path2 = Console.ReadLine();
Console.WriteLine("Укажите минимальное кол-во слов в файле");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите максимальное кол-во слов в файле");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите кол-во файлов которые надо сгенерировать");
int t = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите путь к файлу от куда будет браться список слов");
string path = Console.ReadLine();

string[] slovar = File.ReadAllLines(@path);

var rnd = new Random();

string[] znaki = {" ", ", ", ". "};
int j = 1;
while (t-->0)
{
    string text="";
    int i = rnd.Next(min, max+1);
    while (i-- > 0)
    {
        text += slovar[rnd.Next(0, slovar.Length)] + znaki[rnd.Next(0, znaki.Length)];
    }
    string path3 = path2 + j + ".txt";
    j++;
    File.WriteAllText(@path3, text);
}