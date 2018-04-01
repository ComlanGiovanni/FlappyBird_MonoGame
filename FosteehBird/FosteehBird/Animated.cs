using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public class Animated : Sprite
    {
        private Rectangle sourceRectangle;
        private int spriteWidth;
        private int spriteHeight;
        private int currentIndex;

        public Animated(string imgkey, int spriteWidth, int spriteHeight, int index) : base(imgkey)
        {
            this.spriteWidth = spriteWidth;
            this.spriteHeight = spriteHeight;
            this.currentIndex = index;

            this.sourceRectangle = new Rectangle();
        }

        public override void Update(int x, int y)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
