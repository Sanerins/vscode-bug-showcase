using Godot;
using System;

public partial class main_menu : Node2D
{
	private void _on_quit_pressed()
	{
		GetTree().Quit();
	}


	private void _on_play_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/levels/level_1.tscn");
	}
}
