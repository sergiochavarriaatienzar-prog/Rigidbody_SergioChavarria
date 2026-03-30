using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio4 : MonoBehaviour
{
    Rigidbody rb;
    PlayerInput input;
    public float velocidadConstante = 5f;
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
            rb.linearVelocity = new Vector3(direccion.x * velocidadConstante, rb.linearVelocity.y, direccion.z * velocidadConstante);
        }
    }
}