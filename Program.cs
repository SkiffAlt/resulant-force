bool b = false; //переменная активации
string start = "choose language/выберите язык (rus/eng)";
string rus = "\nВы выбрали русский язык. Нажмите любую клавишу, чтобы продолжить.";
string eng = "\nYou've choosen English. Press any key to continue.";
string rusNumber = "Введите количество сил: ";
string engNumber = "Select the number of forces: ";
string d; // переменная выбора языка
string r1 = "rus";
string e1 = "eng";
do 
{
    Console.WriteLine(start);
    Console.WriteLine(change);
    d = Convert.ToString(Console.ReadLine());
    if (d == r1) 
    {
        Console.WriteLine(rus);
        b = true;
    } //русский
    if (d == e1) 
    {
        Console.WriteLine(eng);
        b = true;
    } // английский
} while (b != true); // выбор языка
if (d == r1)
{
    Console.WriteLine(rusNumber);
}
else
{
    Console.WriteLine(engNumber);
}
int a = Convert.ToInt32(Console.ReadLine()); // размер массива
var forces = new double[a]; // объявление массива сил
for (int i = 0; i < forces.Length ; i++) 
{
    if (d == r1)
    {
        Console.WriteLine($"\nВведите значение силы {i + 1} (ньютоны): ");
    }
    else
    {
        Console.WriteLine($"\nEnter the force {i + 1} value (newtons): ");
    }
    string stringValue = Console.ReadLine();
    forces[i] = double.Parse(stringValue);
} // ввод значений сил
var vectors = new double[a]; // объявление массива векторов
for (int i = 0; i < vectors.Length; i++)
{
    if (d == r1)
    {
        Console.WriteLine($"\nВведите угол вектора {i + 1} (градусы): ");
    }
    else
    {
        Console.WriteLine($"\nEnter the vector angle {i + 1} value (degrees): ");
    }
    string stringValue = Console.ReadLine();
    vectors[i] = double.Parse(stringValue) / 57.295779513;
} // ввод значений векторов
int sin = 0;
var sins = new double[a]; // объявление массива синусов
do
{
    sins[sin] = Math.Sin(vectors[sin]) * forces[sin];
    sin++;
} while (sin < a); // вычисление y координат
int cos = 0;
var coss = new double[a]; // объявление массива косинусов
do
{
    coss[cos] = Math.Cos(vectors[cos]) * forces[cos];
    cos++;
} while (cos < a);  // вычисление x координат
double angle = Math.Round(Math.Atan2(sins.Sum(), coss.Sum()) * 57.295779513,3,MidpointRounding.ToEven); // угол вектора
double force = Math.Round(Math.Sqrt(sins.Sum() * sins.Sum() + coss.Sum() * coss.Sum()),3, MidpointRounding.ToEven); // равнодействующая сила
if (d == r1)
{
    Console.WriteLine($"\nРавнодействующая сила равна {force} Н под углом {angle}°.");
}
else
{
    Console.WriteLine($"\nResulant force value equals {force} N at angle {angle}°.");
}