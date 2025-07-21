using System;
using HarmonyLib;

[HarmonyPatch("OnTriggerEnter")]
public static class OnTriggerEnterPatch
{
	private static bool Prefix()
	{
		return false;
	}
}
