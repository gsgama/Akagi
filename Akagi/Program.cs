using System;

namespace Akagi
{
    class Program
    {
        const int ScreenWidth = 120;
        const int ScreenHeight = 40;

        static void Main(string[] args)
        {
            Configure();
            DrawScreen();
            ShowWelcome();
            PlayIntroduction();
            Prompt("You order");
            ReadCommand();
        }

        private static void PlayIntroduction()
        {
            Audio.Player.Play(Audio.Tunes.Sakura.Notes, 1.5);
        }

        private static void ShowWelcome()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.WriteLine("Welcome to Akaki!!!");
            Console.WriteLine("WWII Aircraft Carrier Simulator");
            Console.WriteLine("By Gama ©2019");
        }

        private static void ReadCommand()
        {
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char key = consoleKeyInfo.KeyChar;

                if (key == 'x')
                {
                    ShowStatus("Exiting...");
                    break;
                }
                else if (key == 's')
                {
                    Prompt("Set course");
                }
            }
        }

        private static void ShowStatus(string text)
        {
            DrawStatusLine();
            Console.CursorLeft = 0;
            Console.CursorTop = ScreenHeight - 1;
            Console.Write($"{text}");
        }

        private static void Prompt(string text)
        {
            DrawStatusLine();
            Console.CursorLeft = 0;
            Console.CursorTop = ScreenHeight - 1;
            Console.Write($"{text}:>");
        }

        private static void DrawScreen()
        {
            for (var row = 0; row < ScreenHeight; row++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = row;

                for (var col = 0; col < ScreenWidth; col++)
                {
                    char brush = ' ';
                    Console.Write(brush);
                }
            }
        }

        private static void DrawStatusLine()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = ScreenHeight - 1;

            for (var col = 0; col < ScreenWidth; col++)
            {
                char brush = ' ';
                Console.Write(brush);
            }
        }

        private static void Configure()
        {
            Console.Title = "Akagi!!!";
            Console.WindowWidth = ScreenWidth;
            Console.WindowHeight = ScreenHeight;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }
}
