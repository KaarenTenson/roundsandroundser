using Godot;
using System;

public partial class mook : Node2D
{
	
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseButton eventMouseButton){
			}
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_left"))
		{
			// Move the player right
			Scale = new Vector2(-1, 1);
		}
		else{
		Scale = new Vector2(1, 1);
	}
	}
	

}
