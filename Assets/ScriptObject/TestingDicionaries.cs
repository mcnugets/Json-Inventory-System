using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDicionaries : MonoBehaviour
{

    Dictionary<int, string> sukaStul;
    Dictionary<string, int> sukajebniyStul;

    Dictionary<Dictionary<int, string>, Dictionary<string, int>> lol;
    // Start is called before the first frame update
    void Start()
    {
        sukaStul = new Dictionary<int, string>();
        sukajebniyStul = new Dictionary<string, int>();
        lol = new Dictionary<Dictionary<int, string>, Dictionary<string, int>>();
        sukaStul.Add(1, "numbah one");
        sukajebniyStul.Add("suka", 3);
        lol.Add(sukaStul, sukajebniyStul);
        foreach (var lolIndeed in lol)
        {
            foreach (var key in lolIndeed.Key)
            {
                foreach (var value in lolIndeed.Value)
                {
                    Debug.Log("VALUES FROM KEY " + key.Value );
                    Debug.Log("VALUES FROM VALUES " + value.Value);
                }

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
