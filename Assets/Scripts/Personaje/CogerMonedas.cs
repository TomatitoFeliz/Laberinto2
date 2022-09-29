using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CogerMonedas : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI textMonedas;

    int monedas = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Moneda")
        {
            other.gameObject.SetActive(false);
            monedas++;
            textMonedas.text = monedas.ToString();
        }
    }
}
