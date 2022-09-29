using UnityEngine;

public class CámaraJugador : MonoBehaviour
{

    public Transform Jugador;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private void LateUpdate()
    {
        Vector3 desiredPosition = Jugador.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
