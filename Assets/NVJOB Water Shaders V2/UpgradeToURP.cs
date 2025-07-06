using UnityEditor;
using UnityEngine;

public class UpgradeToURP
{
    [MenuItem("Tools/Upgrade All Materials to URP")]
    static void UpgradeMaterials()
    {
        string[] guids = AssetDatabase.FindAssets("t:Material");

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Material mat = AssetDatabase.LoadAssetAtPath<Material>(path);

            if (mat.shader.name == "Standard")
            {
                mat.shader = Shader.Find("Universal Render Pipeline/Lit");
                Debug.Log($"Upgraded: {mat.name}");
            }
        }

        AssetDatabase.SaveAssets();
        Debug.Log("✅ All Standard materials upgraded to URP Lit.");
    }
}