using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Juice Order", menuName = "Juice Game/Juice Order")]

public class JuiceOrder : ScriptableObject
{
    public string orderName;
    public float orderTime;
    public IngredientQuantity[] requiredIngredients;

    [System.Serializable]
    public class IngredientQuantity
    {
        
        public int quantity; //amount of the ingredient needed, i might not use this for now
    }
    
}

