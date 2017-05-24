using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour {
  
	// Use this for initialization
	void Start () {

      
       
    }

    
    public void FadeOut(int x)
    {
        SceneManager.LoadScene(x);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
