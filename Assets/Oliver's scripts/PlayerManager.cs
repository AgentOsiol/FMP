using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public GameObject bowl;
    public int ingredientCount;
    public GameObject Oven;
    public GameObject Cake;
    public GameObject Door;

    private void Start()
    {
        
        bowl.SetActive(false);
        Oven.SetActive(false);
        Cake.SetActive(false);
        Door.SetActive(false);
    }

    private void Update()
    {
        if (ingredientCount > 5)
        {
            bowl.SetActive(true);
        }
        else
        {
            bowl.SetActive(false);
        }

        if (ingredientCount > 6)
        {
            Oven.SetActive(true);
        }

        if (ingredientCount > 7)
        {
            Cake.SetActive(true);
        }
        
        if (ingredientCount > 8)
        {
            Door.SetActive(true);
        }
    }


    public void UseIngredient()
    {

    }
}

