namespace Trace;

public struct Color
{
    public float R = r, G = g, B = b;

    // Add two colors
    public static Color operator +(Color c1, Color c2) {
        return new Color(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
    }
    
    //what if are negative??
    public static Color operator -(Color c1, Color c2) {
        return new Color(c1.R - c2.R, c1.G - c2.G, c1.B - c2.B);
    }

    // Multiply two colors (component-wise multiplication)
    public static Color operator *(Color c1, Color c2) {
        return new Color(c1.R * c2.R, c1.G * c2.G, c1.B * c2.B);
    }

    // Multiply color by scalar
    public static Color operator *(Color c, float scalar) {
        return new Color(c.R * scalar, c.G * scalar, c.B * scalar);
    }

    public static Color operator *(float scalar, Color c) {
        return c * scalar; // Reuse the existing overload
    }

    public static bool are_close(Color c1, Color c2)
    {
        if ((c1 - c2).B < 0.001)
        {
            return true;
        }

        return false;
    }
}
