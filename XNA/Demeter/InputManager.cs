using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Demeter
{
    public class InputManager
    {
        #region Member variables
        //Buffers
        private static const int bufferLength = 2;
        private List<KeyboardState> keyboardInputBuffer;
        private List<GamePadState> controllerInputBuffer;
        //perhaps more buffers for more controllers...

        private Dictionary<String, Buttons> controllerMap;
        private Dictionary<String, Keys> keyboardMap;
        #endregion

        #region Instancing
        private InputManager() { }
        private static InputManager instance;
        public static InputManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputManager();
                }
                return instance;
            }
        }
        #endregion

        public void update(GameTime gameTime)
        {
            //some update logic here
        }

        public void saveConfig(String fileName) { }

        public bool loadConfig(String fileName) { return true; }
    }
}
