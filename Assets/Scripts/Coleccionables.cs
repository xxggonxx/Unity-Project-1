using UnityEngine;
using TMPro;


public class Coleccionables : MonoBehaviour
{
    public SistemaColeccionables sistemaColeccionables;
    public ParticleSystem efectoColeccionable;

    private void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sistemaColeccionables.AgregarColeccionables();
            ParticleSystem activarEfecto = Instantiate(efectoColeccionable, transform.position, Quaternion.identity);
            activarEfecto.Play();
            gameObject.SetActive(false);
            
        }
    }
}
