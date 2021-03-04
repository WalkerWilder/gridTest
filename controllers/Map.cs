using Godot;
using System;
using System.Collections.Generic;

public class Map : Node
{
  private List<Tile> tiles = new List<Tile>();
  private Dictionary<string, Tile> tileMap = new Dictionary<string, Tile>();
  // Declare member variables here. Examples:
  // private int a = 2;
  // private string b = "text";

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
    for (int l = 0; l < 8; l++)
    {
      for (int c = 0; c < 8; c++)
      {
        Position pos = new Position(l, c);
        Tile tile = new Tile(pos);
        tileMap.Add(pos.PosName(), tile);

        this.GetNode(".").AddChild(tile);
      }
    }
    Tile t = null;
    if (!tileMap.TryGetValue("L2|C4", out t)){
      Console.WriteLine("Não encontrado");
    } else {
      t.Test();
    }

  }

  //  // Called every frame. 'delta' is the elapsed time since the previous frame.
  //  public override void _Process(float delta)
  //  {
  //      
  //  }
}