using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public abstract class GameObject
    {
        private Rectangle hiboxbox;
        private Sprite sprite;

        protected GameObject(int x, int y, Sprite sprite)
        {
            Point textureSize = sprite.GetTextureSize();
            this.hiboxbox = new Rectangle(x, y, textureSize.X, textureSize.Y);
            this.sprite = sprite;
            this.sprite.Update(x, y);
        }

        
        public virtual void Update(Input input)
        {
            this.sprite.Update(this.hiboxbox.X, this.hiboxbox.Y);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            this.sprite.Draw(spriteBatch);
        }
    }
}
