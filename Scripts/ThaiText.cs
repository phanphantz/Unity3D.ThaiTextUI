using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class ThaiText : Text
{
    private string oldText;
    private void FixThaiText()
    {
        text = ThaiFontAdjuster.Adjust(text);
    }

    void Awake()
    {
        oldText = text;
    }

    void Update()
    {
        if (!oldText.Equals(text))
        {
            FixThaiText();
            oldText = text;
        }
    }


}
