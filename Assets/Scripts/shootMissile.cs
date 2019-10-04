using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMissile : MonoBehaviour {

    
    public Transform target;
    public float speed = 1.0f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    // Update is called once per frame
    void FixedUpdate () {
       LookMoveTowards();
       // missile.transform.rotation = Quaternion.Euler(new Vector3(0, (Mathf.Rad2Deg * Mathf.Atan2(transform.position.x, transform.position.z)), 0));
    }
    void LookMoveTowards()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
