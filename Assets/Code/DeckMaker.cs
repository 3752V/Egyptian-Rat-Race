using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckMaker
{
    public Deck CreateFullSortedDeck()
    {
        List<Card> cards = new List<Card>();
        for (int currentIndex = 0; currentIndex < 52; currentIndex++)
        {
            int currentValue = (currentIndex % 13) + 1;
            Value value = new Value(currentValue);
            int currentSuit = (currentIndex / 13) + 1;
            Suit suit = new Suit(currentSuit);
            Card card = new Card(value, suit);
            cards.Add(card);
        }
        Deck fullDeck = new Deck(cards);
        return fullDeck;
    }

    public Deck CreateFullShuffledDeck()
    {
        Deck deck = CreateFullSortedDeck();
        deck.shuffle();
        return deck;
    }
}
