using MathLibrary;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class TestScene : Scene
    {
        private Actor _testActor;
        public override void Start()
        {
            base.Start();
            Vector2 startPosition = new Vector2(6, 0);
            Icon playerIcon = new Icon { IconColor = Color.BLUE, Symbol = "OD" };
            _testActor = new Player(playerIcon, startPosition);

            _testActor.Start();
        }
        public override void Draw()
        {
            base.Draw();
            _testActor.Draw();
        }
        public override void Update(float deltaTime)
        {
            base.Update( deltaTime);
            _testActor.Update(deltaTime);
        }

    }
}
