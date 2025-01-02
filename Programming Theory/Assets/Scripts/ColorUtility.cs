using UnityEngine;

public static class ColorUtility
{
    /// <summary>
    /// Generates a bright and saturated random color.
    /// </summary>
    /// <returns>A Color object with high brightness and saturation.</returns>
    public static Color GenerateBrightColor()
    {
        float hue = Random.Range(0f, 1f); // Random hue
        float saturation = Random.Range(0.75f, 1f); // High saturation
        float lightness = Random.Range(0.75f, 1f); // High brightness

        return ColorFromHSL(hue, saturation, lightness);
    }

    /// <summary>
    /// Converts HSL values to a Color object.
    /// </summary>
    private static Color ColorFromHSL(float h, float s, float l)
    {
        float r = 0f, g = 0f, b = 0f;

        if (s == 0f)
        {
            r = g = b = l; // Achromatic
        }
        else
        {
            float q = l < 0.5f ? l * (1f + s) : (l + s - l * s);
            float p = 2f * l - q;
            r = HueToRGB(p, q, h + 1f / 3f);
            g = HueToRGB(p, q, h);
            b = HueToRGB(p, q, h - 1f / 3f);
        }

        return new Color(r, g, b, 1f);
    }

    /// <summary>
    /// Helper method for HSL to RGB conversion.
    /// </summary>
    private static float HueToRGB(float p, float q, float t)
    {
        if (t < 0f) t += 1f;
        if (t > 1f) t -= 1f;

        if (t < 1f / 6f) return p + (q - p) * 6f * t;
        if (t < 1f / 2f) return q;
        if (t < 2f / 3f) return p + (q - p) * (2f / 3f - t) * 6f;

        return p;
    }
}
