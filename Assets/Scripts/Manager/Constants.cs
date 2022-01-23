using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 常量数据 Constant data
/// </summary>
public static class Cd
{
    #region Path
    public const string PathInputKeysDefault = "/Inputkeys/InputKeysDataDefault.InputKeys";
    public const string PathInputKeys = "/Inputkeys/InputKeysData.InputKeys";

    public const string PathScreenResolutionDefault = "/ScreenResolution/DataDefault.ScreenResolution";
    public const string PathScreenResolution = "/ScreenResolution/Data.ScreenResolution";

    public const string PathAB = "/AssetBundles/StandaloneWindows";
    public const string PathABmainName = "StandaloneWindows";
    public const string PathLanguageSwitch = "/LanguageSwitch";
    public const string PathGameData = "/GameData.json";
    public const string PathGameDataDefault = "/GameDataDefault.json";

    public const string PathGameArchive = "/GameArchive";
    public const string PathGameArchiveExtension = ".json";


    #endregion


    #region  Canvas
    public const string CanvasName = "WindowsCanvas";
    public const int Layer1 = 1;
    public const int Layer2 = 2;
    public const int Layer3 = 3;
    public const int Layer4 = 4;
    public const int Layer5 = 5;
    public const int Layer6 = 6;


    public const float WindowFadeSpeed = 0.3f;


    #endregion




    #region  Scene
    public const string SceneGameMenu = "GameMenu";

    #endregion


    #region  FSM
    public const string FSMgame = "游戏流程状态机";
    public const string FSM_mainMenuState = "主菜单状态";
    public const string FSM_optionsState = "设置菜单状态";

    #endregion


    #region  AB

    public const string ABgameValue = "gamevalue";//"0/gamevalue"
    public const string AB_GameValue = "GameValue";


    public const string ABpfb_ui = "pfb_ui";//"2/pfb_ui"
    public const string AB_WindowMain = "WindowMain";
    public const string AB_WindowArchive = "WindowArchive";
    public const string AB_ArchiveBtn = "ArchiveBtn";
    public const string AB_WindowGameSet = "WindowGameSet";
    public const string AB_KeyToggle = "KeyToggle";
    
    public const string AB_ScrollListKeyBind = "ScrollListKeyBind";
    public const string AB_ScrollListDropdown = "ScrollListDropdown";
    public const string AB_ScrollListToggle = "ScrollListToggle";
    public const string AB_ScrollListSlider = "ScrollListSlider";
    public const string AB_ScrollListButton = "ScrollListButton";
    public const string AB_ScrollListInputField = "ScrollListInputField";



    public const string AB_WindowInput = "WindowInput";
    public const string AB_WindowLoad = "WindowLoad";
    public const string AB_WindowConfirm = "WindowConfirm";
    public const string AB_WindowMask = "WindowMask";


    public const string AB_MouseCursor = "MouseCursor";
    public const string AB_UICanvasBox = "UICanvasBox";

    #endregion



}
