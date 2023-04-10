using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
    
{

    // Start is called before the first frame update
    public GameObject MenuUi;
    public Text text;
    public Game _game;


    private void Awake()
    {
        Resume();
    }

    public void Pause()
    {
        //меню игры
        MenuUi.SetActive(true);
        Time.timeScale = 0f;
        var objs1 = GameObject.FindGameObjectsWithTag("apple");
        for (int i = 0; i < objs1.Length; i++)
            Destroy(objs1[i]);
        var objs2 = GameObject.FindGameObjectsWithTag("bomb");
        for (int i = 0; i < objs2.Length; i++)
            Destroy(objs2[i]);
        var objs = GameObject.FindGameObjectsWithTag("watermelon");
        for (int i = 0; i < objs.Length; i++)
            Destroy(objs[i]);
        text.text = $"{_game.Score}";
    }


    public void Resume()
    {
        //запуск уровня
        MenuUi.SetActive(false);
        Time.timeScale = 1f;

    }
}
