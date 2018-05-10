using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ship_Move : MonoBehaviour {


    public float speed = 2;
    Rigidbody2D rg2d;
    public GameObject shot;
    private float fireTime;
    public float fireRate;
    public float xMin, xMax;
    private GameObject shot_clone;

    // Use this for initialization
    void Start() {
        rg2d = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        //ship movment
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rg2d.velocity = movement * speed;

          rg2d.position = new Vector2
          (
            Mathf.Clamp(rg2d.position.x, xMin, xMax),rg2d.position.y
         );

        //bullet
        if (Input.GetButton("Jump") && Time.time > fireTime) {
            fireTime = Time.time + fireRate;
            Fire();
        }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        shot_clone = Instantiate(shot, new Vector3(rg2d.position.x,rg2d.position.y + 0.5f), Quaternion.identity);
        Destroy(shot_clone, 2.0f);

        
    }
}
