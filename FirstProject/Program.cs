// Задание 1
string FullName;
int Age;
string Email;
float ProgrammigScore;
float MathScore;
float PhysScore;


FullName = ("Мутин Егор Николаевич");
Age = (23);
Email = ("mutin.egor@mail.com");
ProgrammigScore = (76.3F);
MathScore = (68.3F);
PhysScore = (73.4F);

string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} \n";

   

Console.WriteLine(pattern, 
    FullName, 
    Age,
    Email,
    ProgrammigScore,
    MathScore,
    PhysScore);
Console.ReadKey();

//Задание 2

float a = (ProgrammigScore);
float b = (MathScore);
float c = (PhysScore);

float y = (a+b+c);                // y = Сумма баллов

float x = (y/3);                // x = Средний балл

Console.WriteLine($"Средний балл всех предметов: {x}");

Console.ReadLine();

