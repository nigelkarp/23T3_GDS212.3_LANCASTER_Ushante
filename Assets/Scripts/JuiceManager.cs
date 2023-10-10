using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JuiceManager : MonoBehaviour
{

    //when object collider tagged with 'ingredient' collides/ enters trigger of juicer, console.log ('destroy fruit')
    private void OnCollisonEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Debug.Log("ingredient in juicer");
        }
        
    }
}
