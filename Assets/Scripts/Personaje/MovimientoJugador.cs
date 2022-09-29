using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float MX;
    public float MY;
    public float MZ;

    public float VM = 1.5f;
    bool shift = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shift = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            shift = false;
        }

        if (shift == true)
        {
            VM = 3f;
        }
        else if (shift == false)
        {
            VM = 1.5f;
        }
        MX = Input.GetAxis("Horizontal") * Time.deltaTime * VM;
        MZ = Input.GetAxis("Vertical") * Time.deltaTime * VM;
        transform.Translate(MX, MY, MZ);
    }
}
