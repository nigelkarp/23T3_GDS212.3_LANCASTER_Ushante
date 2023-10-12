using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Juice Order", menuName = "Juice Game/Juice Order")]

public class JuiceOrder : ScriptableObject
{
    public string recipeName;
    public float orderTime;
    public IngredientQuantity[] requiredIngredients;

    [System.Serializable]
    public class IngredientQuantity
    {
        public Ingredient ingredient;
        public int quantity; //amount of the ingredient needed, i might not use this for now
    }

    [CreateAssetMenu(fileName = "Recipe 1", menuName = "Juice Game/Recipe 1")]
    public class Recipe1 : JuiceOrder
    {
        public Recipe1()
        {
            recipeName = "Tropicana";
            orderTime = 10f;
            requiredIngredients = new IngredientQuantity[]
            {
                new IngredientQuantity { ingredient = Ingredient.Apple}
            }
        }
    }
}

