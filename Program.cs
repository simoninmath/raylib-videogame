using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.ConfigFlags;
using System.Numerics;

public class RaylibGame
{
  public static int Main()
  {
      float rotation = 0.0f;
      System.Console.WriteLine("Checking Raylib!");

      // Set the screen size to the current monitor size
      int screen = GetCurrentMonitor();
      int screenWidth = GetMonitorWidth(screen);
      int screenHeight = GetMonitorHeight(screen);

      InitWindow(screenWidth, screenHeight, "Raylib Video Game");

      // Set the window size and styles
      SetWindowState(BorderlessWindowMode);

      // Allow responsive screen size
      int width = GetScreenWidth();
      int height = GetScreenHeight();
      
      while (!WindowShouldClose())
      {
          rotation += 0.5f;

          BeginDrawing();
          ClearBackground(Color.DarkBlue);

          // Check if the window is focused
          if(IsWindowState(UnfocusedWindow))
          {
              DrawText("GAME PAUSED", 190, 200, 20, Color.Red);
          }

          // DrawTriangle(new Vector2(600, 600), new Vector2(650, 650), new Vector2(700, 700), Color.Magenta);

          DrawLine(10, 10, 100, 100, Color.Red);
          DrawCircle(200, 200, 50, Color.Blue);
          DrawCircleV(new Vector2(300, 300), 50, Color.Green);
          DrawCircleLines(400, 400, 50, Color.Purple);  
          DrawRectangle(500, 500, 50, 50, Color.Yellow);
          DrawPoly(new Vector2(600, 600), 6, 50, rotation, Color.Orange);

          DrawText("Hi!", 190, 200, 20, Color.Red);
          EndDrawing();
      }

      CloseWindow();
      return 0;
  }
}