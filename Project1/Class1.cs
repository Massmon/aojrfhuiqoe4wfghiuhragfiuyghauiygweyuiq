using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project1;
using System;
using System.Drawing;

public class Class1
{
    private Texture2D Button;
    public Microsoft.Xna.Framework.Rectangle ButtonRectangle;
    public Class1(Texture2D texture, Vector2 position)
	{
	    Button = texture;

        ButtonRectangle = new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, Button.Width, Button.Height);


    }
    public void draw(SpriteBatch _spriteBatch)
    {
        Microsoft.Xna.Framework.Color myColor = Microsoft.Xna.Framework.Color.Aqua;
        _spriteBatch.Draw(Button, new Vector2(20, 20), myColor);
    }
    
}
