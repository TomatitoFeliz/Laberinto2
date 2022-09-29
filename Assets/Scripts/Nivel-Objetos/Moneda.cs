using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public Transform Coin;
    public float velocidad = 4.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Coin.Rotate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
