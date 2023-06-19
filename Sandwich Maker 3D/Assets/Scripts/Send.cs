using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Send : MonoBehaviour
{
    private SandwichMenu sandwichMenu;
    private OnClick onClickScript;
    public TextMeshProUGUI scoreText;
    Sandwich sandwich;

    // Start is called before the first frame update
    void Start()
    {
        //Find the SandwichMenu script in the scene
        sandwichMenu = FindObjectOfType<SandwichMenu>();
        // Find the OnClick script in the scene
        onClickScript = FindObjectOfType<OnClick>();
 //       scoreText.text = "SCORE: " + GameFlow.playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Order Value: " + SandwichMenu.orderValue);
        Debug.Log("Plate Value: " + GameFlow.plateValue);
        //Compares if player's sandwich is the same as game Sandwich
        if(sandwich.OrderValue == GameFlow.plateValue)
        {
            Debug.Log("Nice");
            GameFlow.playerScore += 1;
            scoreText.text = "SCORE: " + GameFlow.playerScore.ToString();
            //GameFlow.instance.AddPoint();
        }
        else
        {
            Debug.Log("Wrong");
            //GameFlow.playerScore -= 1;
        }
        DestroyWithTag("Clone");
        CycleSandwiches();
        GameFlow.plateValue = 000000;
        Debug.Log("Score:  " + GameFlow.playerScore);
    }

    private void CycleSandwiches()
    {
        onClickScript.CurrentIndex++;
        if (onClickScript.CurrentIndex >= sandwichMenu.sandwiches.Length)
        {
            onClickScript.CurrentIndex = 0; // Go back to the first sandwich
        }

        // Using currentIndex to access the current sandwich in the array
        Sandwich currentSandwich = sandwichMenu.sandwiches[onClickScript.CurrentIndex];

        // Update the sandwich image and name in the UI
        sandwichMenu.sandwichImage.sprite = currentSandwich.Image;
        string ingredients = "Ingredients: ";
        for (int i = 0; i < currentSandwich.ingredients.Length; i++)
        {
            ingredients += currentSandwich.ingredients[i].ingredientName;
            if (i < currentSandwich.ingredients.Length - 1)
            {
                ingredients += ", ";
            }
        }
        sandwichMenu.ingredientsText.text = ingredients;

        // Do whatever you need to do with the current sandwich
        Debug.Log("Current Sandwich: " + currentSandwich.sandwichName);
    }

    void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
}
