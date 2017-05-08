using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1{

	public class Shoot : MonoBehaviour {

		private float fireRate = 0.3f;
		private float nextFire;

		private RaycastHit hit;
		private float range = 300;

		private Transform mTransform;

		// Use this for initialization
		void Start () {
			setInitialReferences ();
		}

		// Update is called once per frame
		void Update () {
			checkForInput ();
		}

		void setInitialReferences(){
			mTransform = transform;
		}

		void checkForInput(){
			/*
			if (Input.GetKey (KeyCode.Mouse0)  && Time.time >nextFire) {
				mDebug ("Key Press");
				nextFire = Time.time + fireRate;
			}
*/

			if (Input.GetButton("Fire1")  && Time.time > nextFire) {
				Debug.DrawRay (mTransform.TransformPoint(0,0,1), mTransform.forward, Color.green, 3);

				if(Physics.Raycast(mTransform .position,mTransform.forward,out hit,range)){

					if (hit.transform.CompareTag ("Enemy")) {
						mDebug ("Enemy: " + hit.transform.name);
					} else {
						mDebug ("Not Enemy: " + hit.transform.name);
						//Debug.Log ("Not Enemy:");
					}


				}


				//mDebug ("Key Press");
				nextFire = Time.time + fireRate;
			}

		}

		void mDebug(string message){
		//	Debug.Log (message);
		}

	}

}

