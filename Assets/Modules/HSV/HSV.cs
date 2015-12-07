using UnityEngine;
using System.Collections;

[System.Serializable]
public struct HSV {

    float H, S, V;

    public float Hue { get { return H; } set { H = value; } }
    public float Saturation { get { return S; } set { S = value; } }
    public float Value { get { return V; } set { V = value; } }

    public HSV(Color rgba)
    {
        float MAX = Mathf.Max(Mathf.Max(rgba.r, rgba.b), rgba.b);
        float MIN = Mathf.Min(Mathf.Min(rgba.r, rgba.b), rgba.b);
        H = 0;
        if(MAX == rgba.r)
        {
            H = 60 * ((rgba.g - rgba.b) / (MAX - MIN));
        }
        else if(MAX == rgba.g)
        {
            H = 60 * (2 + ((rgba.b - rgba.r) / (MAX - MIN)));
        }
        else if(MAX == rgba.b)
        {
            H = 60 * (4 + ((rgba.r - rgba.g) / (MAX - MIN)));
        }
        if(H < 0)
        {
            H += 360f;
        }


        S = 0;
        if(MAX != 0)
        {
            S = (MAX - MIN) / MAX;
        }
        V = MAX;
    }

    public Color toRGBA()
    {
        Color rgba = new Color();
        rgba.a = 1f;

        float hi = Mathf.Floor(Hue / 60f);
        float f = (Hue / 60f) - hi;

        float p = V * (1 - S);
        float q = V * (1 - S * f);
        float t = V * (1 - S * (1 - f));

        if(hi == 0 || hi == 6)
        {
            rgba.r = Value;
            rgba.g = t;
            rgba.b = p;
        }
        else if(hi == 1)
        {
            rgba.r = q;
            rgba.g = Value;
            rgba.b = p;
        }
        else if(hi == 2)
        {
            rgba.r = p;
            rgba.g = Value;
            rgba.b = t;
        }
        else if(hi == 3)
        {
            rgba.r = p;
            rgba.g = q;
            rgba.b = Value;
        }
        else if(hi == 4)
        {
            rgba.r = t;
            rgba.g = p;
            rgba.b = Value;
        }
        else if(hi == 5)
        {
            rgba.r = Value;
            rgba.g = p;
            rgba.b = q;
        }

        return (rgba);
    }

}
