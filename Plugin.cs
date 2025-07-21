using System;
using Colossal.MenuStuff;
using easyInputs;
using MelonLoader;
using Photon.Pun;
// using Photon.VR;
using UnityEngine;

namespace Colossal
{
	public class Plugin : MelonMod
	{
		public override void OnUpdate()
		{
			if (!this.doonce)
			{
				Menu.LoadOnce();
				this.doonce = true;
			}
			Menu.Load();
			new Mods().LoadMods();
			if (!PhotonNetwork.IsConnected)
			{
				PhotonNetwork.ConnectUsingSettings();
			}
			if (Plugin.noMap)
			{
				if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
				{
					GameObject.Find("Cebus ").SetActive(false);
				}
				if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
				{
					if (!this.CanResetMap)
					{
						GameObject.Find("Cebus ").SetActive(true);
						this.CanResetMap = true;
					}
				}
				else
				{
					this.CanResetMap = false;
				}
			}
			if (!Plugin.KickAll)
			{
				if (!Plugin.FakeAll && !Plugin.giveMenu)
				{
					if (Plugin.WizzImpersonate)
					{
						PhotonNetwork.LocalPlayer.NickName = "<color=purple><size=5>  WIZZ  </color></size>";
					}
					else
					{
						PhotonNetwork.LocalPlayer.NickName = "<size=5> LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU  </size>";
					}
					if (Plugin.nameChange)
					{
						// PhotonMan.SetCosmetic(5, "Stick ModR");
					}
				}
				if (Plugin.FakeAll)
				{
					PhotonNetwork.LocalPlayer.NickName = "<color=red><size=5> LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU  </color></size>";
					// PhotonMan.SetColour(new Color(99f, 99f, 99f));
				}
				if (Plugin.giveMenu)
				{
					PhotonNetwork.LocalPlayer.NickName = "<color=red><size=2>Ukvil</color></size>";
					// PhotonMan.SetColour(new Color(-99f, -99f, -99f));
				}
			}
			if (Plugin.GiantName)
			{
				PhotonNetwork.LocalPlayer.NickName = "LITTLETIMMY";
			}
			if (Plugin.KickAll)
			{
				if (!Plugin.GiantName)
				{
					PhotonNetwork.LocalPlayer.NickName = "<color=red><size=5> LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU  </color></size>";
				}
				float r = UnityEngine.Random.RandomRange(-99f, 99f);
				float g = UnityEngine.Random.RandomRange(-99f, 99f);
				float b = UnityEngine.Random.RandomRange(-99f, 99f);
				// PhotonMan.SetColour(new Color(r, g, b));
			}
			if (Plugin.RGB)
			{
				if (this.hue >= 1f)
				{
					this.hue = 0f;
				}
				this.hue += 0.01f;
				// PhotonMan.SetColour(Color.HSVToRGB(this.hue, 1f, 1f));
			}
		}

		private Color HexToColor(string hex)
		{
			Color white = Color.white;
			ColorUtility.TryParseHtmlString(hex, out white);
			return white;
		}

		// Mod Bools!
		private bool doonce;
		public static bool excelfly;
		public static bool rigspam;
		public static bool ghostmonkey;
		public static bool invismonkey;
		public Color startColor = new Color(1f, 0f, 1f);
		public Color endColor = new Color(0.5f, 0f, 1f);
		public float lerpDuration = 2f;
		private float lerpTimer;
		public static bool Speed;
		public static bool Fly;
		public static bool FreezeMonke;
		public static bool LongArms;
		public static bool WizzImpersonate;
		public static bool GiantName;
		public static bool nameChange;
		public static bool KickAll;
		public static bool NoClip;
		public static bool Modbadge;
		public static bool Invis;
		public static bool AK;
		public static bool AntiKick;
		public static bool FakeAll;
		public static bool activateVents;
		public static bool giveMenu;
		public static bool deactivateVents;
		public static bool ClearCosmetics;
		public static bool RGB;
		private float hue;
		public static bool lagAll;
		public static bool noMap;
		public static bool rocketSpam;
		private bool CanResetMap;
	}
}
