using UnityEngine;

public class FX {

    public static float Berp(float start, float end, float value)
    {
        value = Mathf.Clamp01(value);
        value = (Mathf.Sin(value * Mathf.PI * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + (1.2f * (1f - value)));
        return start + (end - start) * value;
    }

    public static float BerpAdv(float start, float end, float value, float bounciness = 2.5f, float expanding = 2.2f, float control = 1.2f)
    {
        value = Mathf.Clamp01(value);
        value = (Mathf.Sin(value * Mathf.PI * (0.2f + bounciness * value * value * value)) * Mathf.Pow(1f - value, expanding) + value) * (1f + (control * (1f - value)));
        return start + (end - start) * value;
    }




}
