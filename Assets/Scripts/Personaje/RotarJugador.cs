using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarJugador : MonoBehaviour
{
    public float speedH;

    float yaw;

    public Transform Jugador;

    void Update()
    {
        yaw += speedH + Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        float mouseX = Input.GetAxis("Mouse X")*yaw* Time.deltaTime;
        Jugador.Rotate(Vector3.up * mouseX);
    }
}
