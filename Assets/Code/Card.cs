using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    Suit cardSuit;
    Value cardValue;
    public Card(Value cardValue, Suit cardSuit)
    {
        this.cardValue = cardValue;
        this.cardSuit = cardSuit;
    }
}
