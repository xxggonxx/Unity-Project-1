using UnityEngine;

public class SistemaEstrellas : MonoBehaviour
{
    public SistemaColeccionables coleccionables;
    public SistemaVidas vidas;
    public Cronometro tiempo;
    public GameManager manager;

    private int estrellasConseguidas = 0;
    public float tiempoObjetivo = 60f;


    public void CalcularEstrellas()
    {
        estrellasConseguidas++;
        Debug.Log("estrella x completar nivel");
       
       int checkColectibles = coleccionables.ObtenerColeccionables();
        if(checkColectibles == coleccionables.MaxColeccionables())
        {
            estrellasConseguidas++;
            Debug.Log("estrella x coleccionables");
        }
        int checkLife = vidas.ObtenerVidasActuales();
        if(checkLife == vidas.VidasMaximas())
        {
            estrellasConseguidas ++;
            Debug.Log("estrella x vidas");
        }

        float tiempoFinal = tiempo.TimePassed();
        if(tiempoFinal <= tiempoObjetivo)
        {
            estrellasConseguidas++;
            Debug.Log("estrella x tiempo");
        }
    }


}
