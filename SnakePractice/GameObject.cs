using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakePractice
{
    abstract class GameObject
    {
        private Vector2 position;
        private int width;
        private int height;
        private Texture2D texture;
        private Color tint;
        private Vector2 centerOrigin;

        public ref Color Tint => ref tint;
        public ref Vector2 Position => ref position;
        public ref int Height => ref height;
        public ref int Width => ref width;
        public ref Texture2D Texture => ref texture;
        public ref Vector2 CenterOrigin => ref centerOrigin; 
        public Rectangle Hitbox => new Rectangle(position.ToPoint(), texture.Bounds.Size);
        
        public void DebugDrawHitBox(SpriteBatch spriteBatch, Texture2D pixel)
        {
            spriteBatch.Draw(pixel, Hitbox, tint);
        }
        abstract public void Draw(SpriteBatch spriteBatch);
    }
}
