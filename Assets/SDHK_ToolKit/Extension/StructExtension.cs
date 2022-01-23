using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StructExtension
{

    public static Color A(this Color color, float a)
    {
        color.a = a;
        return color;
    }

}
