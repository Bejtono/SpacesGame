using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary_Destroy : MonoBehaviour {

    public GameObject bullet;

    void OnTriggerExit(Collider other)
    {
        Destroy(bullet);
    }
}
