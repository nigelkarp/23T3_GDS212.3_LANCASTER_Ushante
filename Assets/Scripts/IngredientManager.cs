using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    private bool _isDragActive = false; //Is player dragging
    private Vector2 _screenPosition; //Object position on screen
    private Vector3 _worldPosition;
    private Draggable _lastDragged;

    [SerializeField] GameObject _blender;

    // Update is called once per frame
    void Update()
    {
        if (_isDragActive)
        {
            if (Input.GetMouseButtonDown(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended))
            {
                Drop();
                return;
            }
        }
            

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            _screenPosition = new Vector2(mousePos.x, mousePos.y);

        } 
        else if (Input.touchCount > 0)
        {
            _screenPosition = Input.GetTouch(0).position;
        } 
        else
        {
            return;
        }

        _worldPosition = Camera.main.ScreenToWorldPoint( _screenPosition);

        if (_isDragActive )
        {
            Drag(); 
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero );
            if (hit.collider != null)
            {
                Draggable draggable = hit.transform.GetComponent<Draggable>();
                if (draggable != null)
                {
                    _lastDragged = draggable;
                    InitDrag();
                }
            }
        }

    }

    void InitDrag()
    {
        _isDragActive = true;
    }

    void Drag()
    {
        _lastDragged.transform.position = new Vector2(_worldPosition.x, _worldPosition.y);
    }

    void Drop()
    {
        _isDragActive = false;
    }

    //when this object enters with the blender game object's trigger collider, console log enter
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks if the item has been dropped in the blender
        if (other.CompareTag("Blender"))
        {
            this.gameObject.SetActive(false);
            //check that its the right fruit

        }
        else
        {
            return;
        }
    }

}
