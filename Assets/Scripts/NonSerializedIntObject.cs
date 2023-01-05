using UnityEngine;

[CreateAssetMenu]
public sealed class NonSerializedIntObject : ScriptableObject, IIntObject
{
    [System.NonSerialized] private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
