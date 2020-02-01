using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class control_character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*float xrotate = transform.localEulerAngles.x;
        float yrotate = transform.localEulerAngles.y;
        transform.eulerAngles = new Vector3(0, Mathf.Atan2(0, 0) * Mathf.Rad2Deg, 0);*/

        transform.position += (Vector3.forward * Input.GetAxis("Horizontal") * 10 * Time.deltaTime);
        transform.position += (Vector3.right * Input.GetAxis("Vertical") * 10 * Time.deltaTime);

        //transform.eulerAngles = new Vector3(xrotate, Mathf.Atan2(xrotate, yrotate) * Mathf.Rad2Deg, 0);

        Vector3 direction = new Vector3(Input.GetAxis("RVertical"), 0, Input.GetAxis("RHorizontal"));
        //Vector3 direction = new Vector3(Input.GetAxis("RHorizontal"), 0, Input.GetAxis("RVertical"));
        /*if (x != 0f || y != 0f)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }*/

        if(direction.sqrMagnitude != 0)
            transform.rotation = Quaternion.LookRotation(direction);
    }
}

