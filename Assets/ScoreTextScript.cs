using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextScript : MonoBehaviour {

    // Use this for initialization
    public static int scoreValue = 0;
	void Start () {
        this.gameObject.GetComponent<TextMesh>();
        

    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<TextMesh>().text = scoreValue.ToString();
	}
}
