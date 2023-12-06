using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class purchaseItem : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemCost;

    public void buyItem()
    {
        if(int.TryParse(itemCost.text, out int Cost))
        Debug.Log("The player attempted to buy: " + itemName.text + " for " + Cost + " currency "); 
        /* 
         * if the developer wants to use currency in this game,
         * Cost is now an integer variable that holds the price
         * of whatever item the player was trying to buy. 
         * This could be used to subtract from a player balance
         * if the developer descides to use currency
        */ 
    }
}
