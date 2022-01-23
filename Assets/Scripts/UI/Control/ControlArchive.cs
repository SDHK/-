using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LanguageSwitch;
using UnityEngine;
using WindowUI;
using TaskMachine;
using CoroutineSystem;

public static class ControlArchive
{
    private static LanguageManager languageManager = LanguageManager.Instance();
    public static void LoadArchive(ArchiveScrollBtn archiveScrollBtn)
    {
        ModelGameArchive.Load(archiveScrollBtn.fileInfo.Name);
    }

    public static void DeleteArchive(ArchiveScrollBtn archiveScrollBtn)
    {
        ModelGameArchive.Delete(archiveScrollBtn.fileInfo.Name);
    }

    public static void NewArchive()
    {
        WindowInput.pool.WindowShow()
        .Refresh(
            languageManager.GetValue("提示", "存档命名"),

            languageManager.GetValue("战机名称", "玩家战机") + DateTime.Now.ToString("yyyyMMddhhmmss"),

            WindowInputCallBack,

            new List<string> { @"/", @"\", ".", " " }
        );
    }

    private static void WindowInputCallBack(string archiveName)
    {
        if (ModelGameArchive.GetNames().Any(fi => Path.GetFileNameWithoutExtension(fi.Name) == archiveName))
        {
            CoroutineEvent.CoroutineWait(() => WindowManager.Instance().IsDone, () =>
            {
                WindowConfirm.pool.WindowShow()
                .Refresh(
                    languageManager.GetValue("提示", "存档命名重复"),

                    (bit) => { if (bit) ModelGameArchive.New(archiveName + Cd.PathGameArchiveExtension); }
                );
            });
        }
        else
        {
            ModelGameArchive.New(archiveName + Cd.PathGameArchiveExtension);
        }
    }

}
