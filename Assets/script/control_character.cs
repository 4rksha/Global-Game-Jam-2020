using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.Input; 
using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class control_character : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 i_move;
    private Vector2 i_direction;
    private int speed = 15;
    void Start()
    {
        GetComponent<spawn_projectile>();
    }

  
    void FixedUpdate()
    {
        
        Vector3 v = new Vector3(i_move.y,0f,-i_move.x);
        transform.position += v * Time.deltaTime * speed;
        Vector3 direction = new Vector3(i_direction.y, 0, -i_direction.x);
        if(direction.sqrMagnitude != 0)
            transform.rotation = Quaternion.LookRotation(direction);
    }

    private void OnMove(InputValue value) {
    Vector2 vec = value.Get<Vector2>();
    if(vec.magnitude >0.2f) {
        i_move = vec;
    } else {
        i_move = new Vector2(0,0);
    }
    }

    private void OnDirection(InputValue value) {
        Vector2 vec = value.Get<Vector2>();
        if(vec.magnitude >0.2f) {
        i_direction = vec;
    } else {
        i_direction = new Vector2(0,0);
    }
    }

    private void OnTire(InputValue value)
    {
        GameObject vfx;
        vfx = GetComponent<spawn_projectile>().effectToSpawn;
        vfx = Instantiate(vfx, GetComponent<spawn_projectile>().Firepoint.transform.position, gameObject.transform.rotation);

    }
}


