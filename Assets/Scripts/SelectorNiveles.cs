using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectorNiveles : MonoBehaviour
{
    public GameObject panelSeleccionNivel;
    public GameObject panelMenuPrincipal;
    public AnimacionPanel animacionPanel;

    public Sprite estrellaDorada;
    public Sprite estrellaGris;


    public Image[] estrellasNivel1;
    public Image[] estrellasNivel2;
    public Image[] estrellasNivel3;


   private void Start()
    {
        MostrarEstrellasNivel("Nivel1", estrellasNivel1);
        MostrarEstrellasNivel("Nivel2", estrellasNivel2);
        MostrarEstrellasNivel("Nivel3", estrellasNivel3);
    }


    public void MostrarEstrellasNivel(string nivelID, Image[] estrellas)
    {
        int mejorResultado = PlayerPrefs.GetInt(nivelID, 0);

        for (int i = 0; i < estrellas.Length; i++)
        {
            if(i < mejorResultado)
            {
                estrellas[i].sprite = estrellaDorada;
            }
            else
            {
                estrellas[i].sprite = estrellaGris;

            }
        }
    }

    public void AbrirSelectorDeNivel()
    {
        panelSeleccionNivel.SetActive(true);
        StartCoroutine(animacionPanel.PanelesAnimados(animacionPanel.panel));
    }
    public void CerrarSelectorDeNivel()
    {
        panelSeleccionNivel.SetActive(false);
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }


}
