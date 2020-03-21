using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoDisplay : MonoBehaviour
{
    [Header("Item Name Info")]
    [SerializeField] private GameObject itemNameObject;
    [SerializeField] private TextMeshProUGUI nameText;

    [Header("Item Description Info")]
    [SerializeField] private GameObject textBox;
    [SerializeField] private TextMeshProUGUI descriptionText;

    public void ShowInfo(Item item)
    {
        //Set the text of the name text
        nameText.text = item.itemName;

        //Enable the name text
        itemNameObject.SetActive(true);

        //Set the text of the text
        descriptionText.text = item.description;

        //Enable the text box item
        textBox.SetActive(true);
    }

    public void HideInfo()
    {
        //Disable the name text
        itemNameObject.SetActive(false);

        //Disable the text box
        textBox.SetActive(false);
    }
}
