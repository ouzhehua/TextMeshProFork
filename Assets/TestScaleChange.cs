using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestScaleChange : MonoBehaviour
{
    Vector3 scale = Vector3.one;
    TMP_Text text = null;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scaleVector3 = new Vector3(text.transform.lossyScale.x / text.canvas.transform.lossyScale.x, text.transform.lossyScale.y / text.canvas.transform.lossyScale.y, text.transform.lossyScale.z / text.canvas.transform.lossyScale.z);
        
        if(scaleVector3 != scale)
        {
            text.SetVerticesDirty();
            text.SetLayoutDirty();
            Debug.LogError("scaleVector3 change");
        }
        
        scale = scaleVector3;

    }
}
