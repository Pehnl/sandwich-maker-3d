using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Sandwich))]
public class SandwichEditor : Editor
{//Created this to type directly into the Sandwich Scriptable Object to try to fix the bug where "OrderValue" was not updating
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Sandwich sandwich = (Sandwich)target;

        // Display a text field to set the order value
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Order Value");
        sandwich.OrderValue = EditorGUILayout.IntField(sandwich.OrderValue);
    }
}