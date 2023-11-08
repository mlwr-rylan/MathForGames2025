﻿using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathForGames2025
{
    internal class SpriteCranberry
    {
        class Sprite
        {
            private Texture2D _texture;

            //Width of the loaded texture
            public int Width
            {
                get
                {
                    return _texture.width;
                }
                set
                {
                    _texture.width = value;
                }
            }

            //Height of the loaded texture
            public int Height
            {
                get
                {
                    return _texture.height;
                }
                set
                {
                    _texture.height = value;
                }
            }

            /// <summary>
            /// Loads the given texture
            /// </summary>
            /// <param name="texture">Sets the sprites image to be the given texture</param>
            public Sprite(Texture2D texture)
            {
                _texture = texture;
            }

            /// <summary>
            /// Loads the texture at the given path
            /// </summary>
            /// <param name="texture">The file path of the texture</param>
            public Sprite(string path)
            {
                _texture = Raylib.LoadTexture(path);
            }

            /// <summary>
            /// Draws the sprite using the rotation, translation, and scale
            /// of the given transform
            /// </summary>
            /// <param name="transform">The transform matrix attached to the actor that owns this sprite.</param>
            public void Draw(Matrix3 transform)
            {
                //Finds the scale of the sprite
                float xMagnitude = (float)Math.Round(new Vector2(transform.M00, transform.M10).GetMagnitude());
                float yMagnitude = (float)Math.Round(new Vector2(transform.M01, transform.M11).GetMagnitude());
                Width = (int)xMagnitude;
                Height = (int)yMagnitude;

                //Sets the sprite center to the transform origin
                System.Numerics.Vector2 pos = new System.Numerics.Vector2(transform.M02, transform.M12);
                System.Numerics.Vector2 forward = new System.Numerics.Vector2(transform.M00, transform.M10);
                System.Numerics.Vector2 up = new System.Numerics.Vector2(transform.M01, transform.M11);
                pos -= (forward / forward.Length()) * Width / 2;
                pos -= (up / up.Length()) * Height / 2;

                //Find the transform rotation in radians 
                float rotation = (float)Math.Atan2(transform.M10, transform.M00);

            }
        }
