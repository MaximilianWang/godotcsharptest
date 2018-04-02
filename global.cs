using Godot;
using System;

public class global : Control
{

    private int sceneChangeCount = 0;

    private Node currentScene = null;

    public override void _Ready()
    {  
        var root = GetTree().GetRoot();
        currentScene = root.GetChild( root.GetChildCount() - 1 );
        
    }

    public void GoToSchene(string path, string extra = "") {
        CallDeferred("deferredGoToScene", path, extra);

    } 

    private void deferredGoToScene(string path, string extra) 
    {

        currentScene.Free();
        PackedScene s = (PackedScene)ResourceLoader.Load(path, extra);
        currentScene = s.Instance();
        SceneTree sT = GetTree();
        sT.GetRoot().AddChild(currentScene);
        sT.SetCurrentScene(currentScene);

    }
}

