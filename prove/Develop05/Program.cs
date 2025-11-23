using System;
using System.Security.Cryptography;
using System.Text.Json; // modern JSON serializer

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.RunMenuOption();
    }
}