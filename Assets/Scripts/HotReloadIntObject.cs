using UnityEngine;

[CreateAssetMenu]
public sealed class HotReloadIntObject : ScriptableObject, IIntObject
{
    /// This value will not serialize to disk nor show up in the inspector,
    /// but it will survive entering and exiting play mode. It reverts to
    /// zero when the scriptable object gets unloaded from memory.
    /// You don't want this.
    private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
