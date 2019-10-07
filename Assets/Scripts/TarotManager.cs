using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TarotManager : MonoBehaviour
{
    public List<TarotCard> TarotCards = new List<TarotCard>();
    
    public void PickOneTarot()
    {
        TarotCard card;
        while (true)
        {
            card = TarotFactory.CreateRandomCard();
            if (TarotCards.All(c => c.Id != card.Id))
                break;
        }

        TarotCards.Add(card);
    }

    public void PickTarot(int cardNum)
    {
        for (var i = 0; i < cardNum; i++)
        {
            PickOneTarot();
        }
    }

    public void Reset()
    {
        TarotCards.Clear();
    }
}
