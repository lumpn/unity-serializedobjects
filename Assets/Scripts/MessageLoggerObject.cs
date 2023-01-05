using System.Threading;
using UnityEngine;

[CreateAssetMenu]
public sealed class MessageLoggerObject : ScriptableObject, ISerializationCallbackReceiver
{
    public MessageLoggerObject()
    {
        Log("<unknown>", "Constructor");
    }

    protected void Awake()
    {
        Log(nameof(Awake));
    }

    protected void OnDestroy()
    {
        Log(nameof(OnDestroy));
    }

    protected void OnEnable()
    {
        Log(nameof(OnEnable));
    }

    protected void OnDisable()
    {
        Log(nameof(OnDisable));
    }

    public void OnBeforeSerialize()
    {
        Log(nameof(OnBeforeSerialize));
    }

    public void OnAfterDeserialize()
    {
        Log("<unknown>", nameof(OnAfterDeserialize));
    }

    private void Log(string message)
    {
        Log(name, message);
    }

    private void Log(string instanceName, string message)
    {
        var instanceId = IsOnMainThread() ? GetInstanceID() : 0;

        Debug.LogFormat(this, "{0} ({1}): {2}", instanceName, instanceId, message);
    }

    private static bool IsOnMainThread()
    {
        return (Thread.CurrentThread.ManagedThreadId == 1);
    }
}
