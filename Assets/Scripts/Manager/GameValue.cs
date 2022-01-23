using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// [Serializable]
// public class GameValue1
// {
//     public int a = 1;
// }


[CreateAssetMenu]
public class GameValue : ScriptableObject
{

    public float CanvasPlaneDistance = 10;

    public float cursorAlphaMax = 1f;
    public float cursorAlphaMin = 0.5f;

    public float cursorRotationSpeedMax = 8;
    public float cursorRotationSpeedMin = 2;

    public float windowFadeSpeed = 0.5f;




}
