using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monotest;

public class Game1 : Game
{
    
    Texture2D melvin; 
    Microsoft.Xna.Framework.Vector2 melvinposition;
    float melvinspeed;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        melvinposition = new Microsoft.Xna.Framework.Vector2(_graphics.PreferredBackBufferWidth / 2,
                                                            _graphics.PreferredBackBufferHeight / 2);

        melvinspeed = 100f; 

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here

// declared the render type for melvin 
        melvin = Content.Load<Texture2D>("melvin");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

    
        // TODO: Add your update logic here
        

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
// TODO: Add your drawing code here

// render for melvin
    _spriteBatch.Begin();
    _spriteBatch.Draw(melvin, 
    melvinposition, 
    null, 
    Color.White, 
    0f, 
    new Microsoft.Xna.Framework.Vector2(melvin.Width / 2, melvin.Height / 2), 
    Microsoft.Xna.Framework.Vector2.One, 
    SpriteEffects.None,
    0f
    
    );
    
    
    _spriteBatch.End();
        
        base.Draw(gameTime);
    }
}
