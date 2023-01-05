using UnityEngine;

[CreateAssetMenu]
public sealed class HotReloadIntObject : ScriptableObject, IIntObject
{
    private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
