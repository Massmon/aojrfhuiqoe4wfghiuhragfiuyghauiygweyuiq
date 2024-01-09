using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawExample
{
    internal class Example
    {
        Texture2D exampleTexture;
        public Example(Texture2D texture2D)
        {
            exampleTexture = texture2D;
        }


        //we are using this class because it is cleaner - less stuff
        public void Draw(SpriteBatch spriteBatch)
        {
            //a Texture2D is a custom data type that contains a bunch of colors at specific locations - aka an image
            //the question is how do we turn this into somthing on the screen
            //the spritebatch is a variable that tells the computer GPU to draw things
            // spriteBatch.Draw(); is used for drawing textures
            //there are a few overloads


            //Texture2D texture, Vector2 position, Color color
            spriteBatch.Draw(exampleTexture, new Vector2(40, 20), Color.White);
            //Texture2D texture is the texture to be drawn; self explanatory
            //Vector2 position is the location. If the texture is 256 pixels by 256 pixels, then its top left corner is at 40,20 (screenspace)
            //X & Y  in screenspace increases as you go the the bottom right
            //Top left hand corner is 0,0
            //Color is the color tint. White means no tint



            //Texture2D texture, Rectangle destinationRectangle, Color color
            spriteBatch.Draw(exampleTexture, new Rectangle(600, 200, 64, 64), Color.Green);
            //destination rectangle stretches the texture
            //so if it was originally 256,256, now it will be 64,64. So bottom right hand corner of texture is (100 + 64  , 200 + 64 ), or 164,264


            //Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color
            spriteBatch.Draw(exampleTexture, new Vector2(64, 300), new Rectangle(0, 0, 64, 64), Color.Blue);
            //Rectangle? sourceRectangle
            //Source rectangle is a funky one
            //notably, its Rectangle? not Rectangle.
            //the question mark means it can also be null, and a rectangle
            //it is so you can put null in there if you do not want to use it
            //otherwise, it specifices where from the original image you want to draw
            //useful for spritesheets
            //the unit is pixels on the original image
            //https://kidscancode.org/godot_recipes/4.x/img/adventurer_sprite_sheet_v1.1.png


            //Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color
            spriteBatch.Draw(exampleTexture, new Rectangle(500, 300, 128, 64), null,Color.Yellow);
            //this is combining two of the things above, destination and source
            //in this case, im putting null in for source rectangle
            //so it just ignores it

            //Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth
            spriteBatch.Draw(exampleTexture, new Vector2(500, 120), null, Color.Teal, MathHelper.ToRadians(45), new Vector2(128), 0.5f, SpriteEffects.None, 0);
            //this one is most confusing
            //rotation is in degrees, and rotates around the Origin, which is by default 0,0
            //origin changed using origin parameter
            //Scale is scale, 0.5 is half as big
            //Sprite effect allows you to mirror
            //layer depth is only used if the spritebatch begins with spritesortmode front to back or vice versa
            //we arent doing that here so it doesnt matter



            //thse two are similar - combinations of previous things
            //Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth
            //Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth
        }
    }


}
