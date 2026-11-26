using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject victoryPanel;
    public GameObject losePanel;

    public SistemaEstrellas sistemaEstrellas;
    public AnimacionEstrella animacionEstrella;
    public AnimacionPanel animacionVictoria;
    public AnimacionPanel animacionDerrota;


    public bool gameFinished = false;


    public void WinGame()
    {
        if(gameFinished)
        {
            return;
        }

        gameFinished = true;
        sistemaEstrellas.CalcularEstrellas();
        victoryPanel.SetActive(true);
        StartCoroutine(animacionVictoria.PanelesAnimados(animacionVictoria.panel));

        StartCoroutine(animacionEstrella.AnimarTodasLasEstrellas());
        Debug.Log("¡Ganaste!");

    }

    public void LoseGame()
    {
        if (gameFinished)
        {
            return;
        }

        gameFinished = true;
        losePanel.SetActive(true);
        StartCoroutine(animacionDerrota.PanelesAnimados(animacionDerrota.panel));
        Debug.Log("¡Perdiste!");

    }







}
