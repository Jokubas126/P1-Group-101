using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody player;
    public Transform playermove;

    public float push = 30f;
    public float velocity = 0.3f;
    //float tempvelocity;
    public float stop = 0.35f;
    public float constantspeed = 0.3f;

    public float turn = 30f;
    public float angle = 2f;

    bool active = false;
	// Update is called once per frame
	void Update () {
        angle = 2f;
        if (active == true)
        {
            //for (float i = angle; i <= turn; i++)
           // {
                playermove.Rotate(0, turn * Time.deltaTime, 0);
            //}
            active = !active;
        }


        
        if (velocity >= 0.3)
        {
            velocity = velocity - (stop * Time.deltaTime);
            playermove.Translate(0, 0, velocity);
        }
        else playermove.Translate(0, 0, constantspeed * Time.deltaTime);

    }

    public void PrintActivateMesssage()
    {   
        if (velocity < 1)
        {
            velocity += push * Time.deltaTime;
            player.AddForce(0, 0, velocity);
            active = !active;
        }
    }
    public void PrintDeactivateMesssage(){}
}
