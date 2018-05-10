using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Enemy : MonoBehaviour {

    public GameObject Enemy;
    public
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet")
        {
            Destroy(col.gameObject);
        }
    }
}
