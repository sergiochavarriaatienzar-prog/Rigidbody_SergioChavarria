using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio3 : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    public float fuerzaAce = 10f;
    public float fuerzaFre = 10f;
    Vector2 inputMov;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();

    }

    private void Update()
    {
        inputMov = input.actions["Move"].ReadValue<Vector2>();
    }



    void FixedUpdate()
    {
        if (inputMov.y > 0)
        {
            rb.AddForce(transform.forward * fuerzaAce, ForceMode.Force);
        }

        else if (inputMov.y < 0)
        {
           rb.AddForce(-transform.forward * fuerzaFre, ForceMode.Force);
        }
    }
}
