using UnityEngine;
using System.Collections;

public class HT_StartGame : MonoBehaviour {

	public HT_GameController gameController;

	public void OnMouseDown () {
		gameController.StartGame ();
	}
}