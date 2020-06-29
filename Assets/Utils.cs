using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// based on https://msdn.microsoft.com/en-us/library/dd642331(v=vs.110).aspx
// (only availible in 4.0)
public class Lazy<T>
{
    private readonly System.Func<T> constructor;
    private bool initialized = false;
    private T _value;
    private System.Func<GUIStyle> func;
    public T Value
    {
        get
        {
            if (!initialized)
            {
                _value = constructor();
                initialized = true;
            }
            return _value;
        }
    }

    public Lazy(System.Func<T> constructor)
    {
        this.constructor = constructor;
    }
}


// an empty monobehaviour for running coroutines on any GameObject
public class CoroutineMonoBehaviour : MonoBehaviour { }


public static class Vector3Extension
{
    public static Vector3Int ToInt(this Vector3 v)
    {
        return new Vector3Int(
            Mathf.RoundToInt(v.x),
            Mathf.RoundToInt(v.y),
            Mathf.RoundToInt(v.z)
            );
    }
}