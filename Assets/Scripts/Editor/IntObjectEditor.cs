using UnityEditor;
using UnityEngine;

public class IntObjectEditor : Editor
{
    [System.NonSerialized] private int newValue;

    public override void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        var intObject = (IIntObject)target;

        EditorGUILayout.Separator();
        EditorGUILayout.BeginVertical(GUI.skin.box);

        GUI.enabled = false;
        EditorGUILayout.IntField("Stored value", intObject.Value);
        GUI.enabled = true;

        newValue = EditorGUILayout.IntField("New value", newValue);
        if (GUILayout.Button("Set"))
        {
            intObject.Value = newValue;
        }

        EditorGUILayout.EndVertical();
    }
}
