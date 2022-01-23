using System.Collections.Generic;
using SDHK_Extension;
using UnityEngine;
using UnityEngine.UI;
using LanguageSwitch;
using UnityEngine.EventSystems;
using System.IO;
using AssetBandleTool;
using InputKeys;
using System;
using System.Linq;
using WindowUI;
using EventDelegate_;
using ObjectPool_;
using CanvasLayer;
using DG.Tweening;

public class WindowArchive : WindowBase
{
    public static MonoObjectPool<WindowArchive> pool = new MonoObjectPool<WindowArchive>(Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_WindowArchive))
    { clock = 600, maxCount = 1 }
    .RegisterManager();

    public LanguageText archiveText;
    public Transform content;
    public Button returnBtn;
    public Button newBtn;

    public LanguageText returnBtnText;
    public LanguageText newBtnText;

    private CanvasServer canvasServer = CanvasServer.Instance();

    public List<ArchiveScrollBtn> archiveBtns = new List<ArchiveScrollBtn>();

    public List<FileInfo> FileInfos = new List<FileInfo>();


    public override void ObjectOnNew()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;

        gameObject.SetComponent(ref content, "Content");

        gameObject.SetComponent(ref archiveText, "ArchiveText")?.SetKey("存档界面", "存档标题");
        gameObject.SetComponent(ref returnBtnText, "ReturnBtnText")?.SetKey("存档界面", "返回");
        gameObject.SetComponent(ref newBtnText, "NewBtnText")?.SetKey("存档界面", "新建");

        gameObject.SetComponent(ref returnBtn, "ReturnBtn");
        gameObject.SetComponent(ref newBtn, "NewBtn");

        returnBtn?.onClick.AddListener(this.WindowClose);
        newBtn?.onClick.AddListener(ControlArchive.NewArchive);

    }
    public override void ObjectOnClear()
    {
        returnBtn?.onClick.RemoveListener(this.WindowClose);
        newBtn?.onClick.RemoveListener(ControlArchive.NewArchive);
    }


    public override void ObjectOnGet()
    {
        transform.SetParent(canvasServer.GetLayer(Cd.Layer1));
        Refresh();
    }

    public override void ObjectOnRecycle()
    {
        ArchiveBtnRecycle();
    }

    public override void WaitStackStateEnter(Action EnterDone)
    {
        transform.Default();
        RectAllStretch();
        
        CanvasGroup.DOFade(1, Cd.WindowFadeSpeed).OnComplete(() => EnterDone());
    }
    public override void WaitStackStateExit(Action ExitDone)
    {
        CanvasGroup.DOFade(0, Cd.WindowFadeSpeed).OnComplete(() => ExitDone());
    }


    public override void FocusStateEnter()
    {
        Refresh();
        base.FocusStateEnter();
        if (archiveBtns.Count > 0)
        {
            EventSystem.current.SetSelectedGameObject(archiveBtns[0].gameObject);//设置初始选中物体
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(newBtn.gameObject);//设置初始选中物体
        }
    }

    public override void FocusStateUpdate()
    {
        if ("界面快捷键".InputGetKeysDown("返回"))
        {
            this.WindowClose();
        }
    }


    public void Refresh()
    {
        ArchiveBtnRecycle();

        FileInfos = ModelGameArchive.GetNames();//读取文件名称
        FileInfos.Sort((f1, f2) => f2.CreationTime.CompareTo(f1.CreationTime));//排序：新的在前面

        foreach (var fileInfo in FileInfos)
        {
            ArchiveScrollBtn archiveScrollBtn = ArchiveScrollBtn.Pool.Get();
            archiveScrollBtn.transform.SetParent(content);

            archiveScrollBtn.Refresh(fileInfo);
            archiveBtns.Add(archiveScrollBtn);
        }
    }


    private void ArchiveBtnRecycle()
    {
        foreach (var archiveBtn in archiveBtns)//清空列表
        {
            archiveBtn.RecyclePool.Recycle(archiveBtn);
        }
        FileInfos.Clear();
        archiveBtns.Clear();
    }




}
