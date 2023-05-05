using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaceIngredients : MonoBehaviour
{
    bool eIsPressed = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eIsPressed = true;
            Debug.Log("You DiD it");
        }
    }
    
    public void Bowl (GameObject obj)
    {
        


        PlayerManager manager = obj.GetComponent<PlayerManager>();
        if (manager)
        {

            if (manager.ingredientCount > 5 && eIsPressed== true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    manager.UseIngredient();

                }
                    
            }
        }
        

    }

    

}
