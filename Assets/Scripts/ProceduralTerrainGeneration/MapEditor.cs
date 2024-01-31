using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PerlinNoise))]
public class MapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PerlinNoise perlinNoise = (PerlinNoise)target;

        if (DrawDefaultInspector())
        {
            if(perlinNoise.autoUpdateInEditor) 
            {
                perlinNoise.GenerateMap();
            }
        }

        if (GUILayout.Button("Generate Map"))
        {
            perlinNoise.GenerateMap();
        }
    }
}
