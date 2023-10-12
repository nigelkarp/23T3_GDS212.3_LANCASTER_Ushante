using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Juice Order", menuName = "Juice Game/Ingredient")]

public class Ingredient : ScriptableObject
{
    public string ingredientName;
    public Sprite ingredientIcon; //Icon displayed for ingredients
}

public class Pineapple : Ingredient
{
   public Pineapple()
    {
        ingredientName = "Pineapple";
        ingredientIcon = null;
    }
}