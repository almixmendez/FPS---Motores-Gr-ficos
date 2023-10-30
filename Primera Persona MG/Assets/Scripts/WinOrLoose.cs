using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinOrLoose : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int requiredEnemies = 15;
    private int enemiesEliminated = 0;
    public TextMeshProUGUI victoryText;
    //nuevo
    public TextMeshProUGUI defeatText;
    private float timeRemaining;
    private bool gameEnded = false;

    private void Start()
    {
        //nuevo
        enemiesEliminated = 0;
        timeRemaining = 60.0f;
        UpdateCounterText();
        //nuevo
        victoryText.text = "";
        defeatText.text = "";
    }

    //nuevo
    private void Update()
    {
        if (!gameEnded)
        {
            timeRemaining -= Time.deltaTime;
            UpdateCounterText();

            if (timeRemaining <= 0 && enemiesEliminated < requiredEnemies)
            {
                EndGame(false);
            }
        }
    }

    public void EnemyEliminated()
    {
        enemiesEliminated++;
        UpdateCounterText();

        if (enemiesEliminated >= requiredEnemies /*nuevo*/ && timeRemaining > 0)
        {
            /*victoryText.text = "Victoria! (˃ ᵕ ˂ )";*/
            EndGame(true);
        }
    }

    void UpdateCounterText()
    {
        counterText.text = enemiesEliminated + "/" + requiredEnemies;
    }

    void EndGame(bool isVictory)
    {
        gameEnded = true;

        if (isVictory)
        {
            victoryText.text = "Victoria! (˃ ᵕ ˂ )";
        }
        else
        {
            defeatText.text = "Derrota (T__T)"; // Muestra el texto de derrota
        }
    }
}
