using Godot;
using System;

public class Tile : Area2D
{
  Position position;
  // Declare member variables here. Examples:
  // private int a = 2;
  // private string b = "text";
  public Tile(Position pos)
  {
    this.position = pos;
  }

  public void Test(){
    Console.WriteLine("Teste");
  }

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {

  }

  //  // Called every frame. 'delta' is the elapsed time since the previous frame.
  //  public override void _Process(float delta)
  //  {
  //      
  //  }
}
