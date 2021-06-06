using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value
{
    int value;
    public Value(int value)
    {
        this.value = value;
    }

    //returns number 1-13
    public int getNumericValue()
    {
        return value;
    }

    //returns value shown on card
    public string getFaceValue()
    {
        if(value == 1)
        {
            return "A";
        }
        else if(value == 11)
        {
            return "J";
        }
        else if(value == 12)
        {
            return "Q";
        }
        else if(value == 13)
        {
            return "K";
        }
        else
        {
            return value.ToString();
        }
    }

}
