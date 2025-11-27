using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GoldManager : MonoBehaviour
{

    public int GoldAmount;
    public int power;
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI PowerText;
    private int powerPrice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
        powerPrice = 10;
    }

    public void ChangeGold()
    {
        GoldAmount += power;
        GoldText.text = GoldAmount.ToString("00");

    }

    public void ChangePower ()
    {
        if (GoldAmount > powerPrice)
        {
            GoldAmount -= 10;
            GoldText.text = GoldAmount.ToString("00");
            PowerText.text = power.ToString("00");
            powerPrice = Mathf.RoundToInt(powerPrice * 1.2f);
            power += 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
