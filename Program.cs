using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.ConfigFlags;

public class RaylibGame
{

  public static int Main()
  {
      System.Console.WriteLine("Checking Raylib!");

      // Set the screen size to the current monitor size
      int screen = GetCurrentMonitor();
      int screenWidth = GetMonitorWidth(screen);
      int screenHeight = GetMonitorHeight(screen);

      InitWindow(screenWidth, screenHeight, "Raylib Video Game");

      // Set the window size and styles
      SetWindowState(BorderlessWindowMode);
      // SetWindowSize(screenWidth, screenHeight);

      // Allow responsive screen size
      int width = GetScreenWidth();
      int height = GetScreenHeight();
      
      while (!WindowShouldClose())
      {
          BeginDrawing();
          ClearBackground(Color.White);

          if(IsWindowState(UnfocusedWindow))
          {
              DrawText("GAME PAUSED", 190, 200, 20, Color.Red);
          }

          DrawText("COCO !", 190, 200, 20, Color.Red);
          EndDrawing();
      }

      CloseWindow();
      return 0;
  }
}