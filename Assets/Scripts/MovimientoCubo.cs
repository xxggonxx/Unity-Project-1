using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class MovimientoCubo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 3f;
    private Rigidbody body;
    Vector3 direction = Vector3.zero;
    public GameManager gameManager;
    public SistemaVidas sistemaVidas;


    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        if (gameManager.gameFinished)
        {
            return;
        }
        if (Keyboard.current != null && Keyboard.current.dKey.isPressed)
        {
            direction += Vector3.right;
        }
        if (Keyboard.current != null && Keyboard.current.aKey.isPressed)
        {
            direction += Vector3.left;
        }

        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            direction += Vector3.forward;
        }

        if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
        {
            direction += Vector3.back;
        }


    }

    void FixedUpdate()
    {
        if(gameManager.gameFinished)
        {
            return;
        }
        Vector3 movimiento = direction.normalized * speed;

        body.linearVelocity = new Vector3(
            movimiento.x,
            body.linearVelocity.y,
            movimiento.z
        );
    }

    void OnCollisionEnter(Collision collision)
    {
        if (gameManager.gameFinished)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            sistemaVidas.RestLife();
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(gameManager.gameFinished)
        {
            return;
        }
        if(other.CompareTag("Finish Line"))
        {
            Debug.Log("Ganaste");
            gameManager.WinGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
}