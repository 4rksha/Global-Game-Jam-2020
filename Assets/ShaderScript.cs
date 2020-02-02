using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{
    Renderer rend;

    public float minimum = 0;
    public float maximum = 1.0F;

    static float t = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float f = Mathf.Lerp(minimum, maximum, t);
        t += 1f * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
        Debug.Log(rend.material.GetColor("_Color").ToString());
        rend.material.SetColor("_Color", new Color(1f, f, f));
    }
}
