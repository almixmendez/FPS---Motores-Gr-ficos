using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* public GameObject player;
    public GameObject Bot;
    private List<GameObject> enemyList;
    float timeLeft;

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        // Se reinicia el juego al terminar la ronda.
        if (timeLeft == 0)
        {
            StartGame();
        }
    }


    void StartGame()
    {
        // Se posiciona al jugador, se borran los bots de la lista y se los vuelve a crear.
        player.transform.position = new Vector3(0f, 0f, 0f);

        foreach (GameObject item in enemyList)
        {
            Destroy(item);
        }

        enemyList.Add(Instantiate(Bot, new Vector3(5, 1f, 3f), Quaternion.identity));
        enemyList.Add(Instantiate(Bot, new Vector3(3, 1f, 3f), Quaternion.identity));
        enemyList.Add(Instantiate(Bot, new Vector3(1, 1f, 3f), Quaternion.identity));
        StartCoroutine(StartChronometer(30));
    }

    // Temporizador de ronda.
    public IEnumerator StartChronometer(float chronoValue = 30)
    {
        timeLeft = chronoValue;
        while (timeLeft > 0)
        {
            Debug.Log("Restan " + timeLeft + " segundos.");
            yield return new WaitForSeconds(1.0f);
            timeLeft--;
        }
    }*/
}
