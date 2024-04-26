using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1firstminigame : MonoBehaviour
{
    public GameObject minigamecube;
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            minigamecube.SetActive(false);
            Coin1.SetActive(true);
            Coin2.SetActive(true);
            Coin3.SetActive(true);
            minigametext.Minigametextactive = true;
        }
    }
}
