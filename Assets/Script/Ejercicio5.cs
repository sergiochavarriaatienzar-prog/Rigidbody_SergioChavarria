using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio5 : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    public float fuerzaSalto = 5f;
    bool checkGround = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();

    }

    private void FixedUpdate()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && checkGround)
        {
            Saltar();
        }
    }


    void Saltar()
    {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);

        checkGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Suelo"))
        {
         checkGround = true;
        }
    }
}
