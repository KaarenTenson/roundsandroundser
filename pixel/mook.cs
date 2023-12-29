using Godot;
using System;

public partial class mook : Node2D
{
	private AnimationPlayer _animationPlayer;
	bool a=true;
	
	public override void _Input(InputEvent @event)
	{
		 
		if (@event is InputEventMouseButton eventMouseButton){
			_animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
			_animationPlayer.Play("new_animation");
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
			if (a==true){
				a=false;
			MoveSprite(0);
			}
		}
		else if (Input.IsActionPressed("ui_right")){
		if(a==false){
			a=true;
			MoveSprite(1);
		}
		Scale = new Vector2(1, 1);}
	}
	public void MoveSprite(int c)
	{
		// Get the current position of the sprite
		Vector2 currentPosition = Position;
		if (c==0){
		// Update the x-coordinate by adding one unit
		currentPosition+=new Vector2(-50,0);}
		else{
			currentPosition+=new Vector2(50,0);
		}

		// Set the new position for the sprite
		Position = currentPosition;
	}
	

}
