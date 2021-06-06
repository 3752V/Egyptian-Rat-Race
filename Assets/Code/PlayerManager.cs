using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
    private static int players;

    public static void setPlayers(int newPlayers)
    {
        players = newPlayers;
    }

    public static int getPlayers()
    {
        return players;
    }

}
