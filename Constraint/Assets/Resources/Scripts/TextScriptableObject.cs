using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu
(fileName = "NewLine",
    menuName = "NewLine", order = 0)]
public class TextScriptableObject : ScriptableObject
{
    public string writtenText;
}
