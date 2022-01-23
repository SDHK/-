using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SDHK_Extension;
using System.IO;
using LanguageSwitch;
using System;
using WindowUI;
using ObjectPool_;
using AssetBandleTool;
using EventDelegate_;

public class ArchiveScrollBtn : MonoBehaviour, IMonoObjectPoolItem
{
    public MonoObjectPoolBase RecyclePool { get; set; }

    public static MonoObjectPool<ArchiveScrollBtn> Pool = new MonoObjectPool<ArchiveScrollBtn>
    (Cd.ABpfb_ui.ABLoadAsset<GameObject>(Cd.AB_ArchiveBtn))
    { clock = 600 }
    .RegisterManager();


    public FileInfo fileInfo;

    public Text nameText;
    public LanguageText timeTitle;
    public Text timeText;

    public Button archiveBtn;
    public Button deleteBtn;

    private LanguageManager languageManager = LanguageManager.Instance();

    public void ObjectOnNew()
    {
        gameObject.SetComponent(ref archiveBtn);
        gameObject.SetComponent(ref deleteBtn, "DeleteBtn");

        gameObject.SetComponent(ref nameText, "ArchiveNameText");
        gameObject.SetComponent(ref timeTitle, "ArchiveTimeTitle");
        gameObject.SetComponent(ref timeText, "ArchiveTimeText");

        timeTitle.SetKey("存档界面", "存档日期标题");

        archiveBtn?.onClick.AddListener(BtnLoad);
        deleteBtn?.onClick.AddListener(BtnDelete);

    }

    public void ObjectOnClear()
    {
        archiveBtn?.onClick.RemoveListener(BtnLoad);
        deleteBtn?.onClick.RemoveListener(BtnDelete);
    }

    public void ObjectOnGet()
    {
    }

    public void ObjectOnRecycle()
    {
    }

    /// <summary>
    /// 刷新按钮
    /// </summary>
    public void Refresh(FileInfo fileInfo)
    {
        this.fileInfo = fileInfo;

        nameText.text = Path.GetFileNameWithoutExtension(fileInfo.Name);
        timeText.text = fileInfo.CreationTime.ToString() + "\n" + fileInfo.LastWriteTime.ToString();

        transform.Default();
    }

    private void BtnLoad()
    {
        ControlArchive.LoadArchive(this);
    }


    private void BtnDelete()
    {
        WindowConfirm.pool.WindowShow()
        .Refresh(languageManager.GetValue("提示", "存档删除确认") + nameText.text, ConfirmCallBack);
    }


    //确认窗回调
    private void ConfirmCallBack(bool bit)
    {
        if (bit)
        {
            ControlArchive.DeleteArchive(this);
            RecyclePool.Recycle(this);
        }
    }
}
