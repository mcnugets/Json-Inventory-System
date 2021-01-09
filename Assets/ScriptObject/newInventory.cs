using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;

public class newInventory : MonoBehaviour
{

    public inventorySlot invSlot;
    [HideInInspector] public string filename;
    [HideInInspector] public string filePath;
    // Start is called before the first frame update
    void Start()
    {
        

        filename = "/Newfile.json";
        filePath = Application.dataPath + filename;

       // addToJson(filePath);
    }

    public void addtpjsonaddtojson() 
    {
        //addToJson(filePath);
    }
    public void getFromJsongetFromJson() 
    {
        getFromJson(filePath);
    }

   private void addToJson(string file, Key key, Sword sword) 
    {
        getContainer getThis;
        Container[] contain;
        contain = new Container[2];

        

       
        invSlot = new inventorySlot(key.ID, key);


       
        contain[key.ID] = new Container(invSlot);

        getThis = new getContainer(contain);
        
        string jsonString = JsonUtility.ToJson(getThis, true);
        File.WriteAllText(file, jsonString);
        Debug.Log(jsonString);
    }

   public  void getFromJson(string file) 
    {
        getContainer getThat;

        string readDatShit = File.ReadAllText(file);
        getThat = JsonUtility.FromJson<getContainer>(readDatShit);

        Debug.Log(getThat.containThat[1].invevtorySlot.item.Name);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Container
{
    public inventorySlot invevtorySlot;


    public Container(inventorySlot invevtorySlot)
    {
        this.invevtorySlot = invevtorySlot;

    }
}

[System.Serializable]
public class getContainer
{
    public Container[] containThat;


    public getContainer(Container[] containThat)
    {
        this.containThat = containThat;

    }
}


