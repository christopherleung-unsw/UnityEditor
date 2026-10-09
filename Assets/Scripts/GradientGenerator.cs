using System.IO;
using UnityEngine;

public class GradientGenerator : MonoBehaviour
{
    public Gradient gradient;
    public string savingPath = "/Textures/GradientGenerator/";

    public float width = 256f;
    public float height = 64f;

    private Texture2D gradientTexture;
    private Texture2D tempTexture;

    Texture2D GenerateGradientTexture(Gradient grad) // Creates a temporary gradient of defined width and height.
    {
        if (tempTexture == null)
        {
            tempTexture = new Texture2D((int)width, (int)height);
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color color = grad.Evaluate(0 + (x / width));
                tempTexture.SetPixel(x, y, color);
            }
        }

        tempTexture.wrapMode = TextureWrapMode.Clamp;
        tempTexture.Apply();
        return tempTexture;
    }

    public void BakeGradientTexture() // Bakes the gradient to a PNG file and save it in the designated saving path.
    {
        gradientTexture = GenerateGradientTexture(gradient);
        
        byte[]_bytes = gradientTexture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + savingPath + "GradientTexture_" + Random.Range(0,999).ToString() + ".png", _bytes);
    }

}
