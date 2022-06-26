using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death_Menu : MonoBehaviour
{
    public Text scoreText;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource click;

    // Hidden in the beginning
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Show Menu with current score
    public void ToggleEndMenu(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString();
        sound1.Play();
        sound2.Play();

    }

    // Load game on retry
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        click.Play();

    }

    // Load main menu on meun
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        click.Play();

    }
}
