using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

public class jsonAndDicitonaries : MonoBehaviour
{
    



    public Item[] itemData;
    public inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        //Inventory = new inventory[3];
       
        itemData = new Item[3];
      

        string filename = "/Newfile.json";
     string filePath = Application.dataPath + filename;


        saveNaA(filePath);


    }

    public void savePlauerStats(string file) 
    {
       // itemData[0] = new Item(0, "Sword", 34, 100);
        //itemData[1] = new Item(1, "staff", 67, 54);
        //itemData[2] = new Item(2, "axe", 88, 60);


        for (int i = 0; i < itemData.Length; i++)
        {
            string lol = JsonUtility.ToJson(itemData[i], true);
            File.AppendAllText(file, lol);
        }
       
        //Debug.Log(lol);



    }


    public void saveNaA(string file) 
    {
      

        //string lol = JsonUtility.ToJson(inventory, true);
       // File.WriteAllText(file, lol);
        //Debug.Log(lol);
        




    }
    public void loadNaA(string file) 
    {
        inventory naa2;
        string loadDatShit = File.ReadAllText(file);
        naa2 = JsonUtility.FromJson<inventory>(loadDatShit);

       // Debug.Log("Name:" + naa2.name);
      //  Debug.Log("Age:" + naa2.age);


    }
    // Update is called once per frame

  



}







[System.Serializable]
public class inventory
{
    public Item[] itemObeject;
    

  public inventory(Item[] itemObeject) 
    {
        this.itemObeject = itemObeject;
        
    }
}[System.Serializable]
public class inventoryContain
{
    public inventory Inventory;
    

  public inventoryContain(inventory Inventory)
    {
        this.Inventory = Inventory;
        
    }
}

