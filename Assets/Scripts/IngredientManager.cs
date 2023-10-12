using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    //private bool _isDragActive = false; //Is player dragging
    //private Vector2 _screenPosition; //Object position on screen
    //private Vector3 _worldPosition;
    //private Draggable _lastDragged;

    private bool _isClicked = false; //Is the object clicked

    [SerializeField] GameObject _blender;

    // Update is called once per frame
    void Update()
    {
        //if is clicked is true (logic happens)
        //link scriptable stuff here

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
                return;
            }
        }
    }

}
