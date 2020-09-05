using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    public GameObject sahne1;
    public GameObject sahne2;
    void Start()
    {
        score = 0;
        scoreTxt.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        scoreTxt.text = score.ToString();
    }
    public void RePlayGame()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        sahne1.SetActive(false);
        sahne2.SetActive(true);
    }
}
