# unity-serializedobjects
Showing what happens to private fields when entering play mode.

## Serialized fields
Serialized fields will serialize to disk, show up in the inspector, and survive entering and exiting play mode. But it they revert to the value serialized on disk when the scriptable object gets unloaded from memory.

```csharp
[SerializeField] private int value;
```

In edit mode, unloading can happen at any time if there are no references to the scriptable object anymore.

In play mode, unloading happens when changing scenes if there are no references to the scriptable object anymore.

## Non-serialized fields
Non-serialized fields not serialize to disk nor show up in the inspector. They revert to their default value on entering play mode and when the scriptable object gets unloaded from memory.

```csharp
[System.NonSerialized] private int value;
```

## Hot-reloading fields
[Hot-reloading](https://docs.unity3d.com/Manual/script-Serialization.html#HowUnityUsesSerialization) fields will not serialize to disk nor show up in the inspector, but they will still survive entering and exiting play mode. They only revert to their default value when the scriptable object gets unloaded from memory.

```csharp
private int value;
```
You don't want this.
