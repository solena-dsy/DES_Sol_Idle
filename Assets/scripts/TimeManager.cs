using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timeToWait;
    public GoldManager01 goldeneye;
    public int x;
    public bool shouldXtournerenboucletellaroue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            StartCoroutine(DoStuff());
            
    }

    public float tempsEcoule;
    // Update is called once per frame
    void Update()
    {

    }

    private float tempsDAttente;
    public bool pause;

    public void TooglePause()
    {
        pause = !pause;
    }

    public IEnumerator DoStuff()
    {
        while (true)
        {           
            while (pause || goldeneye.power >= 10)
            {
                yield return new WaitForEndOfFrame();
            }
            
            goldeneye.GoldperSeconds();
            yield return new WaitForSeconds(2f);
        }
    }

}