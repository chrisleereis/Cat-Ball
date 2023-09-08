using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Screen.SetResolution(320, 240, true);
        Application.targetFrameRate = 30;
    }

}