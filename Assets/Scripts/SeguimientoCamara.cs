using System;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform jugador;
    
    public float limiteXMin;
    public float limiteXMax;
    public float limiteZMin;
    public float limiteZMax;

    public float velocidadSeguimiento = 5f;

    void LateUpdate()
    {
        Vector3 posicionDeseada = new Vector3(Mathf.Clamp(jugador.position.x, limiteXMin, limiteXMax), transform.position.y, Mathf.Clamp(jugador.position.z, limiteZMin,limiteZMax));

        transform.position = Vector3.Lerp(transform.position, posicionDeseada, velocidadSeguimiento * Time.deltaTime);
    }
}
