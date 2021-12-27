using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework.Input;

namespace Algorhytms.Entities
{
    public partial class Player
    {
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        const int GridVertLenSize = 16;

        public enum Directions{
            Up, 
            Down,
            Right,
			Left
		}

        private void CustomInitialize()
        {
            
            
        }

        private void CustomActivity()
        {
            
            
        }

        private void CustomDestroy()
        {


        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
        public void MovingThePlayer(Player.Directions direction)
        {
            if (direction == Directions.Up)
            {
                this.Y += GridVertLenSize;
            }
            else if (direction == Directions.Down)
            {
                this.Y -= GridVertLenSize;
            }
            else if (direction == Directions.Left)
            {
                this.X -= GridVertLenSize;
            }
            else if (direction == Directions.Right)
            {
                this.X += GridVertLenSize;
            }
        }
    }
}
