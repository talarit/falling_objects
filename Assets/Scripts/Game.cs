using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int Score;
    public int health;
    public Text text;
    public Image im1;
    public Image im2;
    public Image im3;
    public Image im4;
    public Image im5;
    public Count count;
    public Menu menu;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"{count.Score}";
        if (health == 4) im1.enabled = false;
        if (health == 3) im2.enabled = false;
        if (health == 2) im3.enabled = false;
        if (health == 1) im4.enabled = false;
        if (health == 0) im5.enabled = false;
        health = count.health;
        Score = count.Score;
        if (health<=0)
        {
            menu.Pause();
        }
    }
}
