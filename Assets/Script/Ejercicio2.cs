using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio2 : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    public float fuerza = 10f;
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
        Vector3 direccion = new Vector3(inputMov.x, 0, inputMov.y);

        if (direccion != Vector3.zero)
        {
            rb.AddForce(direccion * fuerza, ForceMode.Force);
        }
    }
}
