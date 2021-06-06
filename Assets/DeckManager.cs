using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public ChangeNumber changeNumber;
    List<Deck> playerDecks = new List<Deck>();
    public void CreatePlayerHands()
    {
        int players = PlayerManager.getPlayers();
        for (int i = 0; i < players; i++)
        {
            playerDecks.Add(new Deck());
        }
        DeckMaker maker = new DeckMaker();
        Deck shuffledDeck = maker.CreateFullShuffledDeck();
        for (int currentIndex = 0; currentIndex < shuffledDeck.getDeckSize(); currentIndex++)
        {
            playerDecks[currentIndex % 4].addCardToBottom(shuffledDeck.getTopCard());
            shuffledDeck.removeTopCard();
        }
    }
}
