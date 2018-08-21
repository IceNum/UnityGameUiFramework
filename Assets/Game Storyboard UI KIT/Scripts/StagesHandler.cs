using UnityEngine;
using System.Collections;

/// <summary>
/// Stages scene handler.
/// </summary>
public class StagesHandler : MonoBehaviour
{
		// Use this for initialization
		IEnumerator Start ()
		{
				if (StorageManager.StagesStorageHelper.stagesDataRoot != null) {
						//apply data to stage elements in the scene
						StorageManager.StagesStorageHelper.ApplyDataToStageElementsInScene (StorageManager.StagesStorageHelper.stagesDataRoot.stagesParts);
				}

				GameObject.Find ("LoadingDots").GetComponent<DotsAimation> ().Stop ();//stop dots loading animation
				GameObject.Find ("loadingMenu").gameObject.SetActive (false);//hide loading menu		
				yield return 0;
		}
}