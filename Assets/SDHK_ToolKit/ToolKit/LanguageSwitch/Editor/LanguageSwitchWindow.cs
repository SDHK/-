using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using LitJson;
using System.Linq;
using System.Text.RegularExpressions;
using System;

namespace LanguageSwitch
{


    [Serializable]
    public class LanguageSwitchWindow : EditorWindow
    {
        public static LanguageSwitchWindow windows;
        public string fliePath = "";

        public List<string> groupsName = new List<string>();
        public List<string> keysName = new List<string>();
        public List<string> keysValue = new List<string>();



        private Dictionary<string, string> keyValues = new Dictionary<string, string>();

        private string msgBox = "可鼠标拖入文件夹";



        public int groupIndex = 0;
        private int groupIndexLast = 0;

        public int keyIndex = 0;


        private List<bool> keyBits = new List<bool>();


        private Vector2 keysScroll = new Vector2(0, 0);
        private Vector2 groupsScroll = new Vector2(0, 0);



        [MenuItem("SDHK_ToolKit/LanguageSwitch")]
        static void ShowWindow()
        {
            if (windows == null)
            {
                windows = EditorWindow.GetWindow<LanguageSwitchWindow>(false, "多语言绑定编辑器");
            }

            windows.Show();//显示窗口
        }


        private void OnEnable()
        {
            if (windows == null)
            {
                windows = this;
            }

            fliePath = EditorPrefs.GetString("LanguageSwitchFilePath");//

            LoadFile();
        }

        private void OnLostFocus()
        {
            SaveFile();
        }



        public void AddGroup(string groupName)
        {

            SaveFile();//保存当前文件

            groupIndex = groupsName.Count;
            groupIndexLast = groupIndex;


            groupsName.Add(groupName);
            keysValue.Clear();
            keysName.Clear();

        }


        public void OnGUI()
        {

            Color bak = GUI.color;



            GUILayout.Space(40);

            Rect rect = EditorGUILayout.GetControlRect();

            fliePath = EditorGUI.TextField(rect, fliePath);
            if ((Event.current.type == EventType.DragUpdated || Event.current.type == EventType.DragExited)
                && rect.Contains(Event.current.mousePosition))
            {
                //改变鼠标的外表  
                DragAndDrop.visualMode = DragAndDropVisualMode.Generic;

                if (DragAndDrop.paths != null && DragAndDrop.paths.Length > 0)
                {
                    fliePath = DragAndDrop.paths[0];
                    if (fliePath != "")
                    {
                        LoadFile();
                    }
                }
            }


            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("载入"))
            {
                if (fliePath != "")
                {
                    LoadFile();
                }
            }
            if (GUILayout.Button("预览..."))
            {
                string path = EditorUtility.OpenFolderPanel("载入", (Directory.Exists(fliePath)) ? Path.GetDirectoryName(fliePath) : fliePath, "");
                if (path != "")
                {
                    fliePath = path;
                    LoadFile();
                }
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.HelpBox(msgBox, MessageType.Info);


            GUI.color = Color.black;
            GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
            GUI.color = bak;

            EditorGUILayout.LabelField("当前文件夹：" + Path.GetFileName(fliePath));

            GUI.color = Color.black;
            GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
            GUI.color = bak;


            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();



            GUI.color = Color.green;
            if (GUILayout.Button("添加组", GUILayout.Height(50), GUILayout.Width(250)))
            {
                AddGroup("");
            }
            GUI.color = bak;

            EditorGUILayout.Space();
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space();



            GUI.color = Color.black;
            GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
            GUI.color = bak;



            groupsScroll = GUILayout.BeginScrollView(groupsScroll, GUILayout.ExpandHeight(false), GUILayout.Height(80));// GUILayout.MinHeight(80)
            groupIndex = GUILayout.SelectionGrid(groupIndex, groupsName.ToArray(), (groupsName.Count < 8) ? 1 : 2);
            GUILayout.EndScrollView();

            if (groupIndex != groupIndexLast)//切换组:载入新文件
            {
                SaveFile();//保存当前文件
                LoadFile();//载入新文件
            }

            GUI.color = Color.black;
            GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
            GUI.color = bak;



            GUILayout.Space(20);


            if (groupsName.Count > 0)
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.Space();

                GUILayout.Label("当前文件：", GUILayout.ExpandWidth(false));

                groupsName[groupIndex] = EditorGUILayout.TextField(groupsName[groupIndex]);

                GUI.color = Color.red;

                if (GUILayout.Button("删除当前组", GUILayout.Width(80)))
                {
                    File.Delete(fliePath + "/" + groupsName[groupIndex] + ".LanguageSwitch");
                    groupsName.RemoveAt(groupIndex);


                    LoadFile();//载入新文件

                }

                GUI.color = bak;


                EditorGUILayout.Space();
                EditorGUILayout.EndHorizontal();



                GUILayout.Space(20);


                GUI.color = Color.black;
                GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
                GUI.color = bak;

                EditorGUILayout.BeginHorizontal();
                if (GUILayout.Button("保存"))
                {
                    if (fliePath != "") SaveFile();
                }
                if (GUILayout.Button("另存为"))
                {
                    fliePath = EditorUtility.SaveFolderPanel("另存为", fliePath, "");

                    if (fliePath != "") { SaveFile(); }

                    fliePath = EditorPrefs.GetString("LanguageSwitchFilePath");
                }
                EditorGUILayout.EndHorizontal();

                GUI.color = Color.black;
                GUILayout.Box(new GUIContent(""), new[] { GUILayout.Height(2), GUILayout.ExpandWidth(true) });
                GUI.color = bak;





                keysScroll = GUILayout.BeginScrollView(keysScroll);




                if (keysName.Count > 0)
                {

                    for (int i = 0; i < keysName.Count; i++)
                    {

                        if (keyBits.Count < keysName.Count)
                        {
                            keyBits.Add(false);
                        }
                        else if (keyBits.Count > keysName.Count && keyBits.Count > 0)
                        {
                            keyBits.RemoveAt(keyBits.Count - 1);
                        }

                        EditorGUILayout.BeginHorizontal();


                        if (keyBits[i])
                        {
                            GUI.color = Color.cyan;
                            if (GUILayout.Button("收起", GUILayout.Width(120))) keyBits[i] = false;
                            GUI.color = bak;

                            GUILayout.Space(10);

                            keysName[i] = EditorGUILayout.TextField(keysName[i], GUILayout.MinWidth(150));

                        }
                        else
                        {
                            if (GUILayout.Button("展开", GUILayout.Width(60)))
                            {
                                keyBits[i] = true;
                            }
                            GUILayout.Space(10);

                            keysName[i] = EditorGUILayout.TextField(keysName[i], GUILayout.Width(150));
                        }


                        GUILayout.Space(10);

                        if (!keyBits[i])
                        {
                            keysValue[i] = EditorGUILayout.TextField(keysValue[i], GUILayout.Height(20), GUILayout.Width(150));
                            GUILayout.Space(10);
                        }

                        if (GUILayout.Button("插入", GUILayout.Width(40)))
                        {
                            keysName.Insert(i, "");
                            keysValue.Insert(i, "");
                            keyBits.Insert(i, false);
                        }

                        GUILayout.Space(10);

                        if (GUILayout.Button("删除", GUILayout.Width(60)))
                        {
                            keysName.RemoveAt(i);
                            keysValue.RemoveAt(i);
                            keyBits.RemoveAt(i);
                            continue;
                        }

                        GUILayout.Space(10);

                        GUI.color = (keyIndex == i) ? Color.green : bak;
                        if (GUILayout.Button("复制", GUILayout.Width(60)))
                        {
                            keyIndex = i;
                        }
                        GUI.color = bak;


                        EditorGUILayout.EndHorizontal();


                        if (keyBits[i])
                        {
                            EditorGUILayout.Space();

                            EditorGUILayout.BeginHorizontal();
                            GUILayout.Space(40);
                            keysValue[i] = EditorGUILayout.TextArea(keysValue[i], GUILayout.MinWidth(100));
                            GUILayout.Space(40);
                            EditorGUILayout.EndHorizontal();

                            GUILayout.Space(10);
                        }


                        EditorGUILayout.Space();

                    }

                }

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.Space();
                GUI.color = Color.yellow;

                if (GUILayout.Button("添加键", GUILayout.Height(50), GUILayout.Width(150)))
                {
                    keysName.Add("");
                    keysValue.Add("");
                }

                GUI.color = bak;
                EditorGUILayout.Space();
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(40);

                GUILayout.EndScrollView();

            }



        }

