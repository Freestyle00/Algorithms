using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Gui;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework.Input;

using Algorhytms.Entities;
using Microsoft.Xna.Framework;

namespace Algorhytms.Screens
{
    public partial class GameScreen
    {
        const int GridVertLenSize = 16;
        void CustomInitialize()
        {
            Camera.Main.X = 256;
            Camera.Main.Y = -256;


        }

        void CustomActivity(bool firstTimeCalled)
        {
            KeyboardMovement();
            Console.WriteLine(SolidCollision.GetRectangleAtPosition(8, -8));
        }

		partial void CustomActivityEditMode()
		{
			if (InputManager.Keyboard.KeyDown(Keys.F2))
			{
                GlueControl.Editing.EditorVisuals.Text($"X:{GuiManager.Cursor.WorldX} Y:{GuiManager.Cursor.WorldY}", GuiManager.Cursor.WorldPosition.ToVector3());
                GlueControl.Editing.EditorVisuals.Text($"{SolidCollision.GetRectangleAtPosition(GuiManager.Cursor.WorldX, GuiManager.Cursor.WorldY)}", GuiManager.Cursor.WorldPosition.ToVector3());
            }
		}

		void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }
        void KeyboardMovement()
        {
			if (InputManager.Keyboard.KeyPushed(Keys.W))
			{
                MovingCheck(Player.Directions.Up);
			}
			else if (InputManager.Keyboard.KeyPushed(Keys.S))
			{
                MovingCheck(Player.Directions.Down);
            }
			else if (InputManager.Keyboard.KeyPushed(Keys.A))
			{
                MovingCheck(Player.Directions.Left);
            }
			else if (InputManager.Keyboard.KeyPushed(Keys.D))
			{
                MovingCheck(Player.Directions.Right);
            }
        }
        public bool MovingCheck(Player.Directions direction)
        {
			if (direction == Player.Directions.Up)
			{
				if (SolidCollision.GetRectangleAtPosition(PlayerInstance.X, PlayerInstance.Y + GridVertLenSize) == null)
				{
                    Console.WriteLine($"{PlayerInstance.X} {PlayerInstance.Y + GridVertLenSize}");
                    Console.WriteLine(SolidCollision.GetRectangleAtPosition(PlayerInstance.X, PlayerInstance.Y + GridVertLenSize));
                    PlayerInstance.MovingThePlayer(direction);
                    Console.WriteLine($"{PlayerInstance.X} {PlayerInstance.Y}");
                    Console.WriteLine(SolidCollision.GetRectangleAtPosition(PlayerInstance.X, PlayerInstance.Y));
                }
			}
            else if (direction == Player.Directions.Down)
            {
				if (SolidCollision.GetPolygonAtPosition(PlayerInstance.X, PlayerInstance.Y - GridVertLenSize) == null)
				{
                    PlayerInstance.MovingThePlayer(direction);
				}
            }
            else if (direction == Player.Directions.Left)
            {
				if (SolidCollision.GetPolygonAtPosition(PlayerInstance.X - GridVertLenSize, PlayerInstance.Y) == null)
				{
                    PlayerInstance.MovingThePlayer(direction);
				}
            }
            else if (direction == Player.Directions.Right)
            {
                if (SolidCollision.GetPolygonAtPosition(PlayerInstance.X + GridVertLenSize, PlayerInstance.Y) == null)
				{
                    PlayerInstance.MovingThePlayer(direction);
				}
            }
            return true;
		}
    }
}
