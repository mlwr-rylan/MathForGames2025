using System;
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
        private static bool _applicationShouldClose;
        private static char[,] _buffer;
        private TestScene _testScene;

        public static void Render(char icon, Vector2 position)
        {
            if(position.Y >= _buffer.GetLength(0) || position.Y < 0)
            {
                return;
            }
            else if (position.X >= _buffer.GetLength(0) || position.X < 0)
            {
                return;
            }
                _buffer[(int)position.Y, (int)position.X] = icon;
        }
        private void Start()
        {
            _testScene = new TestScene();
            _buffer = new char[10, 10];
            _testScene.Start();
        }

        private void Draw()
        {
            Console.Clear();
            _buffer = new char[10, 10];
            _testScene.Draw();
            for(int y = 0; y < _buffer.GetLength(0); y++)
            {
                for(int x = 0; x < _buffer.GetLength(1); x++)
                {
                    Console.Write(_buffer[y, x].Symbol);
                }
            }
        }

        private void Update()
        {
            _testScene.Update();

        }

        private void End()
        {
            _testScene.End();
        }
        public static char GetInput()
        {
            return Console.ReadKey(true).KeyChar;

        }
        public static void EndApplication()
        {
            _applicationShouldClose = true;
        }

        public void Run()
        {
            Start();

            while (!_applicationShouldClose)
            {
                Draw();
                Update();
            }

            End();
        }
    }
}
