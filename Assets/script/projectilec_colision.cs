using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilec_colision : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "mur")
        {
            //Debug.Log("mur");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("pourquoi?");
        }
    }
}
