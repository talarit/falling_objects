using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Count count;
    public void StartButton()
    {
        //кнопка заново
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        count.Score = 0;
        count.health = 5;
    }
}
