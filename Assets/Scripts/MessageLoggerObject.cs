using System.Threading;
using UnityEngine;

[CreateAssetMenu]
public class MessageLoggerObject : ScriptableObject
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

    protected void Log(string message)
    {
        Log(name, message);
    }

    protected void Log(string instanceName, string message)
    {
        var instanceId = (Thread.CurrentThread.ManagedThreadId == 1) ? GetInstanceID() : 0;

        Debug.LogFormat(this, "({0}) {1}: {2}", instanceId, instanceName, message);
    }
}
