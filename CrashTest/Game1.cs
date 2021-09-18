using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.UI;

namespace CrashTest
{
    public class Game1 : Core
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            Scene = new Scene();

            var uiEntity = new Entity();
            var canvas = uiEntity.AddComponent(new UICanvas());
            var table = canvas.Stage.AddElement(new Table());
            table.SetFillParent(true);

            var inputStyle = TextFieldStyle.Create(Color.Black, Color.Black, Color.Black, Color.Black);
            table.AddElement(new TextField("", inputStyle));



            Scene.AddEntity(uiEntity);
        }

       
    }
}
