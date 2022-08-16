using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class StoryCharacter 
{
    public string name;
    public int exp = 0;
    public string favoriteFood;


    private string greeting = "Hello there.";

    //constructor
    public StoryCharacter()
    {
        name = "no name assigned";

        //give 10exp
        exp += 10;
    }

    public StoryCharacter(string name)
    {
        this.name = name;

    }

    public StoryCharacter(string name)
    {
        this.name = name;

        
    }

    public StoryCharacter(string name, int exp)
    {
        this.name = name;
        this.exp = exp;
        GiveBonusExp();

    }
    public void GiveBonusExp()
    {
        exp += 10;

    }
  
    public void DisplayStats()
    {
        Debug.LogFormat("Character's name: {0}. XP: {1}", name, exp);
    }

    public void GainExp(int expGained = 1)
    {
        exp += expGained;
        return exp;
    }
    public int GetExp()
    {
        return exp;
    }
    public void SayGreeting()
    {
        Debug.LogFormat("{0} says:{1}", name, greeting);
    }
}


public struct Lootitem
{
    //constructor
    public string name;
    public int goldValue;
    public bool unique;

    public Lootitem(string name, int goldValue, bool unique)
    {
        this.name = name;
        this.goldValue = goldValue;
        this.unique = unique;
    }
}