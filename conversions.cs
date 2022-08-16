/*********************************************************
* file name: conversions.cs
* programmer name: Matthew Schroeder
* date created: 9/11/19
* date of last revision: 9/13/19
* details of the revision: none
* short description:  Calculating and converting miles into kilometers
* and fahrenheit to celsius. Displaying name and results at the end. 
**********************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversions : MonoBehaviour
{
    //class 
    public double num1;
    public double num2;
    public double num3;
    public double num4;
    public string firstName;
    public string lastName;
   

    // Start is called before the first frame update
    void Start()
    {
        //setting values to variables
        double fahrenheit1 = num1;
        double fahrenheit2 = num2;
        double fahrenheit3 = num3;
        double fahrenheit4 = num4;
        double miles1 = num1;
        double miles2 = num2;
        double miles3 = num3;
        double miles4 = num4;

        //calculating celsius
        double celsius1 = (fahrenheit1 - 32f) * 5f / 9f;
        double celsius2 = (fahrenheit2 - 32f) * 5f / 9f;
        double celsius3 = (fahrenheit3 - 32f) * 5f / 9f;
        double celsius4 = (fahrenheit4 - 32f) * 5f / 9f;

        //calculating kilometers
        double kilometers1 = miles1 * 1.6f;
        double kilometers2 = miles2 * 1.6f;
        double kilometers3 = miles3 * 1.6f;
        double kilometers4 = miles4 * 1.6f;

        //displaying results
        Debug.LogFormat("{0} degrees F = {1} degrees C", fahrenheit1, celsius1);
        Debug.LogFormat("{0} degrees F = {1} degrees C", fahrenheit2, celsius2);
        Debug.LogFormat("{0} degrees F = {1} degrees C", fahrenheit3, celsius3);
        Debug.LogFormat("{0} degrees F = {1} degrees C", fahrenheit4, celsius4);

        Debug.LogFormat("{0} miles = {1} kilometers", miles1, kilometers1);
        Debug.LogFormat("{0} miles = {1} kilometers", miles2, kilometers2);
        Debug.LogFormat("{0} miles = {1} kilometers", miles3, kilometers3);
        Debug.LogFormat("{0} miles = {1} kilometers", miles4, kilometers4);

        Debug.LogFormat("You are amazing {0} {1}!", firstName,lastName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
