using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garfield: MonoBehaviour
{
    public string dog = "odie";
    public string cat = "garfield";

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Dog: {0}, cat: {1}", dog, cat);

        dog = cat;
        cat = "Hobbes";

        Debug.LogFormat("Dog: {0}, cat: {1}", dog, cat);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
