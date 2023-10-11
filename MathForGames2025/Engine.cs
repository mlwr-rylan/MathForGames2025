using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Start()
        {

        }

        private void Draw()
        {

        }

        private void Update()
        {

        }

        private void End()
        {

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
