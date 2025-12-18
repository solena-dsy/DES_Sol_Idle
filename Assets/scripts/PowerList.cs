using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerList : MonoBehaviour
{
    public int powerLevel;
    public float powerPrice;
    public TextMeshProUGUI priceText;
    public GoldManager01 monGoldManagerReference;

    public void Update()
    {
        priceText.text = $"Power up {powerLevel} for {powerPrice}";
    }

    public void ChangePower()
    {
        if (monGoldManagerReference.GoldAmount >= powerPrice)
        {

            monGoldManagerReference.GoldAmount -= Mathf.CeilToInt(powerPrice);
            monGoldManagerReference.ChangePower(powerLevel);
            powerPrice = powerPrice*2;
        }
    }
    
}
