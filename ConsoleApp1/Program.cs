using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Raylib_cs;
using System;

class Program
{
    static void Main()
    {
        Raylib.InitWindow(1920, 1080, "Spel");
        Raylib.ToggleFullscreen();

        int x = 10;
        int y = 540;

        Random generator = new Random();

        int stenx = generator.Next(1920);
        int steny = generator.Next(1080);

        while (!Raylib.WindowShouldClose())
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                if (x - 5 >= 40 && !CheckCollision(x - 5, y, 25, 25)) { x -= 5; }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                if (x + 30 <= 1900 && !CheckCollision(x + 5, y, 25, 25)) { x += 5; }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                if (y + 30 <= 1060 && !CheckCollision(x, y + 5, 25, 25)) { y += 5; }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                if (y - 5 >= 20 && !CheckCollision(x, y - 5, 25, 25)) { y -= 5; }
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BEIGE);
            Raylib.DrawCircle(stenx, steny, 5, Color.GRAY);
            Raylib.DrawRectangle(x, y, 25, 25, Color.BROWN);
            Raylib.DrawRectangle(1900, 0, 20, 500, Color.GRAY);
            Raylib.DrawRectangle(1900, 600, 20, 500, Color.GRAY);
            Raylib.DrawRectangle(20, 1060, 1900, 20, Color.GRAY);
            Raylib.DrawRectangle(20, 600, 20, 500, Color.GRAY);
            Raylib.DrawRectangle(0, 600, 20, 20, Color.GRAY);
            Raylib.DrawRectangle(0, 500, 20, 20, Color.GRAY);
            Raylib.DrawRectangle(20, 0, 20, 520, Color.GRAY);
            Raylib.DrawRectangle(20, 0, 1920, 20, Color.GRAY);
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
    static bool CheckCollision(int x, int y, int width, int height)
    {
        /*if (){
            return true;
        }
        else {
            return false;
        }*/


        return false;
        
    }
}