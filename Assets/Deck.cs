using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    List<Card> cards;
    public Deck ()
    {

    }
    public Deck (List<Card> cards)
    {
        this.cards = cards;
    }

    public void shuffle()
    {
        int randomIndex;
        List<Card> newDeck = new List<Card>();
        for(int i = 0; i < cards.Count; i++)
        {
            randomIndex = Random.Range(0, cards.Count - 1);
            Card currentCard = cards[randomIndex];
            cards.RemoveAt(randomIndex);
            newDeck.Add(currentCard);
        }
        cards = newDeck;
    }

    public Card getTopCard()
    {
        return cards[0];
    }

    public List<Card> getDeck()
    {
        return cards;
    }

    public void addCardToBottom(Card card)
    {
        cards.Add(card);
    }

    public void removeTopCard()
    {
        cards.RemoveAt(0);
    }

    public int getDeckSize()
    {
        return cards.Count;
    }

}
