using System;
using System.Linq;
using easyInputs;
using GorillaLocomotion;
using Photon.Pun;
using Photon.Realtime;
// using Photon.VR;
using UnityEngine;
using UnityEngine.UI;

namespace Colossal.MenuStuff
{
	// SADLY I COULD NOT FIND THE OG COLOSSAL CEBUS MENU BUT I DID FIND A "MODDED" ONE
	public class Menu
	{
		public static void LoadOnce()
		{
			Menu.MainCamera = GameObject.Find("Main Camera");
			Menu.HUDObj = new GameObject();
			Menu.HUDObj2 = new GameObject();
			Menu.HUDObj2.name = "CLIENT_HUB";
			Menu.HUDObj.name = "CLIENT_HUB";
			Menu.HUDObj.AddComponent<Canvas>();
			Menu.HUDObj.AddComponent<CanvasScaler>();
			Menu.HUDObj.AddComponent<GraphicRaycaster>();
			Menu.HUDObj.GetComponent<Canvas>().enabled = true;
			Menu.HUDObj.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
			Menu.HUDObj.GetComponent<Canvas>().worldCamera = Menu.MainCamera.GetComponent<Camera>();
			Menu.HUDObj.GetComponent<RectTransform>().sizeDelta = new Vector2(5f, 5f);
			Menu.HUDObj.GetComponent<RectTransform>().position = new Vector3(Menu.MainCamera.transform.position.x, Menu.MainCamera.transform.position.y, Menu.MainCamera.transform.position.z);
			Menu.HUDObj2.transform.position = new Vector3(Menu.MainCamera.transform.position.x, Menu.MainCamera.transform.position.y, Menu.MainCamera.transform.position.z - 4.6f);
			Menu.HUDObj.transform.parent = Menu.HUDObj2.transform;
			Menu.HUDObj.GetComponent<RectTransform>().localPosition = new Vector3(0f, 0f, 1.6f);
			Vector3 eulerAngles = Menu.HUDObj.GetComponent<RectTransform>().rotation.eulerAngles;
			eulerAngles.y = -270f;
			Menu.HUDObj.transform.localScale = new Vector3(1f, 1f, 1f);
			Menu.HUDObj.GetComponent<RectTransform>().rotation = Quaternion.Euler(eulerAngles);
			Menu.Testtext = new GameObject
			{
				transform = 
				{
					parent = Menu.HUDObj.transform
				}
			}.AddComponent<Text>();
			Menu.Testtext.text = "";
			Menu.Testtext.fontSize = 10;
			Menu.Testtext.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			Menu.Testtext.rectTransform.sizeDelta = new Vector2(260f, 160f);
			Menu.Testtext.rectTransform.localScale = new Vector3(0.01f, 0.01f, 1f);
			Menu.Testtext.rectTransform.localPosition = new Vector3(-1.5f, 1f, 2f);
			Menu.Testtext.material = Menu.AlertText;
			Menu.NotifiText = Menu.Testtext;
			Menu.Testtext.alignment = TextAnchor.UpperLeft;
			Menu.HUDObj2.transform.transform.position = new Vector3(Menu.MainCamera.transform.position.x, Menu.MainCamera.transform.position.y, Menu.MainCamera.transform.position.z);
			Menu.HUDObj2.transform.rotation = Menu.MainCamera.transform.rotation;
            Menu.MainMenu = new MenuOption[5];
            Menu.MainMenu[0] = new MenuOption { DisplayName = "Movement", _type = "submenu", AssociatedString = "Movement" };
            Menu.MainMenu[1] = new MenuOption { DisplayName = "Photon", _type = "submenu", AssociatedString = "Photon" };
            Menu.MainMenu[2] = new MenuOption { DisplayName = "Extra", _type = "submenu", AssociatedString = "Cosmetics" };
            Menu.MainMenu[3] = new MenuOption { DisplayName = "All Credit Goes To Colossus", _type = "submenu", AssociatedString = "Player" };
            Menu.MainMenu[4] = new MenuOption { DisplayName = "Modified By Livku", _type = "button", AssociatedString = "wcd" };

            Menu.Movement = new MenuOption[7];
            Menu.Movement[0] = new MenuOption { DisplayName = "ExcelFly", _type = "toggle", AssociatedBool = false };
            Menu.Movement[1] = new MenuOption { DisplayName = "Speed", _type = "toggle", AssociatedBool = false };
            Menu.Movement[2] = new MenuOption { DisplayName = "Fly", _type = "toggle", AssociatedBool = false };
            Menu.Movement[3] = new MenuOption { DisplayName = "LongArms", _type = "toggle", AssociatedBool = false };
            Menu.Movement[4] = new MenuOption { DisplayName = "FreezeMonke", _type = "toggle", AssociatedBool = false };
            Menu.Movement[5] = new MenuOption { DisplayName = "dsc.gg/livku", _type = "button", AssociatedString = "false" };
            Menu.Movement[6] = new MenuOption { DisplayName = "Back", _type = "submenu", AssociatedString = "Back" };

            Menu.Photonn = new MenuOption[10];
            Menu.Photonn[0] = new MenuOption { DisplayName = "DestroyAll", _type = "button", AssociatedString = "destroyall" };
            Menu.Photonn[1] = new MenuOption { DisplayName = "NameAll", _type = "button", AssociatedString = "nameall" };
            Menu.Photonn[2] = new MenuOption { DisplayName = "255 Lobby", _type = "button", AssociatedString = "255" };
            Menu.Photonn[3] = new MenuOption { DisplayName = "Room Name", _type = "button", AssociatedString = "roomname" };
            Menu.Photonn[4] = new MenuOption { DisplayName = "RigSpam", _type = "toggle", AssociatedBool = false };
            Menu.Photonn[5] = new MenuOption { DisplayName = "Disconnect", _type = "button", AssociatedString = "disconnect" };
            Menu.Photonn[6] = new MenuOption { DisplayName = "OwnerShip", _type = "button", AssociatedString = "ownership" };
            Menu.Photonn[7] = new MenuOption { DisplayName = "LagAll", _type = "toggle", AssociatedBool = false };
            Menu.Photonn[8] = new MenuOption { DisplayName = "RocketSpam", _type = "toggle", AssociatedBool = false };
            Menu.Photonn[9] = new MenuOption { DisplayName = "Back", _type = "submenu", AssociatedString = "Back" };

            Menu.Cosmetics = new MenuOption[13];
            Menu.Cosmetics[0] = new MenuOption { DisplayName = "Strobe", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[1] = new MenuOption { DisplayName = "Stick", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[2] = new MenuOption { DisplayName = "Anti-AntiHacker", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[3] = new MenuOption { DisplayName = "Impersonate Wizz", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[4] = new MenuOption { DisplayName = "NoTrigger", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[5] = new MenuOption { DisplayName = "Invis", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[6] = new MenuOption { DisplayName = "NoMap", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[7] = new MenuOption { DisplayName = "IdentityEvil", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[8] = new MenuOption { DisplayName = "IdentityGood", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[9] = new MenuOption { DisplayName = "ClearCosmetics", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[10] = new MenuOption { DisplayName = "AntiHacker", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[11] = new MenuOption { DisplayName = "RGB", _type = "toggle", AssociatedBool = false };
            Menu.Cosmetics[12] = new MenuOption { DisplayName = "Back", _type = "submenu", AssociatedString = "Back" };

            Menu.Player = new MenuOption[1];
            Menu.Player[0] = new MenuOption { DisplayName = "Back", _type = "submenu", AssociatedString = "Back" };

            Menu.MenuState = "Main";
            Menu.CurrentViewingMenu = Menu.MainMenu;
            Menu.UpdateMenuState(new MenuOption(), null, null);

        }

        public static void Load()
		{
			if (EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand) && EasyInputs.GetThumbStickButtonDown(EasyHand.RightHand) && !Menu.menutogglecooldown)
			{
				Menu.menutogglecooldown = true;
				Menu.HUDObj2.SetActive(!Menu.HUDObj2.activeSelf);
				Menu.GUIToggled = !Menu.GUIToggled;
			}
			if (!EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand) && !EasyInputs.GetThumbStickButtonDown(EasyHand.RightHand) && Menu.menutogglecooldown)
			{
				Menu.menutogglecooldown = false;
			}
			if (Menu.GUIToggled)
			{
				Menu.HUDObj2.transform.position = new Vector3(Menu.MainCamera.transform.position.x, Menu.MainCamera.transform.position.y, Menu.MainCamera.transform.position.z);
				Menu.HUDObj2.transform.rotation = Menu.MainCamera.transform.rotation;
				if (EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand))
				{
					if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) && !Menu.inputcooldown)
					{
						Menu.inputcooldown = true;
						if (Menu.SelectedOptionIndex + 1 == Enumerable.Count<MenuOption>(Menu.CurrentViewingMenu))
						{
							Menu.SelectedOptionIndex = 0;
						}
						else
						{
							Menu.SelectedOptionIndex++;
						}
						Menu.UpdateMenuState(new MenuOption(), null, null);
					}
					if (EasyInputs.GetGripButtonDown(EasyHand.RightHand) && !Menu.inputcooldown)
					{
						Menu.inputcooldown = true;
						Menu.UpdateMenuState(Menu.CurrentViewingMenu[Menu.SelectedOptionIndex], null, "optionhit");
					}
					if (!EasyInputs.GetTriggerButtonDown(EasyHand.RightHand) && !EasyInputs.GetGripButtonDown(EasyHand.RightHand) && Menu.inputcooldown)
					{
						Menu.inputcooldown = false;
					}
				}
			}
			Plugin.excelfly = Menu.Movement[0].AssociatedBool;
			Plugin.Speed = Menu.Movement[1].AssociatedBool;
			Plugin.Fly = Menu.Movement[2].AssociatedBool;
			Plugin.LongArms = Menu.Movement[3].AssociatedBool;
			Plugin.FreezeMonke = Menu.Movement[4].AssociatedBool;
			Plugin.rigspam = Menu.Photonn[4].AssociatedBool;
			Plugin.WizzImpersonate = Menu.Cosmetics[3].AssociatedBool;
			Plugin.GiantName = Menu.Cosmetics[2].AssociatedBool;
			Plugin.nameChange = Menu.Cosmetics[1].AssociatedBool;
			Plugin.KickAll = Menu.Cosmetics[0].AssociatedBool;
			Plugin.NoClip = Menu.Cosmetics[4].AssociatedBool;
			Plugin.lagAll = Menu.Photonn[7].AssociatedBool;
			Plugin.rocketSpam = Menu.Photonn[8].AssociatedBool;
			Plugin.noMap = Menu.Cosmetics[6].AssociatedBool;
			Plugin.Invis = Menu.Cosmetics[5].AssociatedBool;
			Plugin.AK = Menu.Cosmetics[6].AssociatedBool;
			Plugin.giveMenu = Menu.Cosmetics[7].AssociatedBool;
			Plugin.FakeAll = Menu.Cosmetics[8].AssociatedBool;
			Plugin.deactivateVents = Menu.Cosmetics[10].AssociatedBool;
			Plugin.RGB = Menu.Cosmetics[11].AssociatedBool;
			string text = string.Concat(new string[]
			{
				"<color=",
				Menu.MenuColour,
				">COLOSSAL : ",
				Menu.MenuState,
				"</color>\n"
			});
			int num = 0;
			if (Menu.CurrentViewingMenu != null)
			{
				foreach (MenuOption menuOption in Menu.CurrentViewingMenu)
				{
					if (Menu.SelectedOptionIndex == num)
					{
						text += ">";
					}
					text += menuOption.DisplayName;
					if (menuOption._type == "toggle")
					{
						if (menuOption.AssociatedBool)
						{
							text += " <color=black>[ON]</color>";
						}
						else
						{
							text += " <color=red>[OFF]</color>";
						}
					}
					text += "\n";
					num++;
				}
				Menu.Testtext.text = text;
				return;
			}
			Debug.Log("Null for some reason");
		}

		private static void UpdateMenuState(MenuOption option, string _MenuState, string OperationType)
		{
			try
			{
				if (OperationType == "optionhit")
				{
					if (option._type == "submenu")
					{
						if (option.AssociatedString == "Movement")
						{
							Menu.CurrentViewingMenu = Menu.Movement;
						}
						if (option.AssociatedString == "Cosmetics")
						{
							Menu.CurrentViewingMenu = Menu.Cosmetics;
						}
						if (option.AssociatedString == "Photon")
						{
							Menu.CurrentViewingMenu = Menu.Photonn;
						}
						if (option.AssociatedString == "Back")
						{
							Menu.CurrentViewingMenu = Menu.MainMenu;
						}
						Menu.MenuState = option.AssociatedString;
						Menu.SelectedOptionIndex = 0;
					}
					if (option._type == "toggle")
					{
						if (!option.AssociatedBool)
						{
							option.AssociatedBool = true;
							Debug.Log(string.Format("<color=magenta>Toggled {0} : {1}</color>", option.DisplayName, option.AssociatedBool));
						}
						else
						{
							option.AssociatedBool = false;
						}
					}

					// Buttons That Only Run One Time.
					if (option._type == "button")
					{
						if (option.AssociatedString == "wcd")
						{
							PhotonNetwork.Disconnect();
							// PhotonMan.JoinPrivateRoom("LIVKU", 255);
						}
						if (option.AssociatedString == "destroyall")
						{
							foreach (Photon.Realtime.Player targetPlayer in PhotonNetwork.PlayerListOthers)
							{
								PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
								PhotonNetwork.DestroyPlayerObjects(targetPlayer);
							}
						}
						if (option.AssociatedString == "nameall")
						{
							PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
							foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerListOthers)
							{
								if (player.actorNumber != PhotonNetwork.LocalPlayer.actorNumber)
								{
									PhotonNetwork.TransferOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									PhotonNetwork.RequestOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									player.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
									player.NickName = "<color=red> LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU  </color>";
								}
							}
						}
						if (option.AssociatedString == "255")
						{
							PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
							PhotonNetwork.CurrentRoom.maxPlayers = byte.MaxValue;
						}
						if (option.AssociatedString == "roomname")
						{
							PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
							PhotonNetwork.CurrentRoom.name = "<color=red> LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU LIVKU  </color>";
						}
						if (option.AssociatedString == "disconnect")
						{
							PhotonNetwork.LeaveRoom(true);
						}
						if (option.AssociatedString == "invisoff")
						{
							PhotonNetwork.Instantiate("PhotonVR/LocalPlayer", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
						}
						if (option.AssociatedString == "ownership")
						{
							foreach (Photon.Realtime.Player player2 in PhotonNetwork.PlayerListOthers)
							{
								if (player2.actorNumber != PhotonNetwork.LocalPlayer.actorNumber)
								{
									PhotonNetwork.TransferOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									PhotonNetwork.RequestOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									player2.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
									PhotonNetwork.TransferOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									PhotonNetwork.RequestOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									player2.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
									PhotonNetwork.TransferOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									PhotonNetwork.RequestOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									player2.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
									PhotonNetwork.TransferOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									PhotonNetwork.RequestOwnership(player2.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
									player2.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// GUI Stuff!
		public static bool GUIToggled = true;
		private static GameObject HUDObj;
		private static GameObject HUDObj2;
		private static GameObject MainCamera;
		private static Text Testtext;
		private static TextAnchor textAnchor = TextAnchor.UpperRight;
		private static Material AlertText = new Material(Shader.Find("GUI/Text Shader"));
		private static Text NotifiText;
		public static string MenuState = "Main";
		public static string MenuColour = "magenta";
		public static bool MenuRGB = false;
		public static float menurgb = 0f;

		public static int SelectedOptionIndex = 0;

		// Menu Tabs!
		public static MenuOption[] CurrentViewingMenu = null;

		public static MenuOption[] MainMenu;

		public static MenuOption[] Movement;

		public static MenuOption[] Cosmetics;

		public static MenuOption[] Photonn;

		public static MenuOption[] Player;

		public static bool inputcooldown = false;
		public static bool menutogglecooldown = false;
		public static bool driftmode = false;
	}
}
