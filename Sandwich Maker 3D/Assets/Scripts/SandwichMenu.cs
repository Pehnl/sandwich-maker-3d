using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class SandwichMenu : MonoBehaviour
{

    [SerializeField] public  UnityEngine.UI.Image sandwichImage;
    [SerializeField] public  TextMeshProUGUI sandwichName;
    [SerializeField] public  TextMeshProUGUI ingredientsText;

    public static int orderValue;

    public Sandwich[] sandwiches;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve or create a SandwichData array with the desired sandwiches
        Sandwich[] sandwichDataArray = Resources.LoadAll<Sandwich>("Sandwiches");

        // Initialize the sandwiches array with the appropriate size
        sandwiches = new Sandwich[sandwichDataArray.Length];

        // Convert SandwichData objects to Sandwich objects
        for (int i = 0; i < sandwichDataArray.Length; i++)
        {
            sandwiches[i] = new Sandwich
            {
                sandwichName = sandwichDataArray[i].sandwichName,
                Image = sandwichDataArray[i].Image,
                ingredients = sandwichDataArray[i].ingredients
            };
        }

        // Call the displayRandomSandwich method
        displayRandomSandwich();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void displayRandomSandwich()
    {
        // Select a random sandwich from the array
        Sandwich randomSandwich = sandwiches[Random.Range(0, sandwiches.Length)];

        // Update the UI elements with the sandwich's image and name
        sandwichImage.sprite = randomSandwich.Image;
        sandwichName.text = randomSandwich.sandwichName;

        orderValue = randomSandwich.OrderValue;
        Debug.Log(orderValue);

        // Build a string to display the ingredients

        string ingredients = "Ingredients: ";
        for(int i = 0; i < randomSandwich.ingredients.Length; i++)
        {
            ingredients += randomSandwich.ingredients[i].ingredientName;
            if (i < randomSandwich.ingredients.Length - 1)
            {
                ingredients += ", ";
            }
        }
        // Update the ingredients text element
        ingredientsText.text = ingredients;
    }
}
