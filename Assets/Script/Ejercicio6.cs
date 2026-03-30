using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio6 : MonoBehaviour
{
    Rigidbody rb;
    public Transform objetivo;
    public float aceleracion = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (objetivo != null)
        {
            Vector3 direccion = (objetivo.position - transform.position).normalized;
            rb.AddForce(direccion * aceleracion, ForceMode.Acceleration);
        }
    }
}
