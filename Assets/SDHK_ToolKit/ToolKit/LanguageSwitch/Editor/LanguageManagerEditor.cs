using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using SDHK_Extension;

namespace LanguageSwitch
{
    [CustomEditor(typeof(LanguageManager))] //指定要编辑的脚本对象
    public class LanguageManagerEditor : Editor
    {
        private LanguageManager script;


        public override  void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;

            script = target as LanguageManager;

            GUILayout.Space(20);

            Color bak = GUI.color;
            GUI.color = Color.green;
            if (GUILayout.Button("刷新", GUILayout.Height(40)))
            {
                script.GetLanguageNames();
            }
            GUI.color = bak;

            EditorGUILayout.Space();

            GUILayout.Label("当前：[" + script.languageFolderName + "]");

            EditorGUILayout.Space();

            foreach (var languageName in script.languageNames)
            {
                if (GUILayout.Button("[" + languageName + "]", GUILayout.Width(250), GUILayout.Height(40)))
                {
                    script.languageFolderName = languageName;
                    script.LoadAll();
                }
                EditorGUILayout.Space();
            }





        }
    }
}
