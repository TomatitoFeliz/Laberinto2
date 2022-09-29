using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cogerlllave : MonoBehaviour
{
    int llave = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Llave")
        {
            other.gameObject.SetActive(false);
            llave++;
        }
    }
}

