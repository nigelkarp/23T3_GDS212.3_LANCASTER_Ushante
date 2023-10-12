using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    private bool _isClicked = false; //Is the object clicked

    [SerializeField] GameObject _blender;

    public Color selectedColor; // Color the Ingredient will change to when selected
    [SerializeField] private GameObject _ingredientImage;
    private SpriteRenderer _ingredientImageSprite;

    private bool isSelected;

    private void Start()
    {
        _ingredientImageSprite = _ingredientImage.GetComponent<SpriteRenderer>(); // gets the sprite off of the ingredients image
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {

        //This cheks for mouse click and touch input
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
                //add logic to check what item checked blah blah (scriptable stuff)
                isSelected = !isSelected;
                UpdateColor();
            }

            return;
        }
    }

    void UpdateColor()
    {
        _ingredientImageSprite.color = isSelected ? selectedColor : Color.black;
    }
}
