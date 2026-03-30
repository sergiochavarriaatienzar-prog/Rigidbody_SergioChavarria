using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio7 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaTorque = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddTorque(Vector3.up * -fuerzaTorque, ForceMode.Force);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(Vector3.up * fuerzaTorque, ForceMode.Force);
        }
    }
}

