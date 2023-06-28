using UnityEngine;
using LuaInterface;
using UnityEngine.Rendering;

public class ToLua_UnityEngine_Shader
{
    [NoToLuaAttribute]
    public static bool IsKeywordEnabled(ref UnityEngine.Rendering.GlobalKeyword keyword)
    {
		return false;
    }

	[NoToLuaAttribute]
	public static void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword)
	{

	}

	[NoToLuaAttribute]
	public static void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword)
	{
		
	}

	[NoToLuaAttribute]
	public static void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value)
	{

	}
}
