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
    public class SystemLinqEnumerableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Linq.Enumerable);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Average", _m_Average_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", _m_Max_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", _m_Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Range", _m_Range_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Sum", _m_Sum_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Linq.Enumerable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Average_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<int> _source = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<int>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<int>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<int>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<long> _source = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<long>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<long>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<long>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<long>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<long>>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<float>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<float> _source = (System.Collections.Generic.IEnumerable<float>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<float>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<float>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<float>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<float>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<double> _source = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<double>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<double>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<double>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<double>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<decimal>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<decimal> _source = (System.Collections.Generic.IEnumerable<decimal>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<decimal>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<decimal>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<decimal>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<decimal>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<decimal>>));
                    
                        var gen_ret = System.Linq.Enumerable.Average( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Linq.Enumerable.Average!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Max_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<int> _source = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<int>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<int>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<int>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<long> _source = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<long>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<long>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<long>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<long>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<long>>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<double> _source = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<double>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<double>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<double>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<double>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<float>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<float> _source = (System.Collections.Generic.IEnumerable<float>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<float>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<float>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<float>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<float>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<decimal>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<decimal> _source = (System.Collections.Generic.IEnumerable<decimal>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<decimal>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<decimal>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<decimal>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<decimal>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<decimal>>));
                    
                        var gen_ret = System.Linq.Enumerable.Max( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Linq.Enumerable.Max!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Min_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<int> _source = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<int>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<int>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<int>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<long> _source = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<long>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<long>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<long>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<long>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<long>>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<float>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<float> _source = (System.Collections.Generic.IEnumerable<float>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<float>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<float>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<float>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<float>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<double> _source = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<double>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<double>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<double>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<double>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<decimal>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<decimal> _source = (System.Collections.Generic.IEnumerable<decimal>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<decimal>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<decimal>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<decimal>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<decimal>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<decimal>>));
                    
                        var gen_ret = System.Linq.Enumerable.Min( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Linq.Enumerable.Min!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Range_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _start = LuaAPI.xlua_tointeger(L, 1);
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = System.Linq.Enumerable.Range( _start, _count );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Sum_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<int> _source = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<int>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<int>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<int>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<int>>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<long> _source = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<long>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<long>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<long>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<long>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<long>>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<float>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<float> _source = (System.Collections.Generic.IEnumerable<float>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<float>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<float>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<float>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<float>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<float>>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<double> _source = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<double>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<double>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<double>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<double>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<double>>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<decimal>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<decimal> _source = (System.Collections.Generic.IEnumerable<decimal>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<decimal>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Nullable<decimal>>>(L, 1)) 
                {
                    System.Collections.Generic.IEnumerable<System.Nullable<decimal>> _source = (System.Collections.Generic.IEnumerable<System.Nullable<decimal>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.IEnumerable<System.Nullable<decimal>>));
                    
                        var gen_ret = System.Linq.Enumerable.Sum( _source );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Linq.Enumerable.Sum!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
