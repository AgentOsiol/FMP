using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class BowlScript : MonoBehaviour
{
    private bool pickUpAllowed;
    public int ingredientCount;
    private bool canDestroyObject;
    public GameObject Oven;
    public GameObject Cake;

    // Update is called once per frame

    private void Start()
    {
        //canDestroyObject = true;
    }
    private void Update()
    {
        


        //if (canDestroyObject == false)
        {

        }

        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
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
        FindObjectOfType<PlayerManager>().ingredientCount++;
        Destroy(GameObject.Find("BowlFireflies"));
        Destroy(GameObject.Find("OvenFireflies"));
        Destroy(GameObject.Find("CakeFireflies"));
    }
}
