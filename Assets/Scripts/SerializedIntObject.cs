using UnityEngine;

[CreateAssetMenu]
public sealed class SerializedIntObject : ScriptableObject, IIntObject
{
    [SerializeField] private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
