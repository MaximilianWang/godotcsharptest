using Godot;
using System;
public class splash : Node
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {  
        // Called every time the node is added to the scene.
        // Initialization here
        
    }


    private void _on_Button_pressed()
    {
        // Replace with function body
        GD.Print("HI");
        //var nextScene = G
        
		((GlobalFuncs)GetNode("/root/GlobalFuncs")).GoToSchene("res://game.tscn", "level-01");
        
        
    }


//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}

