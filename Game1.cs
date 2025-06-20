﻿using Microsoft.Xna.Framework.Input;

/* Object-Oriented programming Assingment 5
 * The Final Boss Battle
 * 
 *
 * AI Declaration: No AI was used in development
 */


namespace OOPA5;

public class Game1 : Game
{
    //defaults
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    

    private Random _rng;
    private Texture2D _starRound;
    private Star _star;
    
    
    private Texture2D _stationC;
    private Station _station;
    
    private EnemyShip _enemyShip;
    private Texture2D _enemyShipTexture;

    // init player / receptacle
    //Player _player;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        
        // Custom Options
        Window.Title = "Space Saver: Lagrange Point 4"; 
        // Trivia: Largange Point 4 is a real point in space where gravity is mostly stable.
        // Some scientists believe it would be a suitable spot for a research station or satellite.
        
        
        // resize window
        _graphics.PreferredBackBufferWidth = 800;
        _graphics.PreferredBackBufferHeight = 800;
        _graphics.ApplyChanges();
        
        
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        
        
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

                
        //_player = new Player();
        
        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        
       
        
        _starRound = Content.Load<Texture2D>("sprites/stars/starRound");
        _star = new Star(_starRound);
        _stationC = Content.Load<Texture2D>("sprites/station/station_C");
        _station = new Station(_stationC);
        
        // Enemies!
        _enemyShipTexture = Content.Load<Texture2D>("sprites/enemy/enemy_B");
        _enemyShip = new EnemyShip(_enemyShipTexture, new Vector2(250,250), false); //polymorphism is broken here.
        
        Mouse.SetCursor(MouseCursor.FromTexture2D(Content.Load<Texture2D>("sprites/player/fireReceptacle"), 0, 0));
        // TODO: use this.Content to load your game content here
    }
    
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        
        // TODO: Add your update logic here

        
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        
        Console.WriteLine("Stars Count: " + _star.GetNumbStars()); // debug info
        _star.Draw(_spriteBatch); // draw background stars
        
        _station.Draw(_spriteBatch); // Draw space station
        
        // Draw an enemy
        _enemyShip.Draw(_spriteBatch);
        
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}