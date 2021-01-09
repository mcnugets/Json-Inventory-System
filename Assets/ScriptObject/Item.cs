using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Item", menuName ="inventory/create an item")]
public class Item : ScriptableObject
{

    public int ID;
    public string Name;
    public int Damage;
    public int Durability;

    public virtual void NoCustrctorsAreAllowed(int ID, string Name, int Damage, int Durability) 
    {
        this.ID = ID;
        this.Name = Name;
        this.Damage = Damage;
        this.Durability = Durability;
    }

}
