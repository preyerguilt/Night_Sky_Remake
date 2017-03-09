using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Night_Sky_Remake.Screens {
    class ScreenManager {

        private static ScreenManager instance;

        //Creating custonm contentmanager
        ContentManager content;
        GameScreen currentScreen;
        GameScreen newScreen;

        Stack<GameScreen> screenStack = new Stack<GameScreen>();
        //Screens width and height
        Vector2 dimensions;

        public static ScreenManager Instance {
            get {
                if (instance == null) instance = new ScreenManager();
                return instance;
            }
        }

        public Vector2 Dimensions {

            get { return dimensions; }
            set { dimensions = value; }

        }

        public void AddScreen(GameScreen screen) {
            newScreen = screen;
        }

        public void Initialize() {

            currentScreen = new Splashscreen();
        }

        public void LoadContent(ContentManager Content) {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(Content);
        }
        public void Update(GameTime gameTime) {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch) {
            currentScreen.Draw(spriteBatch);
        }

        private void Transition(GameTime gameTime) {

            screenStack.Push(newScreen);
            currentScreen.UnloadContent();
            currentScreen = newScreen;
            currentScreen.LoadContent(content);


        }

    }
}
