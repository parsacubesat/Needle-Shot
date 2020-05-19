using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text LevelText;
    public Text NeedlesText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelText.text = "Level: " + EndGameManager.level;
        NeedlesText.text = "Pins: " + EndGameManager.pins;
    }


}
