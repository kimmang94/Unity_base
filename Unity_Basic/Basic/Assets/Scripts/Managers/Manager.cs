using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("@Manager");
        if (go == null)
        {
            go = new GameObject();
            go.GetComponentInChildren<Manager>();

        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
