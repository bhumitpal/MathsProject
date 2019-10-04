using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirection : MonoBehaviour {

    public Transform target;
    //public float xPos;
    //public float zPos;
    // Use this for initialization
    void Start () {
       // transform.position.Set(xPos,1,zPos);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetDir = target.position - transform.position;

        transform.rotation = Quaternion.Euler(new Vector3(0, (Mathf.Rad2Deg * Mathf.Atan2(targetDir.x, targetDir.z)), 0));



    }
}
