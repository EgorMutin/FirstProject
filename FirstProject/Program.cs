string FullName;
int Age;
string Email;
float ProgrammigScore;
float MathScore;
float PhysScore;


FullName = ("Мутин Егор Николаевич");
Age = (23);
Email = ("mutin.egor@gmail.com");
ProgrammigScore = (76.3F);
MathScore = (68.3F);
PhysScore = (73.4F);

string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

   

Console.WriteLine(pattern, 
    FullName, 
    Age,
    Email,
    ProgrammigScore,
    MathScore,
    PhysScore);
Console.ReadLine();

