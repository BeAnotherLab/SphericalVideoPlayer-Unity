using UnityEngine;
using System.Collections;

public class MenuLoader : MonoBehaviour {

	public GameObject loadingImage;

	void Update () {
		if (Input.GetKeyDown ("m")){
			Debug.Log ("you just pressed the correct key");
			loadingImage.SetActive (true);
			Application.LoadLevel(0);
		}
	}
}
