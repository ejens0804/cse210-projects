/*
In this program I fulfilled all of the Core Requirements. I have exceeded the requirements
and shown creativity by adding 3 more classes that add additional functionality. 
The user is able to reset the program, and there is a money system involved with the goals
so that as the user completes goals they are awarded with XP and Moolah (the program currency).
The XP determines what their level name is called (the more xp they have, the cooler the name)
and they can use the moolah in the rewards shop to buy a reward. 
*/





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