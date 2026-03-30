using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio8 : MonoBehaviour
{
    public float fuerzaExplosion = 500f;
    public float radioExplosion = 5f;
    public float upwardsModifier = 2f;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Explode();
        }
    }

    void Explode()
    {
        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, radioExplosion);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(
                    fuerzaExplosion,
                    explosionPos,
                    radioExplosion,
                    upwardsModifier,
                    ForceMode.Impulse
                );
            }
        }
    }
} 

