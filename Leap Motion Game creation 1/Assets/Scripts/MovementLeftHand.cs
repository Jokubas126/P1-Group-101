using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeftHand : MonoBehaviour {

    public Rigidbody player; //for adding force
    public Transform playermove; //for constant movement and rotation

    public float push = 30f; // the size of the push when extending fingers
    public float velocity = 0.3f; // 

    public float stop = 0.35f; //speed of stopping 
    public float constantspeed = 0.3f; // speed of the plane, when nothing is being done

    public float angle = 0.4f;

    // Update is called once per frame
    void Update()
    {


        if (velocity > 0.3)
        {
            velocity -= stop * Time.deltaTime;
            playermove.Translate(Vector3.forward * velocity);
            playermove.Rotate(Vector3.up, velocity * -angle);
        }
        else
        {
            playermove.Translate(Vector3.forward * constantspeed * Time.deltaTime);
            playermove.Rotate(Vector3.up, velocity * -angle);
        }


    }

    public void PrintActivateMesssage()
    {
        if (velocity < 1)
        {
            velocity += push * Time.deltaTime;
            player.AddForce(Vector3.forward * velocity, ForceMode.VelocityChange);
        }
    }
    public void PrintDeactivateMesssage() { }
}