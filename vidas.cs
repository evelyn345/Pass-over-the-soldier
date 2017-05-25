using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas : MonoBehaviour
{

    public GameObject cronometroGO;
    public Cronometro cronometroScript;

    private void Start()
    {
        cronometroGO = GameObject.FindObjectOfType<Cronometro>().gameObject;
        cronometroScript = cronometroGO.GetComponent<Cronometro>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Tank>() != null)
        {
            cronometroScript.lifes = cronometroScript.lifes + 1;
            Destroy(this.gameObject);

        }
    }
}
