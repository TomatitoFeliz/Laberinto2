using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRatón : MonoBehaviour
{
    public float speedH;
    public float speedV;
    public float LMax = -60;
    public float LMin = 90;

    float yaw;
    float LR;
    float pitch;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH + Input.GetAxis("Mouse X");
        LR += speedH + Input.GetAxis("Mouse X");
        pitch -= speedV + Input.GetAxis("Mouse Y");

        LR = pitch;
        LR = Mathf.Clamp(LR, LMin, LMax);

        transform.eulerAngles = new Vector3(LR, yaw, 0);
    }
}
