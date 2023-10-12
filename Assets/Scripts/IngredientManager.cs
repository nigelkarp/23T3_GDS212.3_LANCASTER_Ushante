using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    private bool _isClicked = false; // Is the object clicked

    [SerializeField] GameObject _blender;

    public Color selectedColor; // Color the Ingredient will change to when selected
    private SpriteRenderer _ingredientImageSprite;

    private bool isSelected;

    private void Start()
    {
        _ingredientImageSprite = GetComponent<SpriteRenderer>(); // Gets the sprite off of the ingredient's image
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        // This checks for mouse click and touch input
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Vector3 inputPosition;

            if (Input.touchCount > 0)
            {
                inputPosition = Input.GetTouch(0).position;
            }
            else
            {
                inputPosition = Input.mousePosition;
            }

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(inputPosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                _isClicked = true;
                IngredientClicked();
            }
        }

        void IngredientClicked()
        {
            if (_isClicked)
            {
                Debug.Log("Ingredient Clicked");
                // Add logic to check what item is checked (scriptable stuff)
                UpdateColor();
                ToggleSelection();
            }
        }
    }

    void ToggleSelection()
    {
        isSelected = !isSelected;
    }

    void UpdateColor()
    {
        Color color = isSelected ? selectedColor : selectedColor;
        _ingredientImageSprite.color = color;
    }
}
