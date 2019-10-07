using System;

public class TarotCard
{
    public int Id;
    public bool IsReverse;

    public TarotCard(int id, bool isReverse)
    {
        Id = id;
        IsReverse = isReverse;
    }

    public string GetID()
    {
        return Id + "_" + Convert.ToInt32(IsReverse);
    }
}
