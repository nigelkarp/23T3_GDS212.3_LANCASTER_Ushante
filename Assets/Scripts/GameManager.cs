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

    private void UpdateUI()
    {
        // Update the TMP text to display the current order's name.
        if (_currentRecipe != null)
        {
            _juiceNameText.text = _currentRecipe.recipeName;
        }

    }
}

