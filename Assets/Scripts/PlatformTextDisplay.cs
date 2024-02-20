using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformTextDisplay : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        string platformInfo = "This project is running ";
#if UNITY_EDITOR
        platformInfo += "in the editor.";
#elif UNITY_WEBGL
        platformInfo += "on the web.";
#else
        platformInfo += "as a build.";
#endif
        text.text = platformInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
