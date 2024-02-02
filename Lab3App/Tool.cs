using System;
using System.Collections.Generic;

public abstract class Tool : Collectable
{
    public Tool(string description) {
        Description = description;
    }

    public abstract void DoAction();

    public override void AddMe(List<Collectable> collectables) {
        collectables.Add(this);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        DoAction();
    }
}


