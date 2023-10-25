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
        //private Enemy _testEnemy2;
        private Enemy _testEnemy;
        private Player _testActor;
        public override void Start()
        {
            base.Start();
            Vector2 startPosition = new Vector2(1, 0);
            Vector2 startPosition2 = new Vector2(400, 200);
            Icon playerIcon = new Icon { IconColor = Color.BEIGE, Symbol = "00" };
            Icon enemyIcon = new Icon { IconColor = Color.BROWN, Symbol = "88" };
            //Icon enemyIcon2 = new Icon { IconColor = Color.DARKBLUE, Symbol = "PO " };
            
            _testActor = new Player(playerIcon, startPosition);
            _testEnemy = new Enemy(_testActor, enemyIcon, startPosition);
            //_testEnemy2 = new Enemy(_testEnemy2, enemyIcon2, startPosition2);

            _testActor.Start();
            _testEnemy.Start();
            //_testEnemy2.Start();
        }
        public override void Draw()
        {
            base.Draw();
            _testActor.Draw();
            _testEnemy.Draw();
            //_testEnemy2.Draw();
        }
        public override void Update(float deltaTime)
        {
            base.Update( deltaTime);
            _testActor.Update(deltaTime);
            _testEnemy.Update(deltaTime);
            //_testEnemy2.Update(deltaTime);
        }

    }
}
