using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suit
{
    int suit;
    public Suit(int suit)
    {
        this.suit = suit;
    }

    public int getSuitValue()
    {
        return suit;
    }

    public string getSuitFaceValue()
    {
        if(suit == 1)
        {
            return "D";
        }
        else if(suit == 2)
        {
            return "H";
        }
        else if(suit == 3)
        {
            return "C";
        }
        else if (suit == 4)
        {
            return "S";
        }
        else
        {
            Debug.LogError("Invalid Suit Value: " + suit);
            return "";
        }
    }

}
