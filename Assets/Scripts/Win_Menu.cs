using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win_Menu : MonoBehaviour
{
    public Text scoreText;

    public AudioSource sound1;
    public AudioSource click;

    private int score;

    // Initialize win menu and display score
    void Start()
    {
        gameObject.SetActive(true);
        sound1.Play();

        score = Coin_Saver.score;
        scoreText.text = score.ToString();

    }

    // Load main game on retry
    public void Retry()
    {
        SceneManager.LoadScene("MainGame");
        click.Play();

    }

    // Load menu on menu
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        click.Play();

    }
}
