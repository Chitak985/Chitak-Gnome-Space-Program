using Godot;
using System;
using System.Collections.Generic;

public partial class GunInline : PartModule
{
	[Export] public PackedScene bulletPrefab;
	private PartDefinition rb3D;

	public override void _Ready()
	{
		rb3D = (PartDefinition)GetParent();
	}

	public override void _PhysicsProcess(double delta)
	{
		if (enabled)
		{
			Vector3 direction = GlobalTransform.Basis.Y;
			
			if(Input.IsKeyPressed(Key.Space)){
				RigidBody3D tmp = bulletPrefab.Instantiate() as RigidBody3D;
				GetTree().GetRoot().AddChild(tmp);
				tmp.GlobalPosition = rb3D.GlobalPosition;
				tmp.ApplyImpulse(direction*100, Position);
			}
		}
	}
}
