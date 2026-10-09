using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GradientGenerator))]
public class GradientGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GradientGenerator gradientGenerator = (GradientGenerator)target;

        if (GUILayout.Button("Generate Gradient"))
        {
            gradientGenerator.BakeGradientTexture();
            AssetDatabase.Refresh();
        }

    }
}
