using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject VictoryScreen;
    public GameObject LoseScreen;
    public GameObject GameUi;
    public GameObject player;
    private bool ended;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            ended = true;
            GameUi.SetActive(false);
            VictoryScreen.SetActive(true);
            AudioManager.instance.PlaySfx("Victory");
            AudioManager.instance.musicSource.Stop();
        }
    }

    private void Update()
    {
        if((player.GetComponent<Timer>().Remainingtime == 0)&&(ended==false))
        {
            Time.timeScale = 0;
            GameUi.SetActive(false);
            LoseScreen.SetActive(true);
            AudioManager.instance.PlaySfx("Lose");
            AudioManager.instance.musicSource.Stop();
            ended = true;
        }
    }
}

