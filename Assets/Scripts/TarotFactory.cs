using UnityEngine;

public class TarotFactory
{
    private static int _majorArcanaCardSum = 22;

    public static TarotCard CreateRandomCard()
    {
        var cardNum = Random.Range(0, _majorArcanaCardSum);
        var isReverse = (Random.Range(0, 2)%2) == 0;
        
        return new TarotCard(cardNum, isReverse);
    }
}
