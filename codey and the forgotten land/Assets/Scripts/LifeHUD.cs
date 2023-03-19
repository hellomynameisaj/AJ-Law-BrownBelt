using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;
    public GameObject HealthBar;

    // Start is called before the first frame update
    public void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer()
    {
        Debug.Log("yeow im going to die ");
        lives -= 1;
        hearts[lives].SetActive(false);
        if(lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }

    public void HealPlayer()
    {
        Debug.Log("i would have rathered stayed dead if i were you");
        if (lives < 3)
        {
            hearts[lives].SetActive(true);
            lives += 1;
        }
    }
}
