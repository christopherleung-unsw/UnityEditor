using UnityEditor;
using UnityEngine;

public static class InspectorLockPreferences
{
    const string TintColorKey = "InspectorLockTint";

    static readonly Color DefaultTint =
        new(0.55f, 0.08f, 0.08f, 0.1f);

    public static Color TintColor
    {
        get
        {
            string json = EditorPrefs.GetString(
                TintColorKey,
                JsonUtility.ToJson(DefaultTint));

            return JsonUtility.FromJson<Color>(json);
        }
        set
        {
            EditorPrefs.SetString(
                TintColorKey,
                JsonUtility.ToJson(value));
        }
    }

    [SettingsProvider]
    public static SettingsProvider CreateSettingsProvider()
    {
        return new SettingsProvider(
            "Preferences/Inspector Lock",
            SettingsScope.User)
        {
            guiHandler = (searchContext) =>
            {
                EditorGUILayout.LabelField(
                    "Inspector Lock Settings",
                    EditorStyles.boldLabel);

                TintColor = EditorGUILayout.ColorField(
                    "Locked Tint Color",
                    TintColor);
            }
        };
    }
}