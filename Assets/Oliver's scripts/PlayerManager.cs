using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public GameObject bowl;
    public int ingredientCount;

    private void Start()
    {
        bowl.SetActive(false);
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

    }


    public void UseIngredient()
    {

    }
}

