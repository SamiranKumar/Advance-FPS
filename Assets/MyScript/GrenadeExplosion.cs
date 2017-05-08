using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter1{
	public class GrenadeExplosion : MonoBehaviour {

		private Collider[] hitColliders;
		public float blastRadius;


		void OnCollisionEnter(Collision col){
			//mDebug (col.contacts [0].point.ToString ());

			explosionWork (col.contacts [0].point); 
			Destroy (gameObject);
		}


		void explosionWork(Vector3 explositionPoint){
			hitColliders = Physics.OverlapSphere (explositionPoint, blastRadius);
			foreach (Collider hitCol in hitColliders) {
				mDebug (hitCol.gameObject.name);
			}
		
		}
		void mDebug(string message){
			Debug.Log (message);
		}
	}

}
