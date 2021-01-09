using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;


public class UIbutton : MonoBehaviour
{
    public newInventory suka;
    public DictionariesAndShit SukaBlyatvROtEbal;

    private static string filename;
    private string filePath;

    
    
    public Key key;
    public Sword sword;
    public  void Start() 
    {   
        filename = "/Newfile.json";
        filePath = Application.dataPath + filename;

      
        
        
        key.NoCustrctorsAreAllowed(0, "Super Unique Key", 0, 100);
        sword.NoCustrctorsAreAllowed(1, " Diamond Minecraft Sword lol))", 9999, 100);
        
    }

    public void SaveButton() 
    {
       // suka.addtpjsonaddtojson();
        SukaBlyatvROtEbal.SerializeDic(filePath, key, sword);

    }
    public void removeKey() 
    {
       // suka.addtpjsonaddtojson();
        SukaBlyatvROtEbal.removeKey(key);

    }public void removeSword() 
    {
       // suka.addtpjsonaddtojson();
        SukaBlyatvROtEbal.removeSword(sword);

    }

  


    public void LoadButton() 
    {
        

        if (File.Exists(filePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
     
            FileStream fs = File.Open(filePath, FileMode.Open);
            Debug.Log("IMMA TEST DAT BITCH " + fs.Length);

            string binaryDeserializer = bf.Deserialize(fs).ToString();

           JsonUtility.FromJsonOverwrite(binaryDeserializer, SukaBlyatvROtEbal);
           
            //SukaBlyatvROtEbal.LoadDataDict();
            fs.Close();
         
        }
        Debug.Log(SukaBlyatvROtEbal.getItem[12339].Name);
        //suka.getFromJsongetFromJson();
    }
    
}
