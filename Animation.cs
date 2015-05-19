using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Plasma_Rev
{
    public class Animation
    {

        private int frameCount;                 // Counts ticks for change
        private int frameDelay;                 // frame delay 1-12 (You will have to play around with this)
        private int currentFrame;               // animations current frame
        private int animationDirection;         // animation direction (i.e counting forward or backward)
        private int totalFrames;                // total amount of frames for your animation

        private bool stopped;                // has animations stopped

        private List<Frame> frames = new List<Frame>();    // List of frames 

        public Animation(Texture2D[] frames, int frameDelay)
        {
            this.frameDelay = frameDelay;
            this.stopped = true;

            for (int i = 0; i < frames.Length; i++)
            {
                addFrame(frames[i], frameDelay);
            }

            this.frameCount = 0;
            this.frameDelay = frameDelay;
            this.currentFrame = 0;
            this.animationDirection = 1;
            this.totalFrames = this.frames.Count;

        }

        public Animation(Texture2D frame, int frameDelay)
        {
            this.frameDelay = 0;
            this.stopped = true;

            addFrame(frame, 0);

            this.frameCount = 1;
            this.currentFrame = 0;
            this.animationDirection = 1;
            this.totalFrames = 1;

        }

        public void start()
        {
            if (!stopped)
            {
                return;
            }

            if (frames.Count == 0)
            {
                return;
            }

            stopped = false;
        }

        public void stop()
        {
            if (frames.Count == 0)
            {
                return;
            }

            stopped = true;
        }

        public void restart()
        {
            if (frames.Count == 0)
            {
                return;
            }

            stopped = false;
            currentFrame = 0;
        }

        public void reset()
        {
            this.stopped = true;
            this.frameCount = 0;
            this.currentFrame = 0;
        }

        private void addFrame(Texture2D frame, int duration)
        {
            if (duration <= 0)
            {
                Console.WriteLine("Invalid duration: " + duration);
                throw new Exception("Invalid duration: " + duration);
            }

            frames.Add(new Frame(frame, duration));
            currentFrame = 0;
        }

        public Texture2D getSprite()
        {
            return frames[currentFrame].getFrame();
        }

        public void update()
        {
            if (!stopped)
            {
                frameCount++;

                if (frameCount > frameDelay)
                {
                    frameCount = 0;
                    currentFrame += animationDirection;

                    if (currentFrame > totalFrames - 1)
                    {
                        currentFrame = 0;
                    }
                    else if (currentFrame < 0) {
                        currentFrame = totalFrames - 1;
                    }
                }
            }
        }
    }
}