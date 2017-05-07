using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter1{
	public class FindEnemies : MonoBehaviour {


		private GameObject[] enemise;
		// Use this for initialization
		void Start () {
			searchEnemies ();
		}

		// Update is called once per frame
		void Update () {

		}

		void searchEnemies(){
			enemise = GameObject.FindGameObjectsWithTag("Enemy");

			if (enemise.Length > 0) {
				Debug.Log ("enemise Leanth:"+enemise.Length);
				foreach(GameObject go in enemise){
					mDebug (go.name);
				}
			}
		}


		void mDebug(string message){
			//  Debug.Log (message);
		}
	}

}
