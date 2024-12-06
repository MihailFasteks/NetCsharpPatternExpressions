// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Введите номер телефона");
string Input = Console.ReadLine();
string pattern = @"^(\+?380|0)?[- ]?\(?\d{2,3}\)?[- ]?\d{3}[- ]?\d{2}[- ]?\d{2}$";
Regex regex = new Regex(pattern);

if (regex.IsMatch(Input))
    Console.WriteLine("Номер введен правильно!");
else
    Console.WriteLine("Номер введен не правильно!");

string pattern1 = @"^[a-zA-Z][a-zA-Z0-9._%+-]*@gmail\.com$";

regex=new Regex(pattern1);
string Input1 = Console.ReadLine();

if (regex.IsMatch(Input1))
    Console.WriteLine("Email введен правильно!");
else
    Console.WriteLine("Email введен не правильно!");

