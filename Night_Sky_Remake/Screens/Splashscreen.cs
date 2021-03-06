﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System.IO;

namespace Night_Sky_Remake.Screens {
    public class Splashscreen : GameScreen{

        //KeyboardState keyState;
        Texture2D image;

        public override void LoadContent(ContentManager Content) {
            base.LoadContent(Content);
            image = content.Load<Texture2D>("Background");
        }

        public override void UnloadContent() {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime) {
        /*TODO: Insert Level Here!
            keyState = Keyboard.GetState();
            if (gameTime.TotalGameTime.Seconds >= 3 || keyState.IsKeyDown(Keys.Enter)) {
                ScreenManager.Instance.AddScreen(new GameScreen());
        }
        */
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(image, new Rectangle(0, 0, 800, 600), Color.Yellow);
        }


    }
}
