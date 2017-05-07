using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1{
	
public class WelCome : MonoBehaviour {
		
		private string welcomeMessage = "Welcome";

		private Text textWelcome;
		public GameObject canvaceWelcome;
		public float waitTime = 3.5f;

		void Awake(){
			mDebug("awake()");
		}

		void OnEnable(){
			mDebug("OnEnable()");
		}



		// Use this for initialization
		void Start () {
			mDebug("Start ()");

			setInitialReferences ();
			mWelcomeMessage(welcomeMessage);
		}
		
		// Update is called once per frame
		void Update() {
			mDebug("Update ()");

		}


		void mDebug(string message){
			Debug.Log (message);
			//mWelcomeMessage("mWelcomeMessage()");
			//Debug.Log ("WelCome");
			//Debug.Log (welcomeMessage);
		}

		void setInitialReferences(){
			textWelcome = GameObject.Find ("WelcomeText").GetComponent<Text>(); //Find it By GameObjects Name
		}

		void mWelcomeMessage(string message){

			if (textWelcome != null) {
				textWelcome.text = message;
			} else {
				mDebug ("wellcome Text is Not Assinge");
			}

		//	Invoke ("DisableCanvace", 4.5f);    ///DisableCanvace() methord call after 4.f sec    ///Invoke methord hes two parameter one is methord name and two is time in second
			//DisableCanvace ();

			StartCoroutine (DisableCanvace (waitTime));

		}

		IEnumerator DisableCanvace(float waitTime){

			yield return new WaitForSeconds (waitTime);
			canvaceWelcome.SetActive (false);
		}


	}
}
