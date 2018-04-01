using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public abstract class MenuBase
    {

        private Sprite background;
        private Ground ground;

        //CONSTRUCTOR
        protected MenuBase()
        {
            this.background = new Sprite("background-day");
            this.ground = new Ground();
        }


        //METHODS
        public virtual void Update(Input input)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            this.background.Draw(spriteBatch);
            this.ground.Draw(spriteBatch);
        }
    }
}
