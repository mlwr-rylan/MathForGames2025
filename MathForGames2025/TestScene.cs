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
        private Actor _spaceship;

        public override void Start()
        {
            base.Start();
            Vector2 startPosition = new Vector2(1, 0);
            Vector2 startPosition2 = new Vector2(400, 200);
            // new
            
            Icon playerIcon = new Icon { IconColor = Color.BEIGE, Symbol = "00" };
            Icon enemyIcon = new Icon { IconColor = Color.BROWN, Symbol = "88" };
            
            
            _testActor = new Player(playerIcon, startPosition);
            _testEnemy = new Enemy(_testActor, enemyIcon, startPosition);

            Actor spaceship = new Player("Images/player.png", startPosition);
            

            

            AddActor(_testActor);
            AddActor (_spaceship);
            
        }


    }
}
