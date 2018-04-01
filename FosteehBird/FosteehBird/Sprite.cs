using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public class Sprite
    {
        private Rectangle desinationRectangle;
        //private Vector2 posistion;
        private Texture2D texture;
        //private Rectangle sourceRectangle;
        private Color color;

        /*
        public Rectangle GetHitbox()
        {
            return this.desinationRectangle;
        }*/
        public Point GetTextureSize()
        {
            return new Point(this.desinationRectangle.Width, this.desinationRectangle.Height);
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public Sprite(string imgKey)
        {
            this.texture = Ressources.Images[imgKey];
            this.color = Color.White;
            this.desinationRectangle = new Rectangle(0,0,
            this.texture.Width * Settings.PIXEL_RATIO,
            this.texture.Height * Settings.PIXEL_RATIO);
        }
        
        public virtual void Update(int x, int y)
        {
            this.desinationRectangle = new Rectangle(x, y,
            this.texture.Width * Settings.PIXEL_RATIO,
            this.texture.Height * Settings.PIXEL_RATIO);
        }

        /*
        public Sprite(string imgKey)
        {
            this.Initialize(imgKey, Rectangle.Empty);
        }

        public Sprite(string imgKey, Rectangle sourceRect)
        {
            this.Initialize(imgKey, sourceRect);
        }

        private void Initialize(string imgKey, Rectangle sourceRect)
        {
            //this.posistion = new Vector2(x, y); float x, float y, 
            this.texture = Ressources.Images[imgKey];
            this.sourceRectangle = sourceRect;
            this.color = Color.White;
            /*
            this.desinationRectangle = new Rectangle((int)x, (int)y, 
                this.texture.Width * Settings.PIXEL_RATIO, 
                this.texture.Height * Settings.PIXEL_RATIO);
                
        }
        */

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.desinationRectangle, this.color);
        }

    }
}
