using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();
    }

    public void searchDialog()
    {
        if(collectibles[clue] is "film")
        {
            dialog = "I LOST MY RARE FOOTAGE OF THE FANTASTIC FOUR (1994)";
        }

        if (collectibles[clue] is "balloons")
        {
            dialog = "my son lost his balloons. help me find them and he will give you 19$";
        }

        if (collectibles[clue] is "life saver")
        {
            dialog = "SIR, MY FISH IS DROWNING AND HE NEEDS A LIFE SAVER.";
        }

        if (collectibles[clue] is "bull's eye")
        {
            dialog = "help me find my bull's eye token. i was practicing archery but i lost it.";
        }

        if (collectibles[clue] is "pipe")
        {
            dialog = "hehe pipe";
        }

        if (collectibles[clue] is "fish")
        {
            dialog = "my is fish lost";
        }

        if (collectibles[clue] is "key")
        {
            dialog = "my key to my son's room is gone. i need to get him to stop playing fortnite";
        }

        if (collectibles[clue] is "birdhouse")
        {
            dialog = "MY BIRD IS LOST! HELP ME FIND HIS FAVORITE BIRDHOUSE, QUICK!";
        }

        if (collectibles[clue] is "red airhorn")
        {
            dialog = "my wife kicked me out of my house 'cause of my red airhorn, find it";
        }

        if (collectibles[clue] is "magic hat")
        {
            dialog = "i am in debt. my magic hat is lost, so i can't continue my job as a magician.";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "thanks for the  " + collectibles[clue] + ". i've gotta go now.";
            end = true;
        }
        else
        {
            dialog = "i want my " + collectibles[clue] + " not whatever this is";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
