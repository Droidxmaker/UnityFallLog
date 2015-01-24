using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class BoxFallThrougth : MonoBehaviour {

    public class Trigger : MonoBehaviour { 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        }

        void OnTrigger(Collider myTrigger)
        {
            var currentPosition = transform.position;

            if (myTrigger.gameObject.name == "Box")
            {
                Debug.Log("Box went throught" + currentPosition); 
            }
        }

	}
}
