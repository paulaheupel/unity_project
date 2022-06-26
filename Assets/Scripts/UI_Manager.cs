using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Text _cointext;

     [SerializeField]
    private Text _lifetext;

    // Update coin text
    public void UpdateCoin(int coins)
    {
        _cointext.text = " " + coins + " / 5";
    }

    // Update lives text
    public void UpdateLife(int life)
    {
        _lifetext.text = " "+ life;
    }
}
