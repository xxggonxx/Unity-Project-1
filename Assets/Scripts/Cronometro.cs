using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public TMP_Text timeText;

    public float timePassed = 0f;

    public GameManager gameManager;


    // Update is called once per frame
    void Update()
    { 

        if(gameManager.gameFinished)
        {
            return;
        }
        timePassed += Time.deltaTime;
        ActualizarTexto();
    }


    void ActualizarTexto()
    {
        int minutes = Mathf.FloorToInt(timePassed / 60);
        int seconds = Mathf.FloorToInt(timePassed % 60);

        timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public float TimePassed()
    {
        return timePassed;
    }
}
