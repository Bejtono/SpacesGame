using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D rg2d;
    int score = 0;
	void Start () {
        rg2d.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rg2d.velocity = Vector2.up * 10;		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            score += 1;
            ScoreTextScript.scoreValue += 1;
            
        }
    }
}
