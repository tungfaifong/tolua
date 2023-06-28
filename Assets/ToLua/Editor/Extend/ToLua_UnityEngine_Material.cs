using UnityEngine;
using LuaInterface;
using UnityEngine.Rendering;

public class ToLua_UnityEngine_Material
{
    [NoToLuaAttribute]
    public bool IsKeywordEnabled(ref UnityEngine.Rendering.LocalKeyword keyword)
    {
		return false;
    }

	[NoToLuaAttribute]
	public void EnableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword)
	{

	}

	[NoToLuaAttribute]
	public void DisableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword)
	{
		
	}

	[NoToLuaAttribute]
	public void SetKeyword(ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
	{

	}
}
