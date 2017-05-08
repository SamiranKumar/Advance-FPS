using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter1{
	public class ThrowGrenade : MonoBehaviour {
		public GameObject mGrenadePrefab;
		private Transform mTransfron;

		public float propulsionForce = 30;

		// Use this for initialization
		void Start () {
			SetInitialReferences ();
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetButtonDown ("Fire1")) {
				spawnGrenade ();
			}
		}


		void SetInitialReferences(){

			mTransfron = transform;

		}


		void spawnGrenade(){
			GameObject grenade = (GameObject) Instantiate(mGrenadePrefab, mTransfron.TransformPoint (0, 0, .5f), mTransfron.rotation);

			grenade.GetComponent<Rigidbody> ().AddForce (mTransfron.forward * propulsionForce, ForceMode.Impulse);
			Destroy(grenade ,10); // destory grenade after 10 sec

		}
		void mDebug(string message){
			Debug.Log (message);
		}
	}

}


