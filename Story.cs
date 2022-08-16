using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StoryLocation kingsPalace = new StoryLocation();

        kingsPalace.name = "King's Palace";
        kingsPalace.difficultylevel = 2;
        kingsPalace.cardinalDirection = "North";

        kingsPalace.LocationDetails();

        StoryLocation heroHideout = new StoryLocation("Hero's Hideout");

        heroHideout.cardinalDirection = "South";
        heroHideout.LocationDetail




        List<string> myList = new List<string>();

        StoryCharacter villain = new StoryCharacter();

        StoryCharacter hero = new StoryCharacter();

        Debug.LogFormat("Character's name; {0}", villain.name);
        villain.name = "Aardvark";
        Debug.LogFormat("Character's name; {0}", villain.name);

        villain.favoriteFood = "pizza";

        Debug.LogFormat("Character's name; {0}", hero.name);
        hero.name = "tim";
        Debug.LogFormat("Character's name; {0}", hero.name);

        StoryCharacter sideKick = new StoryCharacter("Tumeric");
        Debug.LogFormat("Character's name; {0}", hero.name);

        sideKick.Greeting();

        sideKick.DisplayStats();
        int exp = sideKick.GetExp();

        Debug.Log("New Exp: " + sideKick.GainExp(10));
        sideKick.DisplayStats();
        sideKick.GainExp();
        sideKick.DisplayStats();



        LootItem rareGoblet = new LootItem("Super ultra rare", 1000, true);

        if (rareGoblet.unique)
        {
            Debug.LogFormat("Congrats, the {0} is unique!", rareGoblet.unique)
        }


        StoryBoss coolBoss = new StoryBoss("Bowsker");
        coolBoss.SayGreeting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
