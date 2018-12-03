using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PackageController : MonoBehaviour {

    //System.Random rnd = new System.Random();
    public int numberOfPackages;
    public int packageToDrop;
    public List<int> packages = new List<int>();
    public bool quest;
    public bool dropPackage;
    public Vector3 distance;
    public int distanceFromTopToBottomMap;

    public int newstars;
    public int currentstars;

    public TimeSpan timer = TimeSpan.FromSeconds(1);
    public int timerInInt;
    public int setNewTimer;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void OnTriggerExit(Collider other)
    {
        numberOfPackages = 3;
        if (quest == true)
        { 
            packages.Add(numberOfPackages);
            for (int i = 0; i < timerInInt; i++)
            {
                setNewTimer = i;
            }

            timerInInt = setNewTimer;
        }
        else
        {
            Debug.Log(other.name + " Null.");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        distanceFromTopToBottomMap = 360;
        timerInInt = Convert.ToInt32(timer);
        packageToDrop = 1;
        int bonustime = 15;
        if (dropPackage == true && distanceFromTopToBottomMap <= timerInInt)
        {
            packages.Remove(packageToDrop);

            newstars = currentstars + 3;
        }
        else if (dropPackage == true && distanceFromTopToBottomMap <= (timerInInt + bonustime))
        {
            packages.Remove(packageToDrop);

            newstars = currentstars + 2;
        }
        else if (dropPackage == true && distanceFromTopToBottomMap > (timerInInt + bonustime))
        {

        }
        else
        {
            Debug.Log(other.name + " Null");
        }

        currentstars = newstars;
    }
}
