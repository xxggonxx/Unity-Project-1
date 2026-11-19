using UnityEngine;

public class SistemaProgreso : MonoBehaviour
{
    
    public void GuardarMejorResultado(string nivelID, int estrellas)
    {
            int mejorResultado = ObtenerMejorResultado(nivelID);
            if(estrellas > mejorResultado)
            {
                PlayerPrefs.SetInt(nivelID, estrellas);
            }
    }


    public int ObtenerMejorResultado(string nivelID)
    {
        return PlayerPrefs.GetInt(nivelID,0);
    }
}
