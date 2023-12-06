using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Shop item")]
public class shopItem : ScriptableObject
{
    public string _itemName;
    [TextArea(15,20)]
    public string _itemDescription;
    public Sprite _itemSprite;
    public int _itemCost;
    public Color _itemRarity;
}
