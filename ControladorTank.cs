using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTank : MonoBehaviour {

    public GameObject tankGO;

    public float anguloGiro;
    public float velocidad;

	// Use this for initialization
	void Start () {
        tankGO = GameObject.FindObjectOfType<Tank>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        float giroEnZ = 0;
        
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal")* velocidad * Time.deltaTime);
        transform.Translate(Vector2.up * Input.GetAxis("Vertical") * velocidad * Time.deltaTime);
        giroEnZ = Input.GetAxis("Horizontal") * -anguloGiro;
        
        tankGO.transform.rotation = Quaternion.Euler(0,0, giroEnZ);
    }
}
