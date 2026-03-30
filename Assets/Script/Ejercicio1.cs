using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio1 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerza = 60f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
        }
    }
}
