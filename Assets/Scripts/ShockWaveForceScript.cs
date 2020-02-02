using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockWaveForceScript : MonoBehaviour
{
    public float radius = 10f;
    public float force = 500f;
    public ParticleSystem postShockFX;

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(postShockFX.isPlaying) {
            ShockWave();
        }
    }

    void ShockWave() {
        Vector3 position = transform.position;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider collider in colliders) {
            rb = collider.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddExplosionForce(force, position, radius);
            }
        }
    }
}
