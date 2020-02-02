using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersHealth : MonoBehaviour
{
    private int MAX_NB_PLAYERS = 4;
    public int numberOfPlayers = 4;
    
    private int MAX_HEALTH = 5;
    public int max_health = 3;
    // Start is called before the first frame update
    void Start()
    {
        if(max_health > MAX_HEALTH || max_health < 1) max_health = MAX_HEALTH;
        if(numberOfPlayers > MAX_NB_PLAYERS && numberOfPlayers < 1) numberOfPlayers = MAX_NB_PLAYERS;

        for(int i = MAX_NB_PLAYERS;i>numberOfPlayers;i--) {
            transform.Find("Player" + i.ToString()).gameObject.SetActive(false);
        }

        for(int j = 1; j <= numberOfPlayers; j++) {
            Transform healths = transform.Find("Player" + j.ToString()).Find("PlayerHealth").Find("HeartCanvas").Find("HeartHealth");
            for(int i = MAX_HEALTH;i>max_health;i--) {
                healths.transform.Find("HeartHealth" + i.ToString()).gameObject.SetActive(false);
            }
        }
    }

    void Update() {
        if(max_health > MAX_HEALTH || max_health < 1) max_health = MAX_HEALTH;

        for(int j = 1; j <= numberOfPlayers; j++) {
            Transform healths = transform.Find("Player" + j.ToString()).Find("PlayerHealth").Find("HeartCanvas").Find("HeartHealth");
            for(int i = 1;i<=MAX_HEALTH;i++) {
                healths.Find("HeartHealth" + i.ToString()).gameObject.SetActive(true);
            }
        }

        for(int j = 1; j <= numberOfPlayers; j++) {
            Transform healths = transform.Find("Player" + j.ToString()).Find("PlayerHealth").Find("HeartCanvas").Find("HeartHealth");
            for(int i = MAX_HEALTH;i>max_health;i--) {
                healths.transform.Find("HeartHealth" + i.ToString()).gameObject.SetActive(false);
            }
        }
    }
}
