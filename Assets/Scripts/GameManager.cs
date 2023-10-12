using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static JuiceOrder;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _juiceNameText; // Reference to the TMP object for displaying the current order

    private JuiceOrder _currentRecipe; // Reference to the current recipe

    private List<Ingredient> _selectedIngredients = new List<Ingredient>();

    private void Start()
    {
        // Set initial recipe as Recipe 1
        JuiceOrder.Recipe1 initialRecipe = ScriptableObject.CreateInstance<JuiceOrder.Recipe1>();
        StartRecipe(initialRecipe);
    }

    public void StartRecipe(JuiceOrder newRecipe)
    {
        _currentRecipe = newRecipe;
        // Set time limit (for now no time), update UI

        // Update the UI to display the current order's name
        UpdateUI();
    }

    public void GiveNextRecipe()
    {
        // Determine which recipe class to instantiate (could be random)
        // Instantiate the chosen recipe class and call StartRecipe to begin
    }

    private void UpdateUI()
    {
        // Update the TMP text to display the current order's name.
        if (_currentRecipe != null)
        {
            _juiceNameText.text = _currentRecipe.recipeName;
        }
    }

    bool CheckRecipe()
    {
        // Get the required ingredients for the current order
        IngredientQuantity[] requiredIngredients = _currentRecipe.requiredIngredients;

        // Create a dictionary to count the selected ingredients
        Dictionary<Ingredient, int> selectedIngredientsCount = new Dictionary<Ingredient, int>();

        // Iterate through selected ingredients and count them
        foreach (Ingredient selectedIngredient in _selectedIngredients)
        {
            if (!selectedIngredientsCount.ContainsKey(selectedIngredient))
            {
                selectedIngredientsCount[selectedIngredient] = 1;
            }
            else
            {
                selectedIngredientsCount[selectedIngredient]++;
            }
        }

        // Compare the selected ingredients with the required ingredients
        foreach (IngredientQuantity requiredIngredient in requiredIngredients)
        {
            if (!selectedIngredientsCount.ContainsKey(requiredIngredient.ingredient) ||
                selectedIngredientsCount[requiredIngredient.ingredient] < requiredIngredient.quantity)
            {
                Debug.Log("Recipe does not match");
                return false; // Recipe does not match
            }
        }

        Debug.Log("Recipe matches");
        return true; // Recipe matches
    }

    public void SelectIngredient(Ingredient ingredient)
    {
        // Add the selected ingredient to the list
        _selectedIngredients.Add(ingredient);
        Debug.Log("Selected Ingredient: " + ingredient.ingredientName);
    }

    public void DeselectIngredient(Ingredient ingredient)
    {
        // Remove the deselected ingredient from the list
        _selectedIngredients.Remove(ingredient);
        Debug.Log("Deselected Ingredient: " + ingredient.ingredientName);
    }
}


