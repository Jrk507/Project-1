//Author: Jason Kmieciak
//Credit: Alexander Zotov : https://www.youtube.com/watch?v=yFKg8qVclBk
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacked : MonoBehaviour
{
 
    private bool pickUpAllowed;

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.F))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        ScoreScript.scoreValue += 1;
        Destroy(gameObject);
    }

}
