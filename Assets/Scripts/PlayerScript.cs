using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    public float movementSpeed, tilt, xMin, xMax, zMin, zMax;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * movementSpeed * horizontalMovement * Time.deltaTime);
        transform.Translate(Vector3.forward * movementSpeed * verticalMovement * Time.deltaTime);
        //if (transform.localPosition.x >= xMax)
        //{
        //    print(true);
        //    transform.localPosition.Set(xMax, 1, transform.localPosition.z);
        //}
        //if (transform.localPosition.x <= xMin)
        //    transform.localPosition.Set(xMin, 1, transform.localPosition.z);
        transform.position = new Vector3(Mathf.Clamp(transform.localPosition.x, xMin, xMax), 1.0f, Mathf.Clamp(transform.localPosition.z, zMin, zMax));

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, horizontalMovement * -tilt);
        print(horizontalMovement + "   " + verticalMovement);

    }
}
