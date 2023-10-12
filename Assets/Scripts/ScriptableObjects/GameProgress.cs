using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//refence chatgpt for exact code, although idea and pseudo by me

[CreateAssetMenu(fileName = "New Game Progress", menuName = "Game/Game Progress")]
public class GameProgress : ScriptableObject
{
    [SerializeField] private int _completedRecipes = 0;
    [SerializeField] private int _unlockedLevels = 1; // Assume that the first level is unlocked by default.

    public int CompletedRecipes
    {
        get { return _completedRecipes; }
        set { _completedRecipes = value; }
    }

    public int UnlockedLevels
    {
        get { return _unlockedLevels; }
        set { _unlockedLevels = value; }
    }

    public void ResetProgress()
    {
        _completedRecipes = 0;
        _unlockedLevels = 1;
    }

    public void CompleteRecipe()
    {
        _completedRecipes++;
        // implement additional logic here, such as unlocking new levels.
    }
}

