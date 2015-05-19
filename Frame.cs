using Microsoft.Xna.Framework.Graphics;
package com.ItakPC.plasmatic_rev.assets;

import java.awt.image.Texture2D;

namespace Plasma_Rev
{
    public class Frame
    {

        private Texture2D frame;
        private int duration;

        public Frame(Texture2D frame, int duration)
        {
            this.frame = frame;
            this.duration = duration;
        }

        public Texture2D getFrame()
        {
            return frame;
        }

        public void setFrame(Texture2D frame)
        {
            this.frame = frame;
        }

        public int getDuration()
        {
            return duration;
        }

        public void setDuration(int duration)
        {
            this.duration = duration;
        }
    }
}