using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarBoss : MonoBehaviour
{
    public float ratio_health = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        if(ratio_health < -1f || ratio_health > 1f) ratio_health = 1f;

        Transform bar = transform.Find("BossHealthBar").Find("HealthBarGreen");
        bar.localScale = new Vector3(ratio_health,1f);
    }

    // Update is called once per frame
    void Update()
    {
        Transform bar = transform.Find("BossHealthBar").Find("HealthBarGreen");
        bar.localScale = new Vector3(ratio_health,1f);
    }
}
