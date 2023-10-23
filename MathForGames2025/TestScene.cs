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
        private Enemy _testEnemy;
        private Player _testActor;
        public override void Start()
        {
            base.Start();
            Vector2 startPosition = new Vector2(6, 0);
            Icon playerIcon = new Icon { IconColor = Color.BEIGE, Symbol = "( {} )" };
            Icon enemyIcon = new Icon { IconColor = Color.BROWN, Symbol = "8==D" };

            
            _testActor = new Player(playerIcon, startPosition);
            _testEnemy = new Enemy(_testActor, enemyIcon, startPosition);

            _testActor.Start();
            _testEnemy.Start();
        }
        public override void Draw()
        {
            base.Draw();
            _testActor.Draw();
            _testEnemy.Draw();
        }
        public override void Update(float deltaTime)
        {
            base.Update( deltaTime);
            _testActor.Update(deltaTime);
            _testEnemy.Update(deltaTime);
        }

    }
}
