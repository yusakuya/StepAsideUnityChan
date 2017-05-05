using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //廃棄
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("削除");
    }
}
