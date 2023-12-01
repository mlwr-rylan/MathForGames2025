﻿using MathLibrary;
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

            


            Player playerActor = new Player("Images/mario.png", startPosition);
            playerActor.Size = new Vector2(50, 50);

            Enemy enemyActor = new Enemy(playerActor, "Images/enemy.png", startPosition2);

            //Add both actors to the scene
            AddActor(playerActor);
            AddActor(enemyActor);

        }
    }
}

