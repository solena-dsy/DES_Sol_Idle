using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
public class GoldManager01 : MonoBehaviour
{

    public int GoldAmount;
    public int power;
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI PowerText;
    public Button RandomButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
    }

    public void ChangeGold()
    {
        GoldAmount += power;
        GoldText.text = GoldAmount.ToString("00");

    }

    public void GoldperSeconds()
    {
        GoldAmount += 1;
    }

    public void ChangePower(int powerToAdd)
    {
        power += powerToAdd;
    }



    public void RandomChange()
    {
        if (power >= 30)
        {
            RandomButton.interactable = true;
            GoldAmount += Random.Range(0, 50);
        }

        else
        {
            RandomButton.interactable = false;
        }
    }


// Update is called once per frame
void Update()
    {
        GoldText.text = GoldAmount.ToString("00");
        PowerText.text = power.ToString("00");
    }
}
