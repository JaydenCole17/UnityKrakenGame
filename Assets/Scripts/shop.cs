using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private shopItem[] _shopItem;

    [Header("References")]
    [SerializeField] private Transform _shopContainer;
    [SerializeField] private GameObject _shopItemPrefab;

    public TextMeshProUGUI displayItemName;
    public TextMeshProUGUI displayItemDescription;
    public TextMeshProUGUI displayItemCost;
    public Image displayItemIMG;

    private void Start()
    {
        populateShop();
    }

    private void populateShop()
    {
        for (int i = 0; i < _shopItem.Length; i++)
        {
            shopItem shopObject = _shopItem[i];
            GameObject itemObject = Instantiate(_shopItemPrefab, _shopContainer);
            

            itemObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(shopObject));

            itemObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = shopObject._itemName;
            itemObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = shopObject._itemDescription;
            itemObject.transform.GetChild(2).GetComponent<Image>().sprite = shopObject._itemSprite;
            itemObject.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = shopObject._itemCost.ToString();
            itemObject.GetComponent<Image>().color = shopObject._itemRarity;
        }
    }

    private void OnButtonClick(shopItem item)
    {
        Debug.Log(item.name);
        displayItemName.text = item._itemName;
        displayItemDescription.text = item._itemDescription;
        displayItemCost.text = item._itemCost.ToString();
        displayItemIMG.sprite = item._itemSprite;
    }
}
