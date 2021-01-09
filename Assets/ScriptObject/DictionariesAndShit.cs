using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;

[System.Serializable]
[CreateAssetMenu(fileName = "DATA BASE", menuName = "Inventory/ dictionaries")]
public class DictionariesAndShit : ScriptableObject, ISerializationCallbackReceiver
{
   
    public const int numberOfSlots = 3;
    public List<inventorySlot> inventory_slot;
    public Dictionary<int, Item> getItem;
    public Dictionary<Item, int> getID;


  


    // public inventorySlot[] invSlot;



 

    public void SerializeDic(string file, Key key, Sword sword) {




            getItem.Add(key.ID, key);
            getItem.Add(sword.ID, sword);
            //tItem.Add(sword.ID, sword);
            foreach (var itemDicionary in getItem)
            {

                getID.Add(itemDicionary.Value, itemDicionary.Key);

                Debug.Log("TESTING INDEX OF DICTIONARY " + itemDicionary.Value);
            }




            //Debug.Log("get id counter " + getID.Count);
            Save(file);
        
    }
    public void Save(string suka)
    {
        string toJson = JsonUtility.ToJson(this, true);

        // File.WriteAllText(file, toJson);

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Open(suka, FileMode.Create);


        bf.Serialize(fs, toJson);
        
        fs.Close();

    }
    public void removeKey(Key key) 
    {
        int[] localArray = new int[getItem.Count];
        foreach (var getDick in getItem)
        {
            for (int i = 0; i < localArray.Length; i++)
            {
                localArray[i] = getDick.Key;
                break;
            }
        }
        for (int i = 0; i < localArray.Length; i++)
        {
            Debug.Log("TESITNG for local araray " + localArray[i]);
        }
        foreach (var items in localArray)
        {
           
            if (items == key.ID)
            {

               getID.Remove(key);
                getItem.Remove(items);
              

            }
        }





    }
    public void removeSword(Sword sword)
    {
        int[] localArray = new int[getItem.Count];
        foreach (var getDick in getItem)
        {
            for (int i = 0; i < localArray.Length; i++)
            {
                localArray[i] = getDick.Key;
                break;
            }
        }
        for (int i = 0; i < localArray.Length; i++)
        {
            Debug.Log("TESITNG for local araray " + localArray[i]);
        }
        foreach (var items in localArray)
        {

            if (items == sword.ID)
            {
                getID.Remove(sword);
                getItem.Remove(items);
             
            }
        }


    }


    public void OnBeforeSerialize()
    {


        inventory_slot.Clear();

        foreach (var item in getItem)
        {
            inventory_slot.Add(new inventorySlot(getID[item.Value], item.Value));
         
        }

       

        
    }
    

    public void OnAfterDeserialize()
    {
        getItem = new Dictionary<int, Item>();
        getID = new Dictionary<Item, int>();

        foreach (var invslot in inventory_slot)
        {
            getItem.Add(invslot.ID, invslot.item);
            getID.Add(invslot.item, invslot.ID);
        }
            
        
    }
} 
[System.Serializable]
public class containDicitonary
{

   public Dictionary<int, Item> getDic;

    public containDicitonary(Dictionary<int, Item> getDic) 
    {
        this.getDic = getDic;
    }

}
