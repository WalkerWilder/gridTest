using Godot;
using System;

public class Position : Node
{
  int Line;
  int Column;
  public Position(int l, int c)
  {
    this.Line = l;
    this.Column = c;
  }

  public string PosName()
  {
    return $"L{this.Line}|C{this.Column}";
  }
}
