using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

//	[SyncVar]
//	public string playerName;
//
//	void OnGUI() {
//		if (isLocalPlayer) {
//			playerName = GUI.TextField (new Rect (25, Screen.height - 40, 100, 30), playerName);
//			if(GUI.Button(new Rect(130, Screen.height - 40, 80, 30), "Change")) {
//				CmdChangeName (playerName);
//			}
//		}
//	}

//	[Command]
//	public void CmdChangeName(string playerName) {
//		playerName = playerName;
//	}

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GetComponent<ShipController> ().enabled = true;
            //Camera.main.transform.position = this.transform.position - this.transform.forward * 10
           	// + this.transform.up * 1;
            //Camera.main.transform.LookAt (this.transform.position);
            Camera.main.transform.parent = this.transform;
            
        }
	}

	void update() {
        //		if (isLocalPlayer) {
        //			this.GetComponentInChildren<TextMesh> ().text = playerName;
        //		}
        
    }

}
