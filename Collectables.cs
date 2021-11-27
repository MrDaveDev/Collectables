using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    
    public bool coin;
    public bool heart;

    private int coinAmount;

    public PlayerMovement playerMovement;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (coin == true)
            {
                coinAmount += 1;
                gameObject.SetActive(false);
            }

            if (heart == true && playerMovement.health <= 2)
            {
                playerMovement.health += 1;
                gameObject.SetActive(false);
            }
        }
    }

}
