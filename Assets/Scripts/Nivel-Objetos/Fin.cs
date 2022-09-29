using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fin : MonoBehaviour
{
    [SerializeField]
    GameObject PantallaFinal;

    [SerializeField]
    TextMeshProUGUI textTiempo;

    float tiempoPartida = 0.0f;
    bool estaJugando = true;
    private void Update()
    {
        
        if (estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Player")
        {
            PantallaFinal.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            estaJugando = false;
            textTiempo.text = tiempoPartida.ToString();
        }
    }
}
