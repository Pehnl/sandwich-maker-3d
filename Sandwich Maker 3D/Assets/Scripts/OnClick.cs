using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    public Transform cloneObj;
    public int foodValue = 0;
    private SandwichMenu sandwichMenu;
    private int currentIndex = 0;

    public int CurrentIndex // Expose the currentIndex through a public property to use it in other scripts
    {
        get { return currentIndex; }
        set { currentIndex = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        // Find the SandwichMenu script in the scene
        sandwichMenu = FindObjectOfType<SandwichMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Place ingredients in the scene according to their name
        
        if (gameObject.name == "Bacon")
        {
            Instantiate(cloneObj, new Vector3(-.11f, 1.8f, -7.5f), cloneObj.rotation);
            Instantiate(cloneObj, new Vector3(.1f, 1.8f, -7.5f), cloneObj.rotation);
        }


        if (gameObject.name == "Eggs")
        {
            Instantiate(cloneObj, new Vector3(0, 1.8f, -7.5f), cloneObj.rotation);
        }

        if (gameObject.name == "Tomato")
        {
            Instantiate(cloneObj, new Vector3(0, 1.8f, -7.5f), cloneObj.rotation);
        }

        if (gameObject.name == "Bread")
        {
            Instantiate(cloneObj, new Vector3(0, 1.8f, -7.5f), cloneObj.rotation);
        }

        if (gameObject.name == "Cheese")
        {
            Instantiate(cloneObj, new Vector3(0, 1.8f, -7.5f), cloneObj.rotation);
        }

        if (gameObject.name == "Lettuce")
        {
            Instantiate(cloneObj, new Vector3(0, 1.8f, -7.5f), cloneObj.rotation);
        }

        //Sum of ingredients values

        GameFlow.plateValue += foodValue;
        Debug.Log(GameFlow.plateValue + "    " + SandwichMenu.orderValue);

        //Trashcan to destroy anything with tag "Clone"

        if (gameObject.name == "Trashcan")
        {
            DestroyWithTag("Clone");
            GameFlow.plateValue = 000000;
        }

        //Destroy with tag "Clone"

        void DestroyWithTag(string destroyTag)
        {
            GameObject[] destroyObject;
            destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
            foreach (GameObject oneObject in destroyObject)
                Destroy(oneObject);
        }

        //CycleSandwiches();
    }

   private void CycleSandwiches()
    {
        currentIndex++;
        if (currentIndex >= sandwichMenu.sandwiches.Length)
        {
            currentIndex = 0; // Return to first sandwich
        }

        // CurrentIndex too access the current Sandwich on the array
        Sandwich currentSandwich = sandwichMenu.sandwiches[currentIndex];

        Debug.Log("Current Sandwich: " + currentSandwich.sandwichName);
    }
}
