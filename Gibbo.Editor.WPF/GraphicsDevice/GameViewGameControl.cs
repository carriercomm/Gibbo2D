﻿#region Copyrights
/*
Gibbo2D License - Version 1.0
Copyright (c) 2013 - Gibbo2D Team
Founders Joao Alves <joao.cpp.sca@gmail.com> & Luis Fernandes <luisapidcloud@hotmail.com>

Permission is granted to use this software and associated documentation files (the "Software") free of charge, 
to any person or company. The code can be used, modified and merged without restrictions, but you cannot sell 
the software itself and parts where this license applies. Still, permission is granted for anyone to sell 
applications made using this software (for example, a game). This software cannot be claimed as your own, 
except for copyright holders. This license notes should also be available on any of the changed or added files.

The software is provided "as is", without warranty of any kind, express or implied, including but not limited to 
the warranties of merchantability, fitness for a particular purpose and non-infrigement. In no event shall the 
authors or copyright holders be liable for any claim, damages or other liability.

The license applies to all versions of the software, both newer and older than the one listed, unless a newer copy 
of the license is available, in which case the most recent copy of the license supercedes all others.

*/
#endregion

using Gibbo.Library;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Gibbo.Editor.WPF
{
    partial class GameViewGameControl : GameControl
    {
        #region fields

        

        #endregion

        #region properties


        #endregion

        #region methods

        protected override void Initialize()
        {
            
            base.Initialize();
        }


        protected override void Update(GameTime gameTime)
        {
            try
            {
                if (SceneManager.ActiveScene != null)
                {
                    SceneManager.Update(gameTime);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups: " + ex.ToString() + "\nTarget:>" + ex.TargetSite);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            if (SceneManager.ActiveScene != null)
            {
                GraphicsDevice.Clear(SceneManager.ActiveScene.BackgroundColor);
            }
            else
            {
                GraphicsDevice.Clear(Color.CornflowerBlue);
            }

            try
            {
                if (SceneManager.ActiveScene != null)
                {
                    SceneManager.Draw(gameTime);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups: " + ex.ToString() + "\nTarget:>" + ex.TargetSite);
            }
        }

        #endregion
    }
}
