using System.Collections;
using UnityEngine;

public class AnimacionEstrella : MonoBehaviour
{
    public RectTransform[] estrellas;
    public float tiempoEntreEstrellas = 0.3f;
    public float duracionAnimacion = 0.4f;

    private IEnumerator AnimarEstrella(RectTransform estrella)
    {
        float tiempo = 0f;

        Vector3 escalaOriginal = Vector3.one;
        Vector3 escalaMaxima = Vector3.one * 1.3f;

        while(tiempo < duracionAnimacion)
        {
            tiempo += Time.deltaTime;

            float progreso = tiempo / duracionAnimacion;

            if(progreso <0.5f)
            {
                estrella.localScale = Vector3.Lerp(Vector3.zero, escalaMaxima, progreso * 2);
            }
            else
            {
                estrella.localScale = Vector3.Lerp(escalaMaxima, escalaOriginal, (progreso - 0.5f) *2f);
            }
            yield return null;
        }
        estrella.localScale = escalaOriginal;
    }

    public IEnumerator AnimarTodasLasEstrellas()
    {
        foreach(RectTransform estrella in estrellas)
        {
            StartCoroutine(AnimarEstrella(estrella));

            yield return new WaitForSeconds(tiempoEntreEstrellas);
        }
    }

}
