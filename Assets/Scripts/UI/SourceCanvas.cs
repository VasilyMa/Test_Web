using UnityEngine;

public abstract class SourceCanvas : MonoBehaviour
{
    protected Canvas _canvas;
    protected virtual void Start()
    {
        _canvas = GetComponent<Canvas>();

        DeviceType info = SystemInfo.deviceType;

#if UNITY_WEBGL && !UNITY_EDITOR
       System.Console.WriteLine("$Platform is {info}");
#endif
    }
}
