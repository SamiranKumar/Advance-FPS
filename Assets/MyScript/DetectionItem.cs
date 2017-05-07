﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter1{
	public class DetectionItem : MonoBehaviour {

		private float checkRate = 0.5f;
		private float range = 5; //5 metter or unite
		private float nextCheck = 0;

		private RaycastHit hit;


		private Transform mTransform;

		public LayerMask mLayerMask;

		// Use this for initialization
		void Start () {
			setInitialReferences();
		}

		// Update is called once per frame
		void Update () {
			detectItem ();
		}


		void setInitialReferences(){
			mTransform = transform;
		}

		void detectItem(){

			if(Time.time > nextCheck){
				nextCheck = Time.time + checkRate;

				//mDebug ("nextCheck :" + nextCheck);
				if (Physics.Raycast (mTransform.position, mTransform.forward, out hit, range, mLayerMask)) {
					mDebug(hit.transform.name+" is an Detect Item");
				}

			}

		}



		void mDebug(string message){
				Debug.Log (message);
		}
	}

}