        public void LoadFile()
        {

            if (Directory.Exists(fliePath))
            {
                string path_ = "";
                groupsName = Directory.GetFiles(fliePath, "*.LanguageSwitch")
                .Select((fileName) => Path.GetFileNameWithoutExtension(fileName)).ToList();

                if (groupsName.Count > 0)
                {
                    if (groupIndex >= groupsName.Count && groupIndex > 0)
                    {
                        groupIndex = groupsName.Count - 1;
                    }
                    path_ = fliePath + "/" + groupsName[groupIndex] + ".LanguageSwitch";
                    keyValues = JsonMapper.ToObject<Dictionary<string, string>>(File.ReadAllText(path_));

                }

                keysName = keyValues.Keys.ToList();
                keysValue = keyValues.Values.ToList();
                msgBox = "载入完成 : " + path_;


                groupIndexLast = groupIndex;

                EditorPrefs.SetString("LanguageSwitchFilePath", fliePath);//保存到编辑器全局变量

            }

        }

        public void SaveFile()
        {
            if (fliePath != "")
            {
                Directory.CreateDirectory(fliePath);//如果文件夹不存在就创建它

                //查出当前不存在的旧文件并删除
                List<string> Oldfiles = Directory.GetFiles(fliePath, "*.LanguageSwitch")
                 .Select((fileName) => Path.GetFileNameWithoutExtension(fileName)).ToList().Except(groupsName).ToList();
                foreach (var Oldfile in Oldfiles)
                {
                    Debug.Log("删除文件:" + Oldfile);
                    File.Delete(fliePath + "/" + Oldfile + ".LanguageSwitch");
                }


                keyValues.Clear();
                for (int i = 0; i < keysName.Count; i++)
                {
                    keyValues.Add(keysName[i], keysValue[i]);
                }

                if (groupsName.Count > 0)
                {
                    string path_ = fliePath + "/" + groupsName[groupIndexLast] + ".LanguageSwitch";

                    File.WriteAllText(path_, Convert_String(JsonMapper.ToJson(keyValues)));
                    msgBox = "已保存 : " + path_;

                }
            }
        }

        /// <summary>
        /// 乱码转换：用于解决LitJson把类转换成string时出现的乱码
        /// </summary>
        /// <param name="source">乱码字符串</param>
        /// <returns>正常字符串</returns>
        public static string Convert_String(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase)
            .Replace(source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }

    }
}