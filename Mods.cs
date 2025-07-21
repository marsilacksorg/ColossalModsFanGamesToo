using System;
using easyInputs;
using GorillaLocomotion;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
// using Photon.VR;
using UnityEngine;

namespace Colossal
{
	public class Mods : MelonMod
	{
		public void LoadMods()
		{
			// Movement Mods
			if (Plugin.excelfly)
			{
				if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
				{
					GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightHandTransform.right / 2f;
				}
				if (EasyInputs.GetPrimaryButtonDown(EasyHand.LeftHand))
				{
					GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftHandTransform.right / 2f;
				}
			}

			// Photon Mods
			if (Plugin.rigspam && EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand))
			{
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position + new Vector3(0.2f, 1.2f, -0.3f), GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
			}
			if (Plugin.rocketSpam && EasyInputs.GetGripButtonDown(EasyHand.RightHand))
			{
				PhotonNetwork.Instantiate("Boom2", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
			}
			if (Plugin.lagAll && EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
			{
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.LocalPlayer);
				PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
			}
			if (Plugin.deactivateVents)
			{
				PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
				foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerListOthers)
				{
					if (player.NickName.Contains("size") || player.NickName.Contains("red") || player.NickName.Contains("blue") || player.NickName.Contains("green") || player.NickName.Contains("purple") || player.NickName.Contains("black") || player.NickName.Contains(" "))
					{
						PhotonNetwork.TransferOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
						PhotonNetwork.RequestOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.DestroyPlayerObjects(player);
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.CloseConnection(player);
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.ActorNumber));
						PhotonNetwork.Destroy(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
						PhotonNetwork.LocalCleanPhotonView(PhotonNetwork.GetPhotonView(player.actorNumber));
					}
				}
			}

			// I Forgot Mods
			if (Plugin.Speed)
			{
				GorillaLocomotion.Player.Instance.maxJumpSpeed = 90f;
				GorillaLocomotion.Player.Instance.jumpMultiplier = 1.5f;
			}
			else
			{
				GorillaLocomotion.Player.Instance.maxJumpSpeed = 7f;
				GorillaLocomotion.Player.Instance.jumpMultiplier = 1.1f;
			}
			if (Plugin.Invis)
			{
				if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
				{
					PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.LocalPlayer);
				}
				if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
				{
					PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.LocalPlayer);
					PhotonNetwork.Instantiate("Gorillaprefabs/CebusGuy", GorillaLocomotion.Player.Instance.transform.position, GorillaLocomotion.Player.Instance.transform.rotation, 0, null);
				}
			}
			if (Plugin.FreezeMonke && EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
			{
				GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
			}
			if (Plugin.LongArms)
			{
				GorillaLocomotion.Player.Instance.rightHandOffset = new Vector3(0f, 0f, 0.25f);
				GorillaLocomotion.Player.Instance.leftHandOffset = new Vector3(0f, 0f, 0.25f);
			}
			else
			{
				GorillaLocomotion.Player.Instance.rightHandOffset = new Vector3(0f, 0f, 0f);
				GorillaLocomotion.Player.Instance.leftHandOffset = new Vector3(0f, 0f, 0f);
			}
			if (Plugin.Fly && EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
			{
				GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
				GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 30f;
			}
			if (Plugin.NoClip)
			{
				GorillaLocomotion.Player.Instance.bodyCollider.enabled = false;
				GorillaLocomotion.Player.Instance.headCollider.enabled = false;
			}
			if (!Plugin.NoClip)
			{
				GorillaLocomotion.Player.Instance.bodyCollider.enabled = true;
				GorillaLocomotion.Player.Instance.headCollider.enabled = true;
			}
			if (Plugin.AK)
			{
				// PhotonMan.SetCosmetic(5, "AK47MOD ONLY");
			}
			if (Plugin.ClearCosmetics)
			{
				// PhotonMan.SetCosmetic(5, "");
			}
		}

		public static void Destroy()
		{
			if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
			{
				RaycastHit raycastHit;
				Physics.Raycast(GorillaLocomotion.Player.Instance.rightHandTransform.position - GorillaLocomotion.Player.Instance.rightHandTransform.up, -GorillaLocomotion.Player.Instance.rightHandTransform.up, out raycastHit);
				if (Mods.Pointer == null)
				{
					Mods.Pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
					UnityEngine.Object.Destroy(Mods.Pointer.GetComponent<Rigidbody>());
					UnityEngine.Object.Destroy(Mods.Pointer.GetComponent<SphereCollider>());
					Mods.Pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
				}
				Mods.Pointer.transform.position = raycastHit.point;
				Photon.Realtime.Player owner = raycastHit.collider.GetComponentInParent<PhotonView>().Owner;
				if (EasyInputs.GetTriggerButtonFloat(EasyHand.RightHand) > 0.1f)
				{
					PhotonNetwork.DestroyPlayerObjects(owner);
				}
			}
			if (Mods.Pointer != null && !EasyInputs.GetGripButtonDown(EasyHand.RightHand))
			{
				UnityEngine.Object.Destroy(Mods.Pointer);
				Mods.Pointer = null;
			}
		}

		private Vector3 OffsetR = GorillaLocomotion.Player.Instance.rightHandOffset;

		private Vector3 OffsetL = GorillaLocomotion.Player.Instance.leftHandOffset;

		private bool InvisDoOnce;

		private bool lresetInvisDoOnce;

		public static GameObject Pointer;

		private bool invisOnce;
	}
}
