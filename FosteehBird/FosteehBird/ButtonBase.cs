using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public abstract class ButtonBase : GameObject
    {
        public ButtonBase(int x, int y, int index) : base(x,y, new Animated("", 40, 14, index))
        {

        }

        public override void Update(Input input)
        {
            base.Update(input);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}
