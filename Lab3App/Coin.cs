using Lab3App;
using System.Collections.Generic;

public class Coin : Treasure {
    public int Value { get; set; }

    public Coin(string description, int score, int value) : base(description, score) {
        Value = value;
    }

    public void UpdateTotalValue(CollectionBoard board) {
        board.TotalValue += Value;
    }

   
    public override void AddMe(List<Collectable> collectables) {
        base.AddMe(collectables); 
        if (this.Board != null)
        {
            UpdateTotalValue(this.Board);
        }
    }
}
