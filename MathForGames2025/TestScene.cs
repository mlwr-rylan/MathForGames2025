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
        public override void Start()
        {
            base.Start();

            Vector2 startPosition = new Vector2(40, 40);
            Vector2 startPosition2 = new Vector2(400, 200);

            Icon playerIcon = new Icon { IconColor = Color.BEIGE, Symbol = "00" };
            Icon enemyIcon = new Icon { IconColor = Color.BROWN, Symbol = "88" };

            Player playerActor = new Player("Images/player.png", startPosition);
            playerActor.Size = new Vector2(50, 50);

            Enemy enemyActor = new Enemy(playerActor, enemyIcon, startPosition2);

            // Add both actors to the scene
            AddActor(playerActor);
            AddActor(enemyActor);
        }
    }
}

