using UnityEngine;
using System.Collections;
using Vuforia;

public class Cambio : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject modelo1_, modelo2_,modelo3_,modelo4_;

	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			// Register with the virtual buttons TrackableBehaviour
			vbs[i].RegisterEventHandler(this);
		}
		modelo1_ = transform.FindChild("Modelo1").gameObject;
		modelo2_ = transform.FindChild("Modelo2").gameObject;
		modelo3_ = transform.FindChild("Modelo3").gameObject;
		modelo4_ = transform.FindChild("Modelo4").gameObject;
		modelo1_.SetActive (false);
		modelo2_.SetActive (false);
		modelo3_.SetActive (false);
		modelo4_.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		switch(vb.VirtualButtonName){
			case "Boton1": modelo1_.SetActive (true);
						 modelo2_.SetActive (false);
						 modelo3_.SetActive (false);
						modelo4_.SetActive (false);
						
						 break;
			case "Boton2": modelo1_.SetActive (false);
						 modelo2_.SetActive (true);
						 modelo3_.SetActive (false);
						modelo4_.SetActive (false);
						 break;
			case "Boton3": modelo1_.SetActive (false);
							modelo2_.SetActive (false);
							modelo3_.SetActive (true);
							modelo4_.SetActive (false);
							break;
			case "Boton4": modelo1_.SetActive (false);
							modelo2_.SetActive (false);
							modelo3_.SetActive (false);
							modelo4_.SetActive (true);
							break;
			break;
			//default: throw new UnityException("Button not supported: " + vb.VirtualButtonName); 
				//break;
				
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {}

}
