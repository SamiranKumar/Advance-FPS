using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1{

	public class TriggerExample : MonoBehaviour {


		private WalkThorughWalls mWalhThorughWalls;


		void Start(){
			SetInitialReferences ();
		}
		void OnTriggerEnter(Collider colider){
			mDebug (colider.name + " in OnTiggerEnter");
			mWalhThorughWalls.setLayerToNotSolid ();

		}

		void OnTriggerStay(Collider colider){
			mDebug (colider.name + " in OnTriggerStay");



		}
		void OnTriggerExit(Collider colider){
			mDebug (colider.name + " in OnTiggerExit");

			mWalhThorughWalls.setLayerToDefault ();

		}
		 
		void SetInitialReferences(){

			if (GameObject.Find ("Wall") != null) {
				mWalhThorughWalls = GameObject.Find ("Wall").GetComponent < WalkThorughWalls> ();
			}

		}

		void mDebug(string message){
			Debug.Log (message);
		}

	}


}
