using Godot;
using System;

public partial class Bullett : RigidBody3D
{
	int timer1 = 0;
	public override void _PhysicsProcess(double delta)
	{
		timer1++;
		if(timer1 >= 100){
			this.QueueFree();
		}
	}
}
