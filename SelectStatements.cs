using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        bool isTrue = true;
        bool isFalse = false;

        Debug.Log(isTrue);
        Debug.Log(isFalse);

        Debug.Log(!isTrue);//exclamation point is opposite
        Debug.Log(!isFalse);

        Debug.Log(isTrue == isFalse); //comparison ==       setting value to variable=

        string dog = "dude";
        string guy = "dude";

        Debug.Log(dog == guy);
        Debug.Log(dog != guy);

        Debug.Log(5 == 5);


        //IF ELSE STATEMENTS
        int numberOfInches = 34;
        if (numberOfInches >= 36)
        {

            Debug.Log("At least a yard");

        }
        else
        {
            Debug.Log("not a yard");

        }

        bool isCool = true;
        if (isCool)
        {
            Debug.Log("Very cool");
        }

        if (!isCool)
        {
            Debug.Log("not cool at all");
        }

        //Else if

        string fruitColor = "red";
        if(fruitColor=="red")
        {
         Debug.Log("strawberry");
        }
        else if (fruitColor=="blue")
        {
            Debug.Log("blueberry");
        }
        else
        {
            Debug.Log("not a color");

        }


        
        //switch statements


    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
