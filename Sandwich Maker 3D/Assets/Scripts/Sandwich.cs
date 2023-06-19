using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Sandwich", menuName = "Sandwich")]
public class Sandwich : ScriptableObject
{
    public string sandwichName;
    public Sprite Image;
    public Ingredient[] ingredients;
    
    [SerializeField]
    private int orderValue;

    public int OrderValue
    {
        get { return orderValue; }
        set { orderValue = value; }
    }
}
