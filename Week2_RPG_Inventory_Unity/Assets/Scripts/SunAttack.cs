using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunAttack : MonoBehaviour
{

    private PlayerController player;
    public int healthloss;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Player")
        {
            player.health -= healthloss;
        }
    }
}

  