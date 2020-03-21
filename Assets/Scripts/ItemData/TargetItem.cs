using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetItem: MonoBehaviour
{
    [SerializeField] private Item item = null;                 //Item belonging to the info target
    [SerializeField] InfoDisplay infoDisplay = null;           //Reference to the Info display object in the scene

    public void DisplayItemInfo()
    {
        //Display this item info
        infoDisplay.SendMessage("ShowInfo", item);
    }

    public void HideItemInfo()
    {
        //Hide item info
        infoDisplay.SendMessage("HideInfo");
    }
}
