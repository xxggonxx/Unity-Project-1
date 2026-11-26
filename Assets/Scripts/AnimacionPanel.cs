using UnityEngine;
using System.Collections;

public class AnimacionPanel : MonoBehaviour
{
    public RectTransform panel;
    public float duracion = 0.4f;
    public float escalaMaxima = 1.3f;

    private IEnumerator AnimarPanel(RectTransform panelSeleccionado)
    {
        float tiempo = 0f;

        Vector3 escalaOriginal = Vector3.one;
        Vector3 escalaGrande = Vector3.one * escalaMaxima;

        while (tiempo < duracion)
        {
            tiempo += Time.deltaTime;

            float progreso = tiempo / duracion;

            if (progreso < 0.5f)
            {
                panelSeleccionado.localScale = Vector3.Lerp(Vector3.zero, escalaGrande, progreso * 2);
            }
            else
            {
                panelSeleccionado.localScale = Vector3.Lerp(escalaGrande, escalaOriginal, (progreso - 0.5f) * 2f);
            }
            yield return null;
        }
        panelSeleccionado.localScale = escalaOriginal;
    }

    public IEnumerator PanelesAnimados(RectTransform panel)
    {
        yield return StartCoroutine(AnimarPanel(panel));
    }

}
