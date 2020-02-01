using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_projectile : MonoBehaviour
{
    public GameObject player;
    public GameObject Firepoint;
    public List<GameObject> vfx = new List<GameObject> ();
    private GameObject effectToSpawn;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx [0];
        direction = player.transform.forward;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 5"))
        {
            SpawnVfx();
        }
        
    }

    void SpawnVfx()
    {
        GameObject vfx;
        if (Firepoint != null)
        {
            
            vfx = Instantiate(effectToSpawn, Firepoint.transform.position, player.transform.rotation);
        }
        else
        {
            Debug.Log("NO Firepoint");
        }
    }
}
