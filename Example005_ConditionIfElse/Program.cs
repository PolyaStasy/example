﻿using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}