using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    class AIEProgrammingStudent
    {
        public static int ClassRoomNumber;
        public string Name;
    }

    internal class Engine
    {
        private const int _screenWidth = 800;
        private const int _screenHeight = 450;
        private static bool _applicationShouldClose;
        private static Icon[,] _buffer;
        private TestScene _testScene;


        private void Start()
        {
            Raylib.InitWindow(_screenWidth, _screenHeight, "MathForGames" );
            _testScene = new TestScene();
            _buffer = new Icon[10, 10];
            _testScene.Start();
        }
        public static void Render(Icon icon, Vector2 position)
        {
            Raylib.DrawText(icon.Symbol,  (int)position.X, (int)position.Y, 50,  icon.IconColor);

        }
        private void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            _testScene.Draw();

            Raylib.EndDrawing();
        }

        private void Update()
        {
           
            _testScene.Update();
            
        }

        private void End()
        {
            _testScene.End();
            Raylib.CloseWindow();
        }
        
        public static void EndApplication()
        {
            _applicationShouldClose = true;
        }

        public void Run()
        {
            Start();

            while (!_applicationShouldClose && !Raylib.WindowShouldClose())
            {
                Draw();
                Update();
            }

            End();
        }
    }
}
