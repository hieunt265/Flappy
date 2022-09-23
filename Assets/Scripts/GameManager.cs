using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Button ButtonPlay = null;
    public GameObject gameOver = null;
    public Transform positionSpawn;
    public GameObject Player = null;
    public EnemyManager enemyManager;
    public Text scoreText = null;

    public bool isDeath = false;
    GameObject PlayerNew;
    int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        scoreText.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Destroy(PlayerNew);
        foreach (var enemy in enemyManager.listEnemy)
            Destroy(enemy);
        enemyManager.listEnemy.Clear();

        isDeath = false;
        PlayerNew = Instantiate(Player, positionSpawn);

        Score = 0;
        scoreText.text = Score.ToString();
    }

	public void GameOver (){
        gameOver.SetActive(true);
        ButtonPlay.gameObject.SetActive(true);
        isDeath = true;
        foreach (var enemy in enemyManager.listEnemy)
            Destroy(enemy, 1);
        PlayerNew.GetComponent<Collider>().isTrigger = false;
        Destroy(PlayerNew, 1);
    }

    public void PlusScore (int scorePlus)
    {
        Score += scorePlus;
        scoreText.text = Score.ToString();
    }
}
