using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNumber : MonoBehaviour
{
    Text TextComponent;
    int number;

    private void Start()
    {
        TextComponent = GetComponent<Text>();
        number = getNumber();
    }

    public void increaseNumber()
    {
        number = getNumber();
        if(number < 8)
        {
            number++;
        }
        TextComponent.text = number.ToString();
    }

    public void decreaseNumber()
    {
        number = getNumber();
        if(number > 2)
        {
            number--;
        }
        TextComponent.text = number.ToString();
    }

    private int getNumber()
    {
        return int.Parse(TextComponent.text);
    }

}
