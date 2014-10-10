using UnityEngine;
using System.Collections;

public class CamMove : MonoBehaviour {

	bool start = false;

	// Use this for initialization
	void Start () {
//		this.gameObject.GetComponent<iTweenEvent> ().tweenName = ""
	}
	
	// Update is called once per frame
	void Update () {
		if (start) {
//			iTween.
		}
	}

	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 250, 200, 100), "GO")) {
			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("pathUpstaircase1"), "easetype", "linear", "time",25, "islocal",true, "orientToPath",true, "lookTime", 0.2, "loopType", "none", "oncomplete", "cde"));
		}
	}

	public void abc () {
		Debug.Log ("Vaibhv");
		start = true;
//		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("pathUpstaircase1"), "easetype", "Ease In Circ", "time",25, "islocal",true, "orientToPath",true, "lookTime", 0.2, "loopType", "none", "oncomplete", "cde"));
	}

	public void cde () {
		Debug.Log ("Vaibhv2");
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("pathUpstaircase2"), "easetype", "linear", "time",25, "islocal",true, "orientToPath",true, "lookTime", 0.2, "loopType", "none", "oncomplete", "endPath"));
	}

	public void endPath () {
		Debug.Log ("Vaibhv3");
	}
}
