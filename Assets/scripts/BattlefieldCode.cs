using UnityEngine;
using System.Collections;

public class BattlefieldCode : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision col) {
		if (col.collider.gameObject.name=="Puck(Clone)") MakeDust(col);
		if (col.collider.gameObject.name=="Puck(Clone)" || col.collider.gameObject.name=="Brick(Clone)" || 
			col.collider.gameObject.name=="HalfBrick(Clone)") MakeThump();
	}	
	
	void MakeDust(Collision col) {
		if (Mathf.Abs((int) col.relativeVelocity.y) >10 ) {
			bool makeDust=true;
			if (col.gameObject.name=="Puck(Clone)") {
				if (col.gameObject.GetComponent<PuckCode>().castleResetFlag) makeDust=false;	
			}	
			if (makeDust)
			Instantiate(PrefabManager.puckDustPrefab,col.contacts[0].point,Quaternion.Euler(new Vector3(-90,0,0))); }
	}	
	
	void MakeThump() {
		if (MainGameCode.gamestate!=GAMESTATE.TITLE)
		AudioSource.PlayClipAtPoint(PrefabManager.puckHitGroundSound,PrefabManager.soundController.transform.position);	
	}	
	
}
