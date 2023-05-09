using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public int ingredientCount;

    public void PickupIngredient()
    {
        ingredientCount++;
    }

    public void UseIngredient()
    {
        ingredientCount--;
    }

  
}

