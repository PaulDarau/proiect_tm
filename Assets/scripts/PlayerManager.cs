using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
public class PlayerManager:MonoBehaviour
{ public static bool gameOver;
    public GameObject gameOverPanel;

    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
     void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        numberOfCoins = 0;
        
    }
     void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        coinsText.text = "Coins: " + numberOfCoins;
    }
}
