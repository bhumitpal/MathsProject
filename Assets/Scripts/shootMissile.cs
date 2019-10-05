 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMissile : MonoBehaviour {

    
    public Transform target;
    Rigidbody2D missileRB;
    public float speed = 1.0f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        missileRB = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate () {
       LookMoveTowards();
       // missile.transform.rotation = Quaternion.Euler(new Vector3(0, (Mathf.Rad2Deg * Mathf.Atan2(transform.position.x, transform.position.z)), 0));
    }
    void LookMoveTowards()
    {
        float step = speed * Time.deltaTime;
        missileRB.gravityScale = 0;
        missileRB.AddForce(Vector3.back*step, ForceMode2D.Force);
        
    }
}
