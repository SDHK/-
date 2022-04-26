#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.DictionaryExtension), SDHK_ExtensionDictionaryExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.GameObjectExtension), SDHK_ExtensionGameObjectExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.RectTransformExtension), SDHK_ExtensionRectTransformExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.StructExtension), SDHK_ExtensionStructExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.TransformExtension), SDHK_ExtensionTransformExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(SDHK_Extension.ObjectExtension), SDHK_ExtensionObjectExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(PathAssets.PathAsset), PathAssetsPathAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(WindowUI.WindowBaseExtension), WindowUIWindowBaseExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ObjectFactory.ObjectPoolExtension), ObjectFactoryObjectPoolExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(InputKeys.StringExtension), InputKeysStringExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(AsyncAwaitEvent.LuaAsyncAwait), AsyncAwaitEventLuaAsyncAwaitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(EventMachine.EventExecutorExtension), EventMachineEventExecutorExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Linq.Enumerable), SystemLinqEnumerableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.AutoPlay), DGTweeningAutoPlayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.AxisConstraint), DGTweeningAxisConstraintWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Ease), DGTweeningEaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.LogBehaviour), DGTweeningLogBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.LoopType), DGTweeningLoopTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.PathMode), DGTweeningPathModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.PathType), DGTweeningPathTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.RotateMode), DGTweeningRotateModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.ScrambleMode), DGTweeningScrambleModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenType), DGTweeningTweenTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.UpdateType), DGTweeningUpdateTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTween), DGTweeningDOTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOTweenModuleUI), DGTweeningDOTweenModuleUIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.DOVirtual), DGTweeningDOVirtualWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.EaseFactory), DGTweeningEaseFactoryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Tweener), DGTweeningTweenerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Tween), DGTweeningTweenWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Sequence), DGTweeningSequenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenParams), DGTweeningTweenParamsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.ABSSequentiable), DGTweeningCoreABSSequentiableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), DGTweeningCoreTweenerCore_3_UnityEngineVector3UnityEngineVector3DGTweeningPluginsOptionsVectorOptions_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenExtensions), DGTweeningTweenExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.TweenSettingsExtensions), DGTweeningTweenSettingsExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DG.Tweening.ShortcutExtensions), DGTweeningShortcutExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.LuaBehaviour), XLuaTestLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.BaseTest), XLuaTestBaseTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Parent), XLuaTestFoo1ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Parent), XLuaTestFoo2ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Child), XLuaTestFoo1ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Child), XLuaTestFoo2ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo), XLuaTestFooWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.FooExtension), XLuaTestFooExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.InvokeLua.ICalc), XLuaTestInvokeLuaICalcBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate UnityEngine.Component __GEN_DELEGATE0( UnityEngine.GameObject rootObj,  System.Type type,  string childName);
		
		delegate UnityEngine.Component __GEN_DELEGATE1( UnityEngine.GameObject rootObj,  System.Type type);
		
		delegate UnityEngine.GameObject __GEN_DELEGATE2( UnityEngine.GameObject root,  string childName);
		
		delegate UnityEngine.RectTransform __GEN_DELEGATE3( UnityEngine.RectTransform rtf);
		
		delegate UnityEngine.Color __GEN_DELEGATE4( UnityEngine.Color color,  float a);
		
		delegate UnityEngine.Transform __GEN_DELEGATE5( UnityEngine.Transform tf);
		
		delegate UnityEngine.RectTransform __GEN_DELEGATE6( UnityEngine.Transform tf);
		
		delegate UnityEngine.Transform __GEN_DELEGATE7( UnityEngine.Transform root,  string childName);
		
		delegate bool __GEN_DELEGATE8( UnityEngine.Object target);
		
		delegate object __GEN_DELEGATE9( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate object __GEN_DELEGATE10( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate void __GEN_DELEGATE11( System.Collections.Generic.Dictionary<string, object> dic,  object value,  string path);
		
		delegate void __GEN_DELEGATE12( System.Collections.Generic.Dictionary<string, object> dic,  object value,  string[] keys);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE13( System.Collections.Generic.Dictionary<string, object> dic,  int index,  string[] keys);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE14( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE15( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate void __GEN_DELEGATE16( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate void __GEN_DELEGATE17( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate bool __GEN_DELEGATE18( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate bool __GEN_DELEGATE19( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate System.Collections.Generic.List<string> __GEN_DELEGATE20( System.Collections.Generic.Dictionary<string, object> dic);
		
		delegate void __GEN_DELEGATE21( WindowUI.IWindow window);
		
		delegate ObjectFactory.ObjectPoolBase __GEN_DELEGATE22( ObjectFactory.ObjectPoolBase objectPool);
		
		delegate void __GEN_DELEGATE23( ObjectFactory.ObjectPoolBase objectPool);
		
		delegate void __GEN_DELEGATE24( string group,  string key);
		
		delegate InputKeys.InputKeyCodes __GEN_DELEGATE25( string group,  string key);
		
		delegate void __GEN_DELEGATE26( string group,  string key,  InputKeys.InputKeyCodes keyCodes);
		
		delegate bool __GEN_DELEGATE27( string group,  string key);
		
		delegate bool __GEN_DELEGATE28( string group,  string key);
		
		delegate bool __GEN_DELEGATE29( string group,  string key);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE30( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE31( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE32( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE33( EventMachine.EventExecutor executor,  EventMachine.EventExecutor subExecutor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE34( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE35( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE36( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE37( EventMachine.EventExecutor executor,  System.Action<EventMachine.EventExecutor> action);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE38( EventMachine.EventExecutor executor,  System.Action action);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE39( EventMachine.EventExecutor executor,  int secondsDelay,  System.Action<EventMachine.EventExecutor> update);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE40( EventMachine.EventExecutor executor,  int secondsDelay);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE41( EventMachine.EventExecutor executor,  System.Action<EventMachine.EventExecutor> loopUpdate);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE42( EventMachine.EventExecutor executor,  System.Action loopUpdate);
		
		delegate double __GEN_DELEGATE43( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE44( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate double __GEN_DELEGATE45( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE46( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE47( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE48( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE49( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE50( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE51( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE52( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE53( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE54( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE55( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE56( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate double __GEN_DELEGATE57( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE58( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate float __GEN_DELEGATE59( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE60( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate decimal __GEN_DELEGATE61( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE62( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE63( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE64( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE65( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE66( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE67( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE68( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE69( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE70( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE71( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE72( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE73( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE74( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE75( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE76( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE77( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE78( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE79( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE80( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE81( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE82( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE83( UnityEngine.CanvasGroup target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE84( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE85( UnityEngine.UI.Graphic target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE86( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE87( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE88( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE89( UnityEngine.UI.Image target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE90( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE91( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE92( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE93( UnityEngine.UI.Outline target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE94( UnityEngine.UI.Outline target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE95( UnityEngine.UI.Outline target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE96( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE97( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE98( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE99( UnityEngine.RectTransform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE100( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE101( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE102( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE103( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE104( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE105( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE106( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE107( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE108( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE109( UnityEngine.RectTransform target,  UnityEngine.Vector2 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE110( UnityEngine.RectTransform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE111( UnityEngine.RectTransform target,  float duration,  UnityEngine.Vector2 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE112( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE113( UnityEngine.UI.ScrollRect target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE114( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE115( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE116( UnityEngine.UI.Slider target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE117( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE118( UnityEngine.UI.Text target,  int fromValue,  int endValue,  float duration,  bool addThousandsSeparator,  System.Globalization.CultureInfo culture);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE119( UnityEngine.UI.Text target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> __GEN_DELEGATE120( UnityEngine.UI.Text target,  string endValue,  float duration,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE121( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE122( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE123( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE124( UnityEngine.RectTransform target,  UnityEngine.Vector2 center,  float endValueDegrees,  float duration,  bool relativeCenter,  bool snapping);
		
		delegate void __GEN_DELEGATE125( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE126( DG.Tweening.Tween t,  bool withCallbacks);
		
		delegate void __GEN_DELEGATE127( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE128( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE129( DG.Tweening.Tween t,  float to,  bool andPlay);
		
		delegate void __GEN_DELEGATE130( DG.Tweening.Tween t,  float to,  bool andPlay);
		
		delegate void __GEN_DELEGATE131( DG.Tweening.Tween t,  bool complete);
		
		delegate void __GEN_DELEGATE132( DG.Tweening.Tween t,  float deltaTime,  float unscaledDeltaTime);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE133( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE134( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE135( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE136( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE137( DG.Tweening.Tween t,  bool includeDelay,  float changeDelayTo);
		
		delegate void __GEN_DELEGATE138( DG.Tweening.Tween t,  bool includeDelay);
		
		delegate void __GEN_DELEGATE139( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE140( DG.Tweening.Tween t);
		
		delegate void __GEN_DELEGATE141( DG.Tweening.Tween t,  int waypointIndex,  bool andPlay);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE142( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE143( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE144( DG.Tweening.Tween t);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE145( DG.Tweening.Tween t,  int elapsedLoops);
		
		delegate UnityEngine.YieldInstruction __GEN_DELEGATE146( DG.Tweening.Tween t,  float position);
		
		delegate UnityEngine.Coroutine __GEN_DELEGATE147( DG.Tweening.Tween t);
		
		delegate int __GEN_DELEGATE148( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE149( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE150( DG.Tweening.Tween t);
		
		delegate float __GEN_DELEGATE151( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE152( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE153( DG.Tweening.Tween t,  bool includeLoops);
		
		delegate float __GEN_DELEGATE154( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE155( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE156( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE157( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE158( DG.Tweening.Tween t);
		
		delegate bool __GEN_DELEGATE159( DG.Tweening.Tween t);
		
		delegate int __GEN_DELEGATE160( DG.Tweening.Tween t);
		
		delegate UnityEngine.Vector3 __GEN_DELEGATE161( DG.Tweening.Tween t,  float pathPercentage);
		
		delegate UnityEngine.Vector3[] __GEN_DELEGATE162( DG.Tweening.Tween t,  int subdivisionsXSegment);
		
		delegate float __GEN_DELEGATE163( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE164( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE165( DG.Tweening.Tween t,  bool autoKillOnCompletion);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE166( DG.Tweening.Tween t,  object objectId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE167( DG.Tweening.Tween t,  string stringId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE168( DG.Tweening.Tween t,  int intId);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE169( DG.Tweening.Tween t,  UnityEngine.GameObject gameObject);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE170( DG.Tweening.Tween t,  UnityEngine.GameObject gameObject,  DG.Tweening.LinkBehaviour behaviour);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE171( DG.Tweening.Tween t,  object target);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE172( DG.Tweening.Tween t,  int loops);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE173( DG.Tweening.Tween t,  int loops,  DG.Tweening.LoopType loopType);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE174( DG.Tweening.Tween t,  DG.Tweening.Ease ease);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE175( DG.Tweening.Tween t,  DG.Tweening.Ease ease,  float overshoot);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE176( DG.Tweening.Tween t,  DG.Tweening.Ease ease,  float amplitude,  float period);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE177( DG.Tweening.Tween t,  UnityEngine.AnimationCurve animCurve);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE178( DG.Tweening.Tween t,  DG.Tweening.EaseFunction customEase);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE179( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE180( DG.Tweening.Tween t,  bool recyclable);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE181( DG.Tweening.Tween t,  bool isIndependentUpdate);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE182( DG.Tweening.Tween t,  DG.Tweening.UpdateType updateType);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE183( DG.Tweening.Tween t,  DG.Tweening.UpdateType updateType,  bool isIndependentUpdate);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE184( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE185( DG.Tweening.Tween t,  bool inverted);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE186( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE187( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE188( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE189( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE190( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE191( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE192( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE193( DG.Tweening.Tween t,  DG.Tweening.TweenCallback action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE194( DG.Tweening.Tween t,  DG.Tweening.TweenCallback<int> action);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE195( DG.Tweening.Tween t,  DG.Tweening.Tween asTween);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE196( DG.Tweening.Tween t,  DG.Tweening.TweenParams tweenParams);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE197( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE198( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE199( DG.Tweening.Sequence s,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE200( DG.Tweening.Sequence s,  float atPosition,  DG.Tweening.Tween t);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE201( DG.Tweening.Sequence s,  float interval);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE202( DG.Tweening.Sequence s,  float interval);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE203( DG.Tweening.Sequence s,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE204( DG.Tweening.Sequence s,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE205( DG.Tweening.Sequence s,  float atPosition,  DG.Tweening.TweenCallback callback);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE206( DG.Tweening.Tweener t);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE207( DG.Tweening.Tweener t,  bool isRelative);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE208( DG.Tweening.Tweener t,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE209( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  float fromAlphaValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE210( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  float fromValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE211( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float fromValueDegrees,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE212( DG.Tweening.Tween t,  float delay);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE213( DG.Tweening.Tween t,  float delay,  bool asPrependedIntervalIfSequence);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE214( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE215( DG.Tweening.Tween t,  bool isRelative);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE216( DG.Tweening.Tween t);
		
		delegate DG.Tweening.Tween __GEN_DELEGATE217( DG.Tweening.Tween t,  bool isSpeedBased);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE218( DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE219( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE220( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE221( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE222( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE223( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE224( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE225( DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t,  bool useShortest360Route);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE226( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  bool alphaOnly);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE227( DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE228( DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE229( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE230( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE231( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float endValueDegrees,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE232( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE233( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  bool closePath,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE234( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE235( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE236( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE237( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE238( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE239( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE240( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE241( UnityEngine.Camera target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE242( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE243( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE244( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE245( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE246( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE247( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE248( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE249( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE250( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE251( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE252( UnityEngine.Light target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE253( UnityEngine.Light target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE254( UnityEngine.Light target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE255( UnityEngine.LineRenderer target,  DG.Tweening.Color2 startValue,  DG.Tweening.Color2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE256( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE257( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE258( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE259( UnityEngine.Material target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE260( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE261( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE262( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE263( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE264( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE265( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE266( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE267( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE268( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE269( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE270( UnityEngine.TrailRenderer target,  float toStartWidth,  float toEndWidth,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE271( UnityEngine.TrailRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE272( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE273( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE274( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE275( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE276( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE277( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE278( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE279( UnityEngine.Transform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE280( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE281( UnityEngine.Transform target,  UnityEngine.Quaternion endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> __GEN_DELEGATE282( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE283( UnityEngine.Transform target,  UnityEngine.Quaternion endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE284( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE285( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE286( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE287( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE288( UnityEngine.Transform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE289( UnityEngine.Transform target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE290( UnityEngine.Transform target,  UnityEngine.Vector3 towards,  float duration,  DG.Tweening.AxisConstraint axisConstraint,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE291( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE292( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE293( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE294( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE295( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE296( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE297( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE298( UnityEngine.Transform target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE299( UnityEngine.Transform target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE300( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE301( UnityEngine.Transform target,  UnityEngine.Vector3 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE302( UnityEngine.Transform target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE303( UnityEngine.Transform target,  UnityEngine.Vector3[] path,  float duration,  DG.Tweening.PathType pathType,  DG.Tweening.PathMode pathMode,  int resolution,  System.Nullable<UnityEngine.Color> gizmoColor);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE304( UnityEngine.Transform target,  DG.Tweening.Plugins.Core.PathCore.Path path,  float duration,  DG.Tweening.PathMode pathMode);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE305( UnityEngine.Transform target,  DG.Tweening.Plugins.Core.PathCore.Path path,  float duration,  DG.Tweening.PathMode pathMode);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE306( DG.Tweening.Tween target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE307( UnityEngine.Light target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE308( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE309( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE310( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE311( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE312( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE313( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE314( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration,  DG.Tweening.RotateMode mode);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE315( UnityEngine.Transform target,  UnityEngine.Vector3 punch,  float duration,  int vibrato,  float elasticity);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE316( UnityEngine.Transform target,  UnityEngine.Vector3 byValue,  float duration);
		
		delegate int __GEN_DELEGATE317( UnityEngine.Component target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE318( UnityEngine.Material target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE319( UnityEngine.Component target,  bool complete);
		
		delegate int __GEN_DELEGATE320( UnityEngine.Material target,  bool complete);
		
		delegate int __GEN_DELEGATE321( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE322( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE323( UnityEngine.Component target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE324( UnityEngine.Material target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE325( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE326( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE327( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE328( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE329( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE330( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE331( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE332( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE333( UnityEngine.Component target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE334( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE335( UnityEngine.Component target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE336( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE337( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE338( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE339( UnityEngine.Component target);
		
		delegate int __GEN_DELEGATE340( UnityEngine.Material target);
		
		delegate UnityEngine.RectTransform __GEN_DELEGATE341( UnityEngine.RectTransform rtf);
		
		delegate object __GEN_DELEGATE342( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate object __GEN_DELEGATE343( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate void __GEN_DELEGATE344( System.Collections.Generic.Dictionary<string, object> dic,  object value,  string path);
		
		delegate void __GEN_DELEGATE345( System.Collections.Generic.Dictionary<string, object> dic,  object value,  string[] keys);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE346( System.Collections.Generic.Dictionary<string, object> dic,  int index,  string[] keys);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE347( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate System.Collections.Generic.Dictionary<string, object> __GEN_DELEGATE348( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate void __GEN_DELEGATE349( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate void __GEN_DELEGATE350( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate bool __GEN_DELEGATE351( System.Collections.Generic.Dictionary<string, object> dic,  string path);
		
		delegate bool __GEN_DELEGATE352( System.Collections.Generic.Dictionary<string, object> dic,  string[] keys);
		
		delegate System.Collections.Generic.List<string> __GEN_DELEGATE353( System.Collections.Generic.Dictionary<string, object> dic);
		
		delegate void __GEN_DELEGATE354( WindowUI.IWindow window);
		
		delegate ObjectFactory.ObjectPoolBase __GEN_DELEGATE355( ObjectFactory.ObjectPoolBase objectPool);
		
		delegate void __GEN_DELEGATE356( ObjectFactory.ObjectPoolBase objectPool);
		
		delegate void __GEN_DELEGATE357( string group,  string key);
		
		delegate InputKeys.InputKeyCodes __GEN_DELEGATE358( string group,  string key);
		
		delegate void __GEN_DELEGATE359( string group,  string key,  InputKeys.InputKeyCodes keyCodes);
		
		delegate bool __GEN_DELEGATE360( string group,  string key);
		
		delegate bool __GEN_DELEGATE361( string group,  string key);
		
		delegate bool __GEN_DELEGATE362( string group,  string key);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE363( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE364( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE365( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE366( EventMachine.EventExecutor executor,  EventMachine.EventExecutor subExecutor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE367( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE368( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE369( EventMachine.EventExecutor executor);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE370( EventMachine.EventExecutor executor,  System.Action<EventMachine.EventExecutor> action);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE371( EventMachine.EventExecutor executor,  System.Action action);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE372( EventMachine.EventExecutor executor,  int secondsDelay,  System.Action<EventMachine.EventExecutor> update);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE373( EventMachine.EventExecutor executor,  int secondsDelay);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE374( EventMachine.EventExecutor executor,  System.Action<EventMachine.EventExecutor> loopUpdate);
		
		delegate EventMachine.EventExecutor __GEN_DELEGATE375( EventMachine.EventExecutor executor,  System.Action loopUpdate);
		
		delegate double __GEN_DELEGATE376( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE377( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate double __GEN_DELEGATE378( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE379( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE380( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE381( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE382( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE383( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE384( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE385( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE386( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE387( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE388( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE389( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate double __GEN_DELEGATE390( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE391( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate float __GEN_DELEGATE392( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE393( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate decimal __GEN_DELEGATE394( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE395( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE396( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE397( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE398( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE399( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE400( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE401( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE402( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE403( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE404( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE405( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate int __GEN_DELEGATE406( System.Collections.Generic.IEnumerable<int> source);
		
		delegate System.Nullable<int> __GEN_DELEGATE407( System.Collections.Generic.IEnumerable<System.Nullable<int>> source);
		
		delegate long __GEN_DELEGATE408( System.Collections.Generic.IEnumerable<long> source);
		
		delegate System.Nullable<long> __GEN_DELEGATE409( System.Collections.Generic.IEnumerable<System.Nullable<long>> source);
		
		delegate float __GEN_DELEGATE410( System.Collections.Generic.IEnumerable<float> source);
		
		delegate System.Nullable<float> __GEN_DELEGATE411( System.Collections.Generic.IEnumerable<System.Nullable<float>> source);
		
		delegate double __GEN_DELEGATE412( System.Collections.Generic.IEnumerable<double> source);
		
		delegate System.Nullable<double> __GEN_DELEGATE413( System.Collections.Generic.IEnumerable<System.Nullable<double>> source);
		
		delegate decimal __GEN_DELEGATE414( System.Collections.Generic.IEnumerable<decimal> source);
		
		delegate System.Nullable<decimal> __GEN_DELEGATE415( System.Collections.Generic.IEnumerable<System.Nullable<decimal>> source);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE416( UnityEngine.CanvasGroup target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE417( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE418( UnityEngine.UI.Graphic target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE419( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE420( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE421( UnityEngine.UI.Image target,  float endValue,  float duration);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE422( UnityEngine.UI.Image target,  UnityEngine.Gradient gradient,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE423( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE424( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE425( UnityEngine.UI.LayoutElement target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE426( UnityEngine.UI.Outline target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE427( UnityEngine.UI.Outline target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE428( UnityEngine.UI.Outline target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE429( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE430( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE431( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE432( UnityEngine.RectTransform target,  UnityEngine.Vector3 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE433( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE434( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE435( UnityEngine.RectTransform target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE436( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE437( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE438( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE439( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE440( UnityEngine.RectTransform target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE441( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE442( UnityEngine.RectTransform target,  UnityEngine.Vector2 punch,  float duration,  int vibrato,  float elasticity,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE443( UnityEngine.RectTransform target,  float duration,  float strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE444( UnityEngine.RectTransform target,  float duration,  UnityEngine.Vector2 strength,  int vibrato,  float randomness,  bool snapping,  bool fadeOut);
		
		delegate DG.Tweening.Sequence __GEN_DELEGATE445( UnityEngine.RectTransform target,  UnityEngine.Vector2 endValue,  float jumpPower,  int numJumps,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE446( UnityEngine.UI.ScrollRect target,  UnityEngine.Vector2 endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE447( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE448( UnityEngine.UI.ScrollRect target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE449( UnityEngine.UI.Slider target,  float endValue,  float duration,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE450( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> __GEN_DELEGATE451( UnityEngine.UI.Text target,  int fromValue,  int endValue,  float duration,  bool addThousandsSeparator,  System.Globalization.CultureInfo culture);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE452( UnityEngine.UI.Text target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> __GEN_DELEGATE453( UnityEngine.UI.Text target,  string endValue,  float duration,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE454( UnityEngine.UI.Graphic target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE455( UnityEngine.UI.Image target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE456( UnityEngine.UI.Text target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE457( UnityEngine.RectTransform target,  UnityEngine.Vector2 center,  float endValueDegrees,  float duration,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE458( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  float fromAlphaValue,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> __GEN_DELEGATE459( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float fromValueDegrees,  bool setImmediately,  bool isRelative);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE460( DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE461( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE462( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE463( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE464( DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE465( DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t,  bool useShortest360Route);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE466( DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t,  bool alphaOnly);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE467( DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE468( DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t,  bool richTextEnabled,  DG.Tweening.ScrambleMode scrambleMode,  string scrambleChars);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE469( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE470( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t,  DG.Tweening.AxisConstraint axisConstraint,  bool snapping);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE471( DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t,  float endValueDegrees,  bool relativeCenter,  bool snapping);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE472( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE473( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  bool closePath,  DG.Tweening.AxisConstraint lockPosition,  DG.Tweening.AxisConstraint lockRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE474( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE475( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Vector3 lookAtPosition,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE476( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE477( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  UnityEngine.Transform lookAtTransform,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE478( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  System.Nullable<UnityEngine.Vector3> forwardDirection,  System.Nullable<UnityEngine.Vector3> up);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> __GEN_DELEGATE479( DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t,  float lookAhead,  bool stableZRotation);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE480( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE481( UnityEngine.Camera target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE482( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE483( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE484( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE485( UnityEngine.Camera target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE486( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> __GEN_DELEGATE487( UnityEngine.Camera target,  UnityEngine.Rect endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE488( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE489( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE490( UnityEngine.Camera target,  float duration,  float strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE491( UnityEngine.Camera target,  float duration,  UnityEngine.Vector3 strength,  int vibrato,  float randomness,  bool fadeOut);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE492( UnityEngine.LineRenderer target,  DG.Tweening.Color2 startValue,  DG.Tweening.Color2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE493( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE494( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE495( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE496( UnityEngine.Material target,  float endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE497( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> __GEN_DELEGATE498( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE499( UnityEngine.Material target,  float endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE500( UnityEngine.Material target,  float endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE501( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE502( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE503( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE504( UnityEngine.Material target,  UnityEngine.Vector2 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE505( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  string property,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> __GEN_DELEGATE506( UnityEngine.Material target,  UnityEngine.Vector4 endValue,  int propertyID,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE507( UnityEngine.TrailRenderer target,  float toStartWidth,  float toEndWidth,  float duration);
		
		delegate DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> __GEN_DELEGATE508( UnityEngine.TrailRenderer target,  float endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE509( UnityEngine.Material target,  UnityEngine.Color endValue,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE510( UnityEngine.Material target,  UnityEngine.Color endValue,  string property,  float duration);
		
		delegate DG.Tweening.Tweener __GEN_DELEGATE511( UnityEngine.Material target,  UnityEngine.Color endValue,  int propertyID,  float duration);
		
		delegate int __GEN_DELEGATE512( UnityEngine.Material target,  bool withCallbacks);
		
		delegate int __GEN_DELEGATE513( UnityEngine.Material target,  bool complete);
		
		delegate int __GEN_DELEGATE514( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE515( UnityEngine.Material target,  float to,  bool andPlay);
		
		delegate int __GEN_DELEGATE516( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE517( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE518( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE519( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE520( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE521( UnityEngine.Material target,  bool includeDelay);
		
		delegate int __GEN_DELEGATE522( UnityEngine.Material target);
		
		delegate int __GEN_DELEGATE523( UnityEngine.Material target);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityEngine.GameObject), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(SDHK_Extension.GameObjectExtension.SetComponent)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE1(SDHK_Extension.GameObjectExtension.SetComponent)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE2(SDHK_Extension.GameObjectExtension.FindChildDeep)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.RectTransform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE3(SDHK_Extension.RectTransformExtension.RectAllStretch)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE96(DG.Tweening.DOTweenModuleUI.DOAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE97(DG.Tweening.DOTweenModuleUI.DOAnchorPosX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE98(DG.Tweening.DOTweenModuleUI.DOAnchorPosY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE99(DG.Tweening.DOTweenModuleUI.DOAnchorPos3D)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE100(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE101(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE102(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE103(DG.Tweening.DOTweenModuleUI.DOAnchorMax)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE104(DG.Tweening.DOTweenModuleUI.DOAnchorMin)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE105(DG.Tweening.DOTweenModuleUI.DOPivot)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE106(DG.Tweening.DOTweenModuleUI.DOPivotX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE107(DG.Tweening.DOTweenModuleUI.DOPivotY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE108(DG.Tweening.DOTweenModuleUI.DOSizeDelta)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE109(DG.Tweening.DOTweenModuleUI.DOPunchAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE110(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE111(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE112(DG.Tweening.DOTweenModuleUI.DOJumpAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE124(DG.Tweening.DOTweenModuleUI.DOShapeCircle)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE341(SDHK_Extension.RectTransformExtension.RectAllStretch)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE429(DG.Tweening.DOTweenModuleUI.DOAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE430(DG.Tweening.DOTweenModuleUI.DOAnchorPosX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE431(DG.Tweening.DOTweenModuleUI.DOAnchorPosY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE432(DG.Tweening.DOTweenModuleUI.DOAnchorPos3D)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE433(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE434(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE435(DG.Tweening.DOTweenModuleUI.DOAnchorPos3DZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE436(DG.Tweening.DOTweenModuleUI.DOAnchorMax)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE437(DG.Tweening.DOTweenModuleUI.DOAnchorMin)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE438(DG.Tweening.DOTweenModuleUI.DOPivot)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE439(DG.Tweening.DOTweenModuleUI.DOPivotX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE440(DG.Tweening.DOTweenModuleUI.DOPivotY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE441(DG.Tweening.DOTweenModuleUI.DOSizeDelta)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE442(DG.Tweening.DOTweenModuleUI.DOPunchAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE443(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE444(DG.Tweening.DOTweenModuleUI.DOShakeAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE445(DG.Tweening.DOTweenModuleUI.DOJumpAnchorPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE457(DG.Tweening.DOTweenModuleUI.DOShapeCircle)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Color), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE4(SDHK_Extension.StructExtension.A)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Transform), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE5(SDHK_Extension.TransformExtension.Default)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE6(SDHK_Extension.TransformExtension.GetRectTransform)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(SDHK_Extension.TransformExtension.FindChildDeep)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE272(DG.Tweening.ShortcutExtensions.DOMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE273(DG.Tweening.ShortcutExtensions.DOMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE274(DG.Tweening.ShortcutExtensions.DOMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE275(DG.Tweening.ShortcutExtensions.DOMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE276(DG.Tweening.ShortcutExtensions.DOLocalMove)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE277(DG.Tweening.ShortcutExtensions.DOLocalMoveX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE278(DG.Tweening.ShortcutExtensions.DOLocalMoveY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE279(DG.Tweening.ShortcutExtensions.DOLocalMoveZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE280(DG.Tweening.ShortcutExtensions.DORotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE281(DG.Tweening.ShortcutExtensions.DORotateQuaternion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE282(DG.Tweening.ShortcutExtensions.DOLocalRotate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE283(DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE284(DG.Tweening.ShortcutExtensions.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE285(DG.Tweening.ShortcutExtensions.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE286(DG.Tweening.ShortcutExtensions.DOScaleX)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE287(DG.Tweening.ShortcutExtensions.DOScaleY)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE288(DG.Tweening.ShortcutExtensions.DOScaleZ)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE289(DG.Tweening.ShortcutExtensions.DOLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE290(DG.Tweening.ShortcutExtensions.DODynamicLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE291(DG.Tweening.ShortcutExtensions.DOPunchPosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE292(DG.Tweening.ShortcutExtensions.DOPunchScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE293(DG.Tweening.ShortcutExtensions.DOPunchRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE294(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE295(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE296(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE297(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE298(DG.Tweening.ShortcutExtensions.DOShakeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE299(DG.Tweening.ShortcutExtensions.DOShakeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE300(DG.Tweening.ShortcutExtensions.DOJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE301(DG.Tweening.ShortcutExtensions.DOLocalJump)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE302(DG.Tweening.ShortcutExtensions.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE303(DG.Tweening.ShortcutExtensions.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE304(DG.Tweening.ShortcutExtensions.DOPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE305(DG.Tweening.ShortcutExtensions.DOLocalPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE311(DG.Tweening.ShortcutExtensions.DOBlendableMoveBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE312(DG.Tweening.ShortcutExtensions.DOBlendableLocalMoveBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE313(DG.Tweening.ShortcutExtensions.DOBlendableRotateBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE314(DG.Tweening.ShortcutExtensions.DOBlendableLocalRotateBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE315(DG.Tweening.ShortcutExtensions.DOBlendablePunchRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE316(DG.Tweening.ShortcutExtensions.DOBlendableScaleBy)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Object), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE8(SDHK_Extension.ObjectExtension.IsNull)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.Dictionary<string, object>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE9(PathAssets.PathAsset.Get)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE10(PathAssets.PathAsset.Get)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(PathAssets.PathAsset.Set)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE12(PathAssets.PathAsset.Set)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE13(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE14(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE15(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE16(PathAssets.PathAsset.RemoveNode)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE17(PathAssets.PathAsset.RemoveNode)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE18(PathAssets.PathAsset.ContainsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE19(PathAssets.PathAsset.ContainsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE20(PathAssets.PathAsset.GetKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE342(PathAssets.PathAsset.Get)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE343(PathAssets.PathAsset.Get)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE344(PathAssets.PathAsset.Set)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE345(PathAssets.PathAsset.Set)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE346(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE347(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE348(PathAssets.PathAsset.Node)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE349(PathAssets.PathAsset.RemoveNode)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE350(PathAssets.PathAsset.RemoveNode)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE351(PathAssets.PathAsset.ContainsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE352(PathAssets.PathAsset.ContainsPath)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE353(PathAssets.PathAsset.GetKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(WindowUI.IWindow), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE21(WindowUI.WindowBaseExtension.WindowClose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE354(WindowUI.WindowBaseExtension.WindowClose)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(ObjectFactory.ObjectPoolBase), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE22(ObjectFactory.ObjectPoolExtension.RegisterManager)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE23(ObjectFactory.ObjectPoolExtension.RemoveManager)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE355(ObjectFactory.ObjectPoolExtension.RegisterManager)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE356(ObjectFactory.ObjectPoolExtension.RemoveManager)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(string), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE24(InputKeys.StringExtension.InputRecordKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE25(InputKeys.StringExtension.InputGetKeyCodes)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE26(InputKeys.StringExtension.InputSetKeyCodes)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE27(InputKeys.StringExtension.InputGetKeysDown)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE28(InputKeys.StringExtension.InputGetKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE29(InputKeys.StringExtension.InputGetKeysUp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE357(InputKeys.StringExtension.InputRecordKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE358(InputKeys.StringExtension.InputGetKeyCodes)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE359(InputKeys.StringExtension.InputSetKeyCodes)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE360(InputKeys.StringExtension.InputGetKeysDown)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE361(InputKeys.StringExtension.InputGetKeys)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE362(InputKeys.StringExtension.InputGetKeysUp)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(EventMachine.EventExecutor), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE30(EventMachine.EventExecutorExtension.RunUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE31(EventMachine.EventExecutorExtension.RunLateUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE32(EventMachine.EventExecutorExtension.RunFixedUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE33(EventMachine.EventExecutorExtension.Wait)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE34(EventMachine.EventExecutorExtension.WaitUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE35(EventMachine.EventExecutorExtension.WaitLateUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE36(EventMachine.EventExecutorExtension.WaitFixedUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE37(EventMachine.EventExecutorExtension.Action)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE38(EventMachine.EventExecutorExtension.Action)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE39(EventMachine.EventExecutorExtension.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE40(EventMachine.EventExecutorExtension.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE41(EventMachine.EventExecutorExtension.Loop)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE42(EventMachine.EventExecutorExtension.Loop)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE363(EventMachine.EventExecutorExtension.RunUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE364(EventMachine.EventExecutorExtension.RunLateUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE365(EventMachine.EventExecutorExtension.RunFixedUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE366(EventMachine.EventExecutorExtension.Wait)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE367(EventMachine.EventExecutorExtension.WaitUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE368(EventMachine.EventExecutorExtension.WaitLateUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE369(EventMachine.EventExecutorExtension.WaitFixedUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE370(EventMachine.EventExecutorExtension.Action)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE371(EventMachine.EventExecutorExtension.Action)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE372(EventMachine.EventExecutorExtension.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE373(EventMachine.EventExecutorExtension.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE374(EventMachine.EventExecutorExtension.Loop)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE375(EventMachine.EventExecutorExtension.Loop)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<int>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE43(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE53(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE63(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE73(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE376(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE386(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE396(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE406(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE44(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE54(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE64(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE74(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE377(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE387(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE397(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE407(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<long>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE45(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE55(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE65(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE75(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE378(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE388(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE398(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE408(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<System.Nullable<long>>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE46(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE56(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE66(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE76(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE379(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE389(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE399(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE409(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<float>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE47(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE59(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE67(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE77(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE380(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE392(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE400(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE410(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE48(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE60(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE68(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE78(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE381(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE393(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE401(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE411(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<double>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE49(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE57(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE69(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE79(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE382(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE390(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE402(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE412(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE50(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE58(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE70(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE80(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE383(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE391(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE403(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE413(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<decimal>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE51(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE61(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE71(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE81(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE384(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE394(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE404(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE414(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.Generic.IEnumerable<System.Nullable<decimal>>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE52(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE62(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE72(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE82(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE385(System.Linq.Enumerable.Average)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE395(System.Linq.Enumerable.Max)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE405(System.Linq.Enumerable.Min)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE415(System.Linq.Enumerable.Sum)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.CanvasGroup), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE83(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE416(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Graphic), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE84(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE85(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE121(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE417(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE418(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE454(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Image), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE86(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE87(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE88(DG.Tweening.DOTweenModuleUI.DOFillAmount)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE89(DG.Tweening.DOTweenModuleUI.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE122(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE419(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE420(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE421(DG.Tweening.DOTweenModuleUI.DOFillAmount)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE422(DG.Tweening.DOTweenModuleUI.DOGradientColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE455(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.LayoutElement), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE90(DG.Tweening.DOTweenModuleUI.DOFlexibleSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE91(DG.Tweening.DOTweenModuleUI.DOMinSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE92(DG.Tweening.DOTweenModuleUI.DOPreferredSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE423(DG.Tweening.DOTweenModuleUI.DOFlexibleSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE424(DG.Tweening.DOTweenModuleUI.DOMinSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE425(DG.Tweening.DOTweenModuleUI.DOPreferredSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Outline), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE93(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE94(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE95(DG.Tweening.DOTweenModuleUI.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE426(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE427(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE428(DG.Tweening.DOTweenModuleUI.DOScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.ScrollRect), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE113(DG.Tweening.DOTweenModuleUI.DONormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE114(DG.Tweening.DOTweenModuleUI.DOHorizontalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE115(DG.Tweening.DOTweenModuleUI.DOVerticalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE446(DG.Tweening.DOTweenModuleUI.DONormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE447(DG.Tweening.DOTweenModuleUI.DOHorizontalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE448(DG.Tweening.DOTweenModuleUI.DOVerticalNormalizedPos)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Slider), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE116(DG.Tweening.DOTweenModuleUI.DOValue)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE449(DG.Tweening.DOTweenModuleUI.DOValue)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.UI.Text), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE117(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE118(DG.Tweening.DOTweenModuleUI.DOCounter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE119(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE120(DG.Tweening.DOTweenModuleUI.DOText)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE123(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE450(DG.Tweening.DOTweenModuleUI.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE451(DG.Tweening.DOTweenModuleUI.DOCounter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE452(DG.Tweening.DOTweenModuleUI.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE453(DG.Tweening.DOTweenModuleUI.DOText)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE456(DG.Tweening.DOTweenModuleUI.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Tween), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE125(DG.Tweening.TweenExtensions.Complete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE126(DG.Tweening.TweenExtensions.Complete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE127(DG.Tweening.TweenExtensions.Flip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE128(DG.Tweening.TweenExtensions.ForceInit)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE129(DG.Tweening.TweenExtensions.Goto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE130(DG.Tweening.TweenExtensions.GotoWithCallbacks)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE131(DG.Tweening.TweenExtensions.Kill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE132(DG.Tweening.TweenExtensions.ManualUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE133(DG.Tweening.TweenExtensions.Pause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE134(DG.Tweening.TweenExtensions.Play)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE135(DG.Tweening.TweenExtensions.PlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE136(DG.Tweening.TweenExtensions.PlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE137(DG.Tweening.TweenExtensions.Restart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE138(DG.Tweening.TweenExtensions.Rewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE139(DG.Tweening.TweenExtensions.SmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE140(DG.Tweening.TweenExtensions.TogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE141(DG.Tweening.TweenExtensions.GotoWaypoint)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE142(DG.Tweening.TweenExtensions.WaitForCompletion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE143(DG.Tweening.TweenExtensions.WaitForRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE144(DG.Tweening.TweenExtensions.WaitForKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE145(DG.Tweening.TweenExtensions.WaitForElapsedLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE146(DG.Tweening.TweenExtensions.WaitForPosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE147(DG.Tweening.TweenExtensions.WaitForStart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE148(DG.Tweening.TweenExtensions.CompletedLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE149(DG.Tweening.TweenExtensions.Delay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE150(DG.Tweening.TweenExtensions.ElapsedDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE151(DG.Tweening.TweenExtensions.Duration)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE152(DG.Tweening.TweenExtensions.Elapsed)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE153(DG.Tweening.TweenExtensions.ElapsedPercentage)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE154(DG.Tweening.TweenExtensions.ElapsedDirectionalPercentage)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE155(DG.Tweening.TweenExtensions.IsActive)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE156(DG.Tweening.TweenExtensions.IsBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE157(DG.Tweening.TweenExtensions.IsComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE158(DG.Tweening.TweenExtensions.IsInitialized)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE159(DG.Tweening.TweenExtensions.IsPlaying)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE160(DG.Tweening.TweenExtensions.Loops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE161(DG.Tweening.TweenExtensions.PathGetPoint)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE162(DG.Tweening.TweenExtensions.PathGetDrawPoints)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE163(DG.Tweening.TweenExtensions.PathLength)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE164(DG.Tweening.TweenSettingsExtensions.SetAutoKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE165(DG.Tweening.TweenSettingsExtensions.SetAutoKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE166(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE167(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE168(DG.Tweening.TweenSettingsExtensions.SetId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE169(DG.Tweening.TweenSettingsExtensions.SetLink)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE170(DG.Tweening.TweenSettingsExtensions.SetLink)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE171(DG.Tweening.TweenSettingsExtensions.SetTarget)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE172(DG.Tweening.TweenSettingsExtensions.SetLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE173(DG.Tweening.TweenSettingsExtensions.SetLoops)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE174(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE175(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE176(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE177(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE178(DG.Tweening.TweenSettingsExtensions.SetEase)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE179(DG.Tweening.TweenSettingsExtensions.SetRecyclable)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE180(DG.Tweening.TweenSettingsExtensions.SetRecyclable)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE181(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE182(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE183(DG.Tweening.TweenSettingsExtensions.SetUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE184(DG.Tweening.TweenSettingsExtensions.SetInverted)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE185(DG.Tweening.TweenSettingsExtensions.SetInverted)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE186(DG.Tweening.TweenSettingsExtensions.OnStart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE187(DG.Tweening.TweenSettingsExtensions.OnPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE188(DG.Tweening.TweenSettingsExtensions.OnPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE189(DG.Tweening.TweenSettingsExtensions.OnRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE190(DG.Tweening.TweenSettingsExtensions.OnUpdate)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE191(DG.Tweening.TweenSettingsExtensions.OnStepComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE192(DG.Tweening.TweenSettingsExtensions.OnComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE193(DG.Tweening.TweenSettingsExtensions.OnKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE194(DG.Tweening.TweenSettingsExtensions.OnWaypointChange)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE195(DG.Tweening.TweenSettingsExtensions.SetAs)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE196(DG.Tweening.TweenSettingsExtensions.SetAs)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE212(DG.Tweening.TweenSettingsExtensions.SetDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE213(DG.Tweening.TweenSettingsExtensions.SetDelay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE214(DG.Tweening.TweenSettingsExtensions.SetRelative)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE215(DG.Tweening.TweenSettingsExtensions.SetRelative)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE216(DG.Tweening.TweenSettingsExtensions.SetSpeedBased)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE217(DG.Tweening.TweenSettingsExtensions.SetSpeedBased)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE306(DG.Tweening.ShortcutExtensions.DOTimeScale)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Sequence), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE197(DG.Tweening.TweenSettingsExtensions.Append)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE198(DG.Tweening.TweenSettingsExtensions.Prepend)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE199(DG.Tweening.TweenSettingsExtensions.Join)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE200(DG.Tweening.TweenSettingsExtensions.Insert)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE201(DG.Tweening.TweenSettingsExtensions.AppendInterval)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE202(DG.Tweening.TweenSettingsExtensions.PrependInterval)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE203(DG.Tweening.TweenSettingsExtensions.AppendCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE204(DG.Tweening.TweenSettingsExtensions.PrependCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE205(DG.Tweening.TweenSettingsExtensions.InsertCallback)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Tweener), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE206(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE207(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE208(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE209(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE226(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE458(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE466(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE210(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE221(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE222(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE211(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE231(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE459(DG.Tweening.TweenSettingsExtensions.From)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE471(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE218(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE460(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE219(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE220(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE461(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE462(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE223(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE224(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE463(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE464(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE225(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE465(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE227(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE467(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE228(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE468(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE229(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE230(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE469(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE470(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE232(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE233(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE234(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE235(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE236(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE237(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE238(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE239(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE472(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE473(DG.Tweening.TweenSettingsExtensions.SetOptions)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE474(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE475(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE476(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE477(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE478(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE479(DG.Tweening.TweenSettingsExtensions.SetLookAt)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Camera), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE240(DG.Tweening.ShortcutExtensions.DOAspect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE241(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE242(DG.Tweening.ShortcutExtensions.DOFarClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE243(DG.Tweening.ShortcutExtensions.DOFieldOfView)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE244(DG.Tweening.ShortcutExtensions.DONearClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE245(DG.Tweening.ShortcutExtensions.DOOrthoSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE246(DG.Tweening.ShortcutExtensions.DOPixelRect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE247(DG.Tweening.ShortcutExtensions.DORect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE248(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE249(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE250(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE251(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE480(DG.Tweening.ShortcutExtensions.DOAspect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE481(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE482(DG.Tweening.ShortcutExtensions.DOFarClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE483(DG.Tweening.ShortcutExtensions.DOFieldOfView)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE484(DG.Tweening.ShortcutExtensions.DONearClipPlane)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE485(DG.Tweening.ShortcutExtensions.DOOrthoSize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE486(DG.Tweening.ShortcutExtensions.DOPixelRect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE487(DG.Tweening.ShortcutExtensions.DORect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE488(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE489(DG.Tweening.ShortcutExtensions.DOShakePosition)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE490(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE491(DG.Tweening.ShortcutExtensions.DOShakeRotation)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Light), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE252(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE253(DG.Tweening.ShortcutExtensions.DOIntensity)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE254(DG.Tweening.ShortcutExtensions.DOShadowStrength)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE307(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.LineRenderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE255(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE492(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Material), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE256(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE257(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE258(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE259(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE260(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE261(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE262(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE263(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE264(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE265(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE266(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE267(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE268(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE269(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE308(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE309(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE310(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE318(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE320(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE322(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE324(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE326(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE328(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE330(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE332(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE334(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE336(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE338(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE340(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE493(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE494(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE495(DG.Tweening.ShortcutExtensions.DOColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE496(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE497(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE498(DG.Tweening.ShortcutExtensions.DOFade)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE499(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE500(DG.Tweening.ShortcutExtensions.DOFloat)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE501(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE502(DG.Tweening.ShortcutExtensions.DOOffset)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE503(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE504(DG.Tweening.ShortcutExtensions.DOTiling)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE505(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE506(DG.Tweening.ShortcutExtensions.DOVector)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE509(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE510(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE511(DG.Tweening.ShortcutExtensions.DOBlendableColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE512(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE513(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE514(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE515(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE516(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE517(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE518(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE519(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE520(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE521(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE522(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE523(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.TrailRenderer), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE270(DG.Tweening.ShortcutExtensions.DOResize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE271(DG.Tweening.ShortcutExtensions.DOTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE507(DG.Tweening.ShortcutExtensions.DOResize)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE508(DG.Tweening.ShortcutExtensions.DOTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Component), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE317(DG.Tweening.ShortcutExtensions.DOComplete)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE319(DG.Tweening.ShortcutExtensions.DOKill)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE321(DG.Tweening.ShortcutExtensions.DOFlip)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE323(DG.Tweening.ShortcutExtensions.DOGoto)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE325(DG.Tweening.ShortcutExtensions.DOPause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE327(DG.Tweening.ShortcutExtensions.DOPlay)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE329(DG.Tweening.ShortcutExtensions.DOPlayBackwards)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE331(DG.Tweening.ShortcutExtensions.DOPlayForward)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE333(DG.Tweening.ShortcutExtensions.DORestart)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE335(DG.Tweening.ShortcutExtensions.DORewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE337(DG.Tweening.ShortcutExtensions.DOSmoothRewind)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE339(DG.Tweening.ShortcutExtensions.DOTogglePause)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
