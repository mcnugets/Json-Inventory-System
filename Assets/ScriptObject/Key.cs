using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "DATA BASE", menuName = "Inventory/ create a key")]
public class Key : Item
{
   


    public override void NoCustrctorsAreAllowed(int ID, string Name, int Damage, int Durability) 
    { 
        this.ID = ID;
        this.Name = Name;
        this.Damage = Damage;
        this.Durability = Durability;
        
    }
    
}
