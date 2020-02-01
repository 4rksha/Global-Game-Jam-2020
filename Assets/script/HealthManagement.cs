using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagement : MonoBehaviour
{

    public int health = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int max_health = transform.parent.gameObject.GetComponent<PlayersHealth>().max_health;
        Transform healths = transform.Find("PlayerHealth").Find("HeartCanvas").Find("HeartHealth");
        for(int i = 1;i<=max_health;i++) {
            healths.transform.Find("HeartHealth" + i.ToString()).Find("Heart").gameObject.SetActive(true);
        }
        for(int i = max_health;i>health;i--) {
            healths.transform.Find("HeartHealth" + i.ToString()).Find("Heart").gameObject.SetActive(false);
        }
    }
}
