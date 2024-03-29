using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpText : MonoBehaviour
{
    public bool pickup = false;
    [SerializeField] private Text pickUpText;
    private bool pickUpAllowed;
    [SerializeField] private Text interactText;

    //public string itemType;
    
    // Start is called before the first frame update
    private void Start()
    {
        pickUpText.gameObject.SetActive(false);
        interactText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if (pickup == true)
            {
                pickUpText.gameObject.SetActive(true);
            }
            else
            {
                interactText.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if (pickup == true)
            {
                pickUpText.gameObject.SetActive(false);
            }
            else
            {
                interactText.gameObject.SetActive(false);
            }
        }
    }


}
