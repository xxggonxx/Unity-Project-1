using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject victoryPanel;
    public GameObject losePanel;

    public SistemaEstrellas sistemaEstrellas;

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
        Debug.Log("¡Perdiste!");

    }







}
