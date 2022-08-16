using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    //class
    public int myNumber=3;

    public int myOtherNumber=5;

    public string myFavNums;

    public float myFloatNumber = 3.14f;


    // Start is called before the first frame update
    void Start()
    {
        int myFancyNum = (myFavNums + myFloatNumber) + 5 / 2;

        myFavNums = myNumber.ToString() + " " + myOtherNumber.ToString();

        Debug.Log(myFavNums);
        Debug.Log(myNumber);
        Debug.LogFormat("My numer: {0} My Other Number: {1}.", myNumber, myOtherNumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
