using UnityEngine;

[CreateAssetMenu]
public sealed class NonSerializedIntObject : ScriptableObject, IIntObject
{
    /// This value will not serialize to disk nor show up in the inspector.
    /// It reverts to zero on entering play mode and when the scriptable object
    /// gets unloaded from memory.
    [System.NonSerialized] private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
