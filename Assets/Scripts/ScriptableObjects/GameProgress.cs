using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//refence chatgpt for exact code, although idea and pseudo by me

[CreateAssetMenu(fileName = "New Game Progress", menuName = "Game/Game Progress")]
public class GameProgress : ScriptableObject
{
    [SerializeField] private int completedRecipes = 0;
    [SerializeField] private int unlockedLevels = 1; // Assume that the first level is unlocked by default.

    public int CompletedRecipes
    {
        get { return completedRecipes; }
        set { completedRecipes = value; }
    }

    public int UnlockedLevels
    {
        get { return unlockedLevels; }
        set { unlockedLevels = value; }
    }

    public void ResetProgress()
    {
        completedRecipes = 0;
        unlockedLevels = 1;
    }

    public void CompleteRecipe()
    {
        completedRecipes++;
        // implement additional logic here, such as unlocking new levels.
    }
}

