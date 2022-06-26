using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    [SerializeField]
    private UI_Manager _uiManager;
       
    public AudioSource sound;

    public Death_Menu deathMenu;

    private int coins;

    void Start()
    {
         // UPDATE Coins is ui manager
        _uiManager.UpdateCoin(coins);
    }


    //Collision of Player with coin and score 
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coins")
        {
            coins = coins+1;
            Coin_Saver.score += 1;
            _uiManager.UpdateCoin(coins);
            Col.gameObject.SetActive(false);
            sound.Play();
        }
    }

    //Transfer currrent coins to the death menu
    public void OnDeath()
    {
        deathMenu.ToggleEndMenu(coins);
    }
}
