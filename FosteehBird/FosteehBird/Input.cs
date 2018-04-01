using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FosteehBird
{
    public class Input
    {
        private KeyboardState oldKeyboard;
        private MouseState oldMouse;

        private KeyboardState keyboard;
        private MouseState mouse;

        public Input(KeyboardState oldKeyboard, MouseState oldMouse, KeyboardState keyboard, MouseState mouse)
        {
            this.oldMouse = oldMouse;
            this.oldKeyboard = oldKeyboard;

            this.keyboard = keyboard;
            this.mouse = mouse;
        }
        /*
        public bool IsKeyDown(Keys key)
        {
            return this.keyboard.IsKeyDown(key);
        }

        public bool IsKeyUp(Keys key)
        {
            return this.keyboard.IsKeyUp(key);
        }
        */
        public bool IsKey(Keys key)
        {
            return this.oldKeyboard.IsKeyUp(key) && this.keyboard.IsKeyDown(key);
        }

        /*
        public bool IsLeftMouseButton(ButtonState state)
        {
            return this.mouse.LeftButton == state;
        }*/

        public bool IsLeftMousePressed()
        {
            return this.oldMouse.RightButton == ButtonState.Pressed && this.mouse.RightButton == ButtonState.Released;
        }

        public Point GetMousePosition()
        {
            return new Point(this.mouse.X, this.mouse.Y);

        }
    }
}
