using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = " new slot", menuName = "Inventory/ creete niventory slot")]
public class inventorySlot 
{
    public int ID;
    public Item item;
   
    public inventorySlot(int ID , Item item) 
    {
        this.ID = ID;
        this.item = item;
    }


}
