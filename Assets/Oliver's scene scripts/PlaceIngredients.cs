using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaceIngredients : MonoBehaviour
{
    public void Bowl (GameObject obj)
    {
        PlayerManager manager = obj.GetComponent<PlayerManager>();
        if (manager)
        {

            if (manager.ingredientCount > 5)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    manager.UseIngredient();
                }
                    
            }
        }
    }
}
