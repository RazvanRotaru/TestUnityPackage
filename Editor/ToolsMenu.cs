using System.IO;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public static class ToolsMenu
    {
        [MenuItem("PJV/Setup/Create Default Folders")]
        public static void CreateDefaultFolderHierarchy()
        {
            CreateDirectories("", "Scripts", "Resources");
            CreateDirectories("Resources", "Prefabs", "Models", "Sprites");
            AssetDatabase.Refresh();
        }


        private static void CreateDirectories(string root, params string[] directories)
        {
            var fullPath = Path.Combine(Application.dataPath, root);

            foreach (var directory in directories)
            {
                Directory.CreateDirectory(Path.Combine(fullPath, directory));
            }
        }
    }
}