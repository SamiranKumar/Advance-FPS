using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1{

	public class WalkThorughWalls : MonoBehaviour {

		private Color myColor = new Color(0.5f,1,.5f,1); //(0.5f,.5f,1);

		/*
		void OnEnable(){
			gameObject.layer = LayerMask.NameToLayer ("Not Solid");
		}

		void OnDisable(){


			gameObject.layer = LayerMask.NameToLayer ("Default");
		}
*/

		public void setLayerToNotSolid(){
			//OnEnable ();
			gameObject.layer = LayerMask.NameToLayer ("Not Solid");

			//GetComponent<Renderer> ().material.color = Color.blue;
			//GetComponent<Renderer> ().material.color = myColor;
			GetComponent<Renderer> ().material.SetColor("_Color", myColor);
		}

		public void setLayerToDefault(){
		//	OnDisable ();
		gameObject.layer = LayerMask.NameToLayer ("Default");
			GetComponent<Renderer> ().material.color = Color.black;
		}
	
	}

}
