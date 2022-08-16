using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iterators : MonoBehaviour
{
    public List<int> myRandoms = new List<int>();
    public Dictionary<string, int> myRandomDictionary = new Dictionary<string, int>();
    public List<string> myRandomKeys = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //using a for loop to add values to a list and dictionary
        int randListMax = Random.Range(10, 100);

        for (int i = 0; i < randListMax; i++)
        {
            int thisRandomnum = (int)Random.Range(0f, 10f);

            //add the num to the list
            myRandoms.Add(thisRandomnum);

            //add the num and a key to the dictionary
            myRandomDictionary.Add
                ("Number" + i.ToString(), thisRandomNumber);
                
         }
            
        foreach (KeyValuePair<string,int>random in myRandomDictionary)
        {
            myRandomKeys.Add(randos.Key);
        }

        int randomIndex = (int)Random.Range(0, myRandomKeys.Count);
        string key = myRandomKeys[randomIndex];
        int value = myRandomDictionary[key];
        Debug.LogFormat("The value of {0} is {1}", key, value);






        int maxNum = 10;
        //increment
        for(int i=1; i <= maxNum; i++)
        {
            Debug.LogFormat("{0} mississippi", i);
        }
        // decrement
        int minNum;
        for (int i = 0; i < minNum; i--)
        {
            Debug.LogFormat("{0} mississippi", i);
        }
        List<string> theOfficeCharacters = new List<string>
        {
            "JIm",
            "Pam",
            "Michael",
            "Toby"

        };

        int characterCount = theOfficeCharacters.Count;
        for (int i = 0; i < length; i++)
        {
            Debug.LogFormat("This is {0}.", theOfficeCharacters(i));

        }

        int characterCounter = 0;
        foreach(string officeCharacter in theOfficeCharacters)
        {
            Debug.LogFormat("This is {0}.", theOfficeCharacters);

            //if else can be put in here
            //if the character name is____ then displays 
           
        }



        //getting all the even values in a list
        for (int i = 0; i < characterCount; i++)
        {
            if (i % 2 == 0)//add i+1 if you want to start at 1
            {
                Debug.LogFormat("{0} is Even", theOfficeCharacters[i]);
            }
            else
            {
                Debug.LogFormat("{0} is Odd", theOfficeCharacters[i]);
            }
        }
        



        //While loops
        int wNum = 0;
        int wMaxNum = 10;
        while(wNum<wMaxNum)
        {
            Debug.LogFormat("Our wNum is {0}", wNum);
            wNum++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
