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
    }

   /* private void Awake() {
        inputAction = new PlayerInputActions();
        inputAction.Player.Move.performed += ctx => i_move = ctx.ReadValue<Vector2>();
    }*/
    // Update is called once per frame
    void FixedUpdate()
    {
        /*float xrotate = transform.localEulerAngles.x;
        float yrotate = transform.localEulerAngles.y;
        transform.eulerAngles = new Vector3(0, Mathf.Atan2(0, 0) * Mathf.Rad2Deg, 0);*/
        /*transform.position -= (Vector3.forward * Input.GetAxis("Horizontal") * 10 * Time.deltaTime);
        transform.position += (Vector3.right * Input.GetAxis("Vertical") * 10 * Time.deltaTime);*/
        //transform.position += hinput.anyGamepad.leftStick.worldPositionCamera * speed * Time.deltaTime;
        Vector3 v = new Vector3(i_move.y,0f,-i_move.x);
        transform.position += v * Time.deltaTime * speed;
        //transform.Translate(v);

        //transform.eulerAngles = new Vector3(xrotate, Mathf.Atan2(xrotate, yrotate) * Mathf.Rad2Deg, 0);
        Vector3 direction = new Vector3(i_direction.y, 0, -i_direction.x);
        //Vector3 direction = new Vector3(Input.GetAxis("RVertical"), 0, Input.GetAxis("RHorizontal"));

        if(direction.sqrMagnitude != 0)
            transform.rotation = Quaternion.LookRotation(direction);
    }

    private void OnMove(InputValue value) {
    Vector2 vec = value.Get<Vector2>();
    if(vec.magnitude >0.5f) {
        i_move = vec;
    } else {
        i_move = new Vector2(0,0);
    }
    }

    private void OnDirection(InputValue value) {
        Vector2 vec = value.Get<Vector2>();
        if(vec.magnitude >0.5f) {
        i_direction = vec;
    } else {
        i_direction = new Vector2(0,0);
    }
    }
}


