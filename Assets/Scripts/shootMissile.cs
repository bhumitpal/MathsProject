using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMissile : MonoBehaviour {

    public GameObject missile;
    public Transform target;
    public float movementSpeed;
    public float travelTime;
    float timeElapsed = 0;

    // Use this for initialization
    void Start () {
        missile = Resources.Load<GameObject>("missile_green");
        Vector3 targetDir = target.position - missile.transform.position;
        GameObject.Instantiate(missile, transform.position, Quaternion.Euler(new Vector3(0, (Mathf.Rad2Deg * Mathf.Atan2(targetDir.x, targetDir.z)), 0)));
    }
    // Update is called once per frame
    void FixedUpdate () {
        //LookMoveTowards();
        missile.transform.rotation = Quaternion.Euler(new Vector3(0, (Mathf.Rad2Deg * Mathf.Atan2(transform.position.x, transform.position.z)), 0));
    }
    void LookMoveTowards()
    {

        //missile.transform.LookAt(target);

        //Vector3 targetDir = target.position - missile.transform.position;
        //missile.transform.rotation = Quaternion.Euler(new Vector3(0, 0,(Mathf.Rad2Deg * Mathf.Atan2(targetDir.x, targetDir.z))));
        //timeElapsed += Time.deltaTime;
        //missile.transform.position = Vector3.Lerp(missile.transform.position, target.position, (timeElapsed / travelTime));
    }
}
