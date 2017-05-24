using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cronometro : MonoBehaviour {

    public GameObject motorCarreterasGO;
    public MotorCarretera motorCarreterasScript;
    public float tiempo;
    public float distancia;
    public float score;
    public float lifes;
    public Text txtTiempo;
    public Text txtDistancia;
    public Text txtLifes;
    public Text txtScore;


    // Use this for initialization
    void Start () {
        motorCarreterasGO = GameObject.Find("MotorCarretera");
        motorCarreterasScript = motorCarreterasGO.GetComponent<MotorCarretera>();
        txtDistancia.text="0";
        txtTiempo.text = "00:00";
        score = 0;
        lifes = 1;
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (motorCarreterasScript.inicio == true && motorCarreterasScript.final == false)
        {
            CalculoTiempoDistancia();
            if (lifes == 0 && motorCarreterasScript.final==false)
            {
                motorCarreterasScript.final = true;
                motorCarreterasScript.JuegoEstados();
            }
        }
	}
    void CalculoTiempoDistancia()
    {
        txtScore.text = ((int)score).ToString();
        txtLifes.text = ((int)lifes).ToString();
        distancia += Time.deltaTime * motorCarreterasScript.velocidad;
        txtDistancia.text = ((int)distancia).ToString();

        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        txtTiempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');

       

        

    }
}
