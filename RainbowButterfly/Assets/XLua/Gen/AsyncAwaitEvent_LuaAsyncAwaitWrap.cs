#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class AsyncAwaitEventLuaAsyncAwaitWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AsyncAwaitEvent.LuaAsyncAwait);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AsyncTask", _m_AsyncTask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AsyncOperation", _m_AsyncOperation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AsyncDelay", _m_AsyncDelay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AsyncWait", _m_AsyncWait_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "AsyncAwaitEvent.LuaAsyncAwait does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncTask_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Threading.Tasks.Task>(L, 1)&& translator.Assignable<System.Action>(L, 2)) 
                {
                    System.Threading.Tasks.Task _async = (System.Threading.Tasks.Task)translator.GetObject(L, 1, typeof(System.Threading.Tasks.Task));
                    System.Action _onFinished = translator.GetDelegate<System.Action>(L, 2);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncTask( _async, _onFinished );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Threading.Tasks.Task>(L, 1)) 
                {
                    System.Threading.Tasks.Task _async = (System.Threading.Tasks.Task)translator.GetObject(L, 1, typeof(System.Threading.Tasks.Task));
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncTask( _async );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AsyncAwaitEvent.LuaAsyncAwait.AsyncTask!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncOperation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.AsyncOperation>(L, 1)&& translator.Assignable<System.Action>(L, 2)) 
                {
                    UnityEngine.AsyncOperation _async = (UnityEngine.AsyncOperation)translator.GetObject(L, 1, typeof(UnityEngine.AsyncOperation));
                    System.Action _onFinished = translator.GetDelegate<System.Action>(L, 2);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncOperation( _async, _onFinished );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.AsyncOperation>(L, 1)) 
                {
                    UnityEngine.AsyncOperation _async = (UnityEngine.AsyncOperation)translator.GetObject(L, 1, typeof(UnityEngine.AsyncOperation));
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncOperation( _async );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AsyncAwaitEvent.LuaAsyncAwait.AsyncOperation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncDelay_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Action>(L, 2)) 
                {
                    int _millisecondsDelay = LuaAPI.xlua_tointeger(L, 1);
                    System.Action _onFinished = translator.GetDelegate<System.Action>(L, 2);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncDelay( _millisecondsDelay, _onFinished );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _millisecondsDelay = LuaAPI.xlua_tointeger(L, 1);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncDelay( _millisecondsDelay );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AsyncAwaitEvent.LuaAsyncAwait.AsyncDelay!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncWait_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Func<bool>>(L, 1)&& translator.Assignable<System.Action>(L, 2)) 
                {
                    System.Func<bool> _boolFunc = translator.GetDelegate<System.Func<bool>>(L, 1);
                    System.Action _onFinished = translator.GetDelegate<System.Action>(L, 2);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncWait( _boolFunc, _onFinished );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Func<bool>>(L, 1)) 
                {
                    System.Func<bool> _boolFunc = translator.GetDelegate<System.Func<bool>>(L, 1);
                    
                    AsyncAwaitEvent.LuaAsyncAwait.AsyncWait( _boolFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AsyncAwaitEvent.LuaAsyncAwait.AsyncWait!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
