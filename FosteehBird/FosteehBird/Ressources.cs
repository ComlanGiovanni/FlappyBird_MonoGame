using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FosteehBird
{
    public class Ressources
    {
        public static Dictionary<string, Texture2D> Images;
        public static Dictionary<string, SoundEffect> Sounds;

        public static void LoadImages(ContentManager content)
        {
            Images = new Dictionary<string, Texture2D>();

            List<string> graphics = new List<string>()
            {
                "background-day",
                "gameover",
                "yellowbird-downflap",
                "base",
                "pipe-green",
            };

            foreach (String img in graphics)
                Images.Add(img, content.Load<Texture2D>("Graphics/" + img));
        }

        public static void LoadSounds(ContentManager content)
        {
            Sounds = new Dictionary<string, SoundEffect>();

            List<string> sounds = new List<string>()
            {
                "die",
                "hit",
                "point",
                "swoosh",
                "wing",
            };

            foreach (string sfx in sounds)
                Sounds.Add(sfx, content.Load<SoundEffect>("Sounds/" + sfx));
        }
    }
}
