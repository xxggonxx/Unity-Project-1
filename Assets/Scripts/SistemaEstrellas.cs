using UnityEngine;
using UnityEngine.UI;
public class SistemaEstrellas : MonoBehaviour
{
    public SistemaColeccionables coleccionables;
    public SistemaVidas vidas;
    public SistemaProgreso sistemaProgreso;
    public Cronometro tiempo;
    public GameManager manager;

    public Image[] estrellas;
    public Sprite estrellaDorada;
    public Sprite estrellaGris;
    public string nivelID = "Nivel1";


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
        MostrarEstrellas();

        Debug.Log("conseguiste" +  estrellasConseguidas);

        sistemaProgreso.GuardarMejorResultado(nivelID, estrellasConseguidas);
        Debug.Log(sistemaProgreso.ObtenerMejorResultado(nivelID));
    }

    public void MostrarEstrellas()
    {
        for (int i = 0; i < estrellas.Length; i++)
        {
            if( i < estrellasConseguidas)
            {
                estrellas[i].sprite = estrellaDorada;
            }
            else
            {
                estrellas[i].sprite = estrellaGris;

            }
        }
    }


}
