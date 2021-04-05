using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class PlayerHealth
{
    static public int playerHealth = 100;

    static public void ResetPlayerHealth()
    {
        playerHealth = 100;
        Debug.Log("Reseting Player's Health...");
    }

    public static void AddPlayerHealth(int mod)
    {
        playerHealth += mod;
    }

    public static void RemovePlayerHealth(int mod)
    {
        playerHealth -= mod;
    }
}