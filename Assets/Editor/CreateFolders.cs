using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class CreateFolders : Editor
{
    [MenuItem("Assets/Create Default Folders")]
    private static void CreateAllFolders()
    {
        List<string> folders = new List<string>
        {
            "Animations",
            "Audio",
            "Editor",
            "Materials",
            "Meshes",
            "Prefabs",
            "Scripts",
            "Scenes",
            "Shaders",
            "Textures",
            "UI",
            "Sprites",
            "VFX",
            "Settings"
        };

        foreach (string folder in folders)
        {
            if(!Directory.Exists("Assets/" + folder))
            {
                Directory.CreateDirectory("Assets/" + folder);
            }
        }

        AssetDatabase.Refresh();
    }
}
