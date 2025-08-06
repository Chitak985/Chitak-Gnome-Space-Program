using Godot;
using System;

public partial class ButtonDebug : Button
{
	[Export] Node3D craftManagerNode;
	
	public override void _Pressed(){
		GD.Print("h");
		Globals.Launching = true;
		craftManagerNode._Ready();	
	}
}
