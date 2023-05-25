using System;

class Program
{
    static void Main() {
        string Answer;
        //вывести меню в отдельную функцию и вызывать в самом начале
       Console.WriteLine("Write first letter of the option");
       Console.WriteLine("New game");
       Console.WriteLine("Saves");
       Answer = Console.ReadLine();
        switch (Answer){
            case "n":
                //start the game
                Console.WriteLine("New game");
                break;
            case "s":
                //load save
                Console.WriteLine("Saves");
                break;
            case "exit":
                //close the game
                break;
            }
        }
    }
