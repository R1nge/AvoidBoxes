using UnityEngine;

public sealed class FpsManager
{
    [RuntimeInitializeOnLoadMethod]
    static void SetFps()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 61;
    }
}