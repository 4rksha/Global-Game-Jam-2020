using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectil_move : MonoBehaviour
{
    public float speed;
    public float firerate;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = gameObject.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed != 0)
        {
            transform.position += direction  * (speed * Time.deltaTime);
        }
        else
        {
            Debug.Log("no speed");
        }
    }

     void OnCollision(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "mur")
        {
            Destroy(gameObject);
        }
        else if (collisionInfo.collider.tag == "boss")
        {
            Debug.Log("boss");
        }
    }
}

