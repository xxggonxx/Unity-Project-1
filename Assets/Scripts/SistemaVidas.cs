using UnityEngine;
using TMPro;
using System.Collections;

public class SistemaVidas : MonoBehaviour
{
    public int maxLife = 3;
    private int currentLife;

    public float invulnerabilityTime = 1f;
    private bool invulnerable = false;

    private Renderer playerRenderer;

    public TMP_Text lifeText;
    public GameManager gameManager;
    public ParticleSystem particulasExplosion;


    void Start()
    {
        currentLife = maxLife;
        playerRenderer = GetComponent<Renderer>();
        ActualizarTexto();
    }


    void ActualizarTexto()
    {
        lifeText.text = "Vidas: " + currentLife + "/" + maxLife;
    }

    public void RestLife()
    {
        if(invulnerable || gameManager.gameFinished)
        {
            return;
        }

        currentLife--;
        ActualizarTexto();
        if(currentLife <= 0)
        {
            ParticleSystem explotar = Instantiate(particulasExplosion, transform.position, Quaternion.identity);
            explotar.Play();
            playerRenderer.enabled = false;
            gameManager.LoseGame();
            return;
        }

        StartCoroutine(InvulnerabilityPeriod());
    }

    IEnumerator InvulnerabilityPeriod()
    {
        invulnerable = true;
        StartCoroutine(EfectoParpadeo());

        yield return new WaitForSeconds(invulnerabilityTime);

        invulnerable = false;
    }

    IEnumerator EfectoParpadeo()
    {
        while (invulnerable)
        {
            playerRenderer.enabled = !playerRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        playerRenderer.enabled = true;
    }

    public int ObtenerVidasActuales()
    {
        return currentLife;
    }

    public int VidasMaximas()
    {
        return maxLife;
    }
  
}
