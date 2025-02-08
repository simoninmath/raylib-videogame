using Raylib_cs;
using static Raylib_cs.Raylib;

public class RaylibGame
{

  public static int Main()
  {
      System.Console.WriteLine("Checking Raylib!");
      InitWindow(1024, 768, "Raylib Video Game");

      while (!WindowShouldClose())
      {
          BeginDrawing();
          ClearBackground(Color.White);
          DrawText("GAME OVER AGAIN!", 190, 200, 20, Color.Red);
          EndDrawing();
      }

      CloseWindow();
      return 0;
  }
}