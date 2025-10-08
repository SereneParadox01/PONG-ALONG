using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	[Export] public float speed = 400f;
	private Vector2 _direction = new Vector2(1, 1).Normalized();
	public override void _Ready()
	{
		//random direction ball launch
		float angle = (float)GD.RandRange(-.5, .5);
		_direction = new Vector2(1, angle).Normalized();
	}
	public override void _PhysicsProcess(double delta)
	{
		Velocity = _direction * speed;
		MoveAndSlide();
	}
}
