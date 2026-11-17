using TMPro;
using UnityEngine;

public class SistemaColeccionables : MonoBehaviour
{
    public TMP_Text collectibleText;

    public int maxCollectibles = 5;
    private int currentCollectibles = 0;



    void Start()
    {
        TextoColeccionables();
    }

    public void TextoColeccionables()
    {
        collectibleText.text = "Coleccionables: " + currentCollectibles + "/" + maxCollectibles;
    }


    public void AgregarColeccionables()
    {
        currentCollectibles++;
        TextoColeccionables();
    }

    public int ObtenerColeccionables()
    {
        return currentCollectibles;
    }
    public int MaxColeccionables()
    {
        return maxCollectibles;
    }
}
