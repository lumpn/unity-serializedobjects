using UnityEngine;

[CreateAssetMenu]
public sealed class SerializedIntObject : ScriptableObject, IIntObject
{
    /// This value will serialize to disk, show up in the inspector, and
    /// survive entering and exiting play mode. But it will revert to
    /// the value serialized on disk when the scriptable object gets
    /// unloaded from memory.
    /// In edit mode, unloading can happen at any time if there are no
    /// references to the scriptable object anymore.
    /// In play mode, unloading happens when changing scenes if there are no
    /// references to the scriptable object anymore.
    [SerializeField] private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
