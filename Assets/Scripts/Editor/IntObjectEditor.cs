using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IIntObject))]
public sealed class IntObjectEditor : Editor
{
    [System.NonSerialized] private int newValue;

    public override void OnInspectorGUI()
    {
        var intObject = (IIntObject)target;
        var value = intObject.Value;

        GUI.enabled = false;
        EditorGUILayout.IntField("Value", value);
        GUI.enabled = true;

        EditorGUILayout.Separator();
        EditorGUILayout.BeginVertical(GUI.skin.box);

        newValue = EditorGUILayout.IntField("New value", newValue);
        if (GUILayout.Button("Set"))
        {
            intObject.Value = newValue;
        }

        EditorGUILayout.EndVertical();
    }
}
