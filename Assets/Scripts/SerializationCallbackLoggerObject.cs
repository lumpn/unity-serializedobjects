using UnityEngine;

[CreateAssetMenu]
public sealed class SerializationCallbackLoggerObject : MessageLoggerObject, ISerializationCallbackReceiver
{
    public void OnBeforeSerialize()
    {
        Log(nameof(OnBeforeSerialize));
    }

    public void OnAfterDeserialize()
    {
        Log("<unknown>", nameof(OnAfterDeserialize));
    }
}
