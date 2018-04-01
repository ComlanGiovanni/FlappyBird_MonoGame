using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosteehBird
{
    public class Ground : GameObject
    {
        public Ground():base(0,400 * Settings.PIXEL_RATIO, new Sprite("base"))
        {

        }
    }
}
