using System;
using System.Collections.Generic;
public abstract class Treasure : Collectable {
    public int Score { get; set; }

    public Treasure(string description, int score) {
        this.Description = description;
        this.Score = score;
    }

    public void UpdateTotalScore() {

        if (this.Board != null) {
            this.Board.TotalScore += this.Score;
        } // end of if statment 
    }

    public override void AddMe(List<Collectable> collectables) {
        collectables.Add(this);
        UpdateTotalScore();
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        Console.WriteLine($"Total Score is updated to: {this.Board.TotalScore}");
    }

    
    public override void Display() {
        Console.WriteLine($"{this.GetType().Name} {Description} is displayed");
    }
}
