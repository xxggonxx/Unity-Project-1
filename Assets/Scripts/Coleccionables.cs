using UnityEngine;
using TMPro;


public class Coleccionables : MonoBehaviour
{
    public SistemaColeccionables sistemaColeccionables;
    

    private void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sistemaColeccionables.AgregarColeccionables();
            gameObject.SetActive(false);
            
        }
    }
}
