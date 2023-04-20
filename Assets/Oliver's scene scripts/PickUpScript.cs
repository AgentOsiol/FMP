using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;
    private bool pickUpAllowed;

    public string itemType;
    
    // Start is called before the first frame update
    private void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().CollectItem(itemType);

        Destroy(gameObject);
    }
}