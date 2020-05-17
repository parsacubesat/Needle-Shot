using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public static float speedMultiplier = 1f;
    public static int level = 1;
    public static int numOfPins;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Debug.Log("Level: " + level);
        Debug.Log("Number of Pins: " + numOfPins);
        if (PinCondition.increase == 0)
        {
            GameWin();
        }


    }
    public void GameWin()
    {
        level++;
        numOfPins = PinCondition.increase;
        //SceneManager.LoadScene(0);

    }

    public void GameLoss()
    {
        SceneManager.LoadScene(0);
    }
}