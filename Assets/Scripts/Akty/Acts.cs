using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "New Act", menuName = "Act")]
public class Acts : ScriptableObject
{
    public Sprite infoImage;
    public Sprite characterImage;
    public int starPosition;
    [TextArea(10,20)]
    public string info;

    //*****************************Button stats**************************//

    [Header("Parameter Types")]
    public string par1Type;
    public string par2Type;
    public string par3Type;
    public string par4Type;

    [Header("Button 1")]
    public int btn1Par1;
    public int btn1Par2;
    public int btn1Par3;
    public int btn1Par4;
    [Header("Button 2")]
    public int btn2Par1;
    public int btn2Par2;
    public int btn2Par3;
    public int btn2Par4;
    [Header("Button 3")]
    public int btn3Par1;
    public int btn3Par2;
    public int btn3Par3;
    public int btn3Par4;

    [TextArea(10,20)]
    public string btnComment1;
    [TextArea(10,20)]
    public string btnComment2;
    [TextArea(10,20)]
    public string btnComment3;
    [TextArea(10,20)]
    public string btnInfo1;
    [TextArea(10,20)]
    public string btnInfo2;
    [TextArea(10,20)]
    public string btnInfo3;

    public string year;
    public string chapter;
}
