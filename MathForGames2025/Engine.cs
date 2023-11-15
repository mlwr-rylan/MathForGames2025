using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MathForGames2025
{

    internal class Engine
    {
        private const int _screenWidth = 800;
        private const int _screenHeight = 450;

        public static int Width
        {
            get { return _screenWidth; }
        }
        public static int Height
        {
            get { return _screenHeight; }
        }
        private static bool _applicationShouldClose;

        private static Scene _currentScene;

        private Stopwatch _stopwatch = new Stopwatch();
     
        private void Start()
        {
            //math test
            //Matrix4 hey = new Matrix4(1, 0, 5, 3,
            //                           2, 3, 1, 3,
            //                           2, 3, 2, 1,
            //                           2, 6, 4, 3);

            //Matrix4 hey2 = new Matrix4(1, 0, 5, 3,
            //                           2, 3, 1, 3,
            //                           2, 3, 2, 1,
            //                           2, 6, 4, 3);
            //Matrix4 result = hey * hey2;

            Raylib.InitWindow(_screenWidth, _screenHeight, "MathForGames" );
            Raylib.SetTargetFPS(120);
            _stopwatch.Start();
            _currentScene = new TestScene();

            _currentScene.Start();
        }
        public static Scene GetCurrentScene()
        {
            return _currentScene;
        }
        public static void Render(Icon icon, Vector2 position)
        {
            Raylib.DrawText(icon.Symbol,  (int)position.X, (int)position.Y, 50,  icon.IconColor);

        }
        
        private void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            _currentScene.Draw();

            Raylib.EndDrawing();
        }

        private void Update(float deltaTime)
        {
            _currentScene.Update(deltaTime);
            
        }

        private void End()
        {
            _currentScene.End();
            Raylib.CloseWindow();
        }
        
        public static void EndApplication()
        {
            _applicationShouldClose = true;
        }
        public static Actor AddActorToScene(Actor actorToSpawn)
        {
            _currentScene.AddActor(actorToSpawn);
            return actorToSpawn;
        }
        public void Run()
        {
            Vector2 test = new Vector2(8, 5);
    
            float magnitude = test.GetMagnitude();
            
            Start();

            
            
            float currentTime = 0;
            float lastTime = 0;
            float deltaTime = 0;
            while (!_applicationShouldClose && !Raylib.WindowShouldClose())
            {
                currentTime = _stopwatch.ElapsedMilliseconds / 1000.0f;
                Console.WriteLine(currentTime);
                deltaTime = currentTime - lastTime;
                Draw();
                Update(deltaTime);
                lastTime = currentTime;
            }

            End();
        }
    }
}
