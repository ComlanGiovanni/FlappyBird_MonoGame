using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FosteehBird
{
    public class Settings
    {
        public static int PIXEL_RATIO = 2;

        public static int SCREEN_WIDTH = 288 * PIXEL_RATIO;
        public static int SCREEN_HEIGHT = 512 * PIXEL_RATIO;

        public static bool IS_FULLSCREEN = false;
        public static bool IS_MOUSE_VISIBLE = true;
        public static bool ALLOW_USER_RESIZING = true;
        public static bool IS_BORDERLESS = true;

        public static Color BACKGROUND_COLOR = Color.CornflowerBlue;
    }
}
