using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour {

    // Use this for initialization
    public Transform turrettoSpawnFrom;
    public GameObject missile_green;

    void Start () {
        //turrettoSpawnFrom = GameObject.FindGameObjectWithTag("enemy1").transform;
        Instantiate(missile_green, turrettoSpawnFrom.transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
