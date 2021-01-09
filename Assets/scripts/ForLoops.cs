using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    int counter = 0;
    bool[] array;
    void Start()
    {
        array = new bool[3];

        forLoopChecker();
    }
    public bool forLoopChecker() 
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = true;

            if (array[i]) counter++;

            Debug.Log("counter " + counter);
        }
        return true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
