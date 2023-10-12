using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static JuiceOrder;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _juiceNameText; // Reference to the TMP object for displaying the current order

    private JuiceOrder _currentRecipe; // Reference to the current recipe

    private void Start()
    {
        // Set initial recipe

        // Update the UI to display the current order's name
        UpdateUI();
    }

    public void StartRecipe(JuiceOrder newRecipe)
    {
        _currentRecipe = newRecipe;
        //set time limit, update UI
    }

    public void GiveNextRecipe()
    {
        //determine which recipe class to instantiate
        //instantiate the chosen recipe class, and call start recipe to begin
    }

    private void UpdateUI()
    {
        // Update the TMP text to display the current order's name.
        if (_currentRecipe != null)
        {
            _juiceNameText.text = _currentRecipe.recipeName;
        }

    }
}

