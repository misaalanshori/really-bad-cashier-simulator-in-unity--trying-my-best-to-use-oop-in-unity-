using UnityEngine;

public static class ColorUtility
{
    /// <summary>
    /// Generates a bright and saturated random color using Unity's HSV model.
    /// </summary>
    /// <returns>A Color object with high brightness and saturation.</returns>
    public static Color GenerateBrightColor()
    {
        // Random hue (0 to 1 for full color spectrum)
        float hue = Random.Range(0f, 1f);

        // High saturation (0.75 to 1 for vibrant colors)
        float saturation = Random.Range(0.75f, 1f);

        // High value/brightness (0.75 to 1 for bright colors)
        float value = Random.Range(0.75f, 1f);

        // Use Unity's HSVToRGB method
        return Color.HSVToRGB(hue, saturation, value);
    }
}
