using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace LanguageSwitch
{

    [CustomEditor(typeof(LanguageText))] //指定要编辑的脚本对象
    public class LanguageTextEditor : Editor
    {
        public LanguageSwitchWindow windows;

        private LanguageText script;

        // static void TextDestroy(MenuCommand menuCommand)
        // {
        //     Debug.Log("LanguageTextDestroy " + menuCommand.context.name);
        //     Undo.DestroyObjectImmediate(menuCommand.context);//可撤销的删除物体
        // }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            script = target as LanguageText;
            windows = LanguageSwitchWindow.windows;

            Color bak = GUI.color;

            GUILayout.Space(20);


            GUI.color = Color.black;
            GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
            GUI.color = bak;


            GUI.color = Color.green;

            if (GUILayout.Button("粘贴", GUILayout.Height(40)))
            {
                script.group = windows.groupsName[windows.groupIndex];
                script.key = windows.keysName[windows.keyIndex];
                script.GetComponent<Text>().text = windows.keysValue[windows.keyIndex];
                script.GetComponent<Text>().enabled = false;
                script.GetComponent<Text>().enabled = true;
            }
            GUI.color = bak;


            GUI.color = Color.cyan;

            if (GUILayout.Button("添加到窗口", GUILayout.Height(40)))
            {
                if (script.group != "")
                {
                    if (windows.groupsName.Contains(script.group))
                    {

                        windows.groupIndex = windows.groupsName
                        .FindIndex(0, windows.groupsName.Count
                        , (groupName) => groupName == script.group);
                    }
                    else
                    {
                        windows.AddGroup(script.group);
                    }

                    windows.OnGUI();
                    windows.Repaint();

                    if (windows.keysName.Contains(script.key))
                    {
                        windows.keyIndex = windows.keysName
                        .FindIndex(0, windows.keysName.Count
                        , (keyName) => keyName == script.key);

                        windows.keysValue[windows.keyIndex] = script.GetComponent<Text>().text;
                    }
                    else
                    {
                        windows.keysName.Add(script.key);
                        windows.keysValue.Add(script.GetComponent<Text>().text);
                    }
                }


            }

            GUI.color = bak;

            // base.OnInspectorGUI();


        }




    }
}