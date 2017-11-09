using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisIsAScript : MonoBehaviour {

    static ThisIsAScript instance = null;
	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            print("Duplicate music is deleted");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
