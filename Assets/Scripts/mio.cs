using UnityEngine;
using System.Collections;

public class mio : MonoBehaviour {
	private GameObject modelo1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//GameObject pause = GameObject.Find ("Modelo1");
			modelo1 = transform.FindChild("Modelo1").gameObject;
			modelo1.SetActive(true);
		}
	
	}

}
