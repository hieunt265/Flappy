using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] Enemy = null;
    
    public float timeGenerate = 2f;

    float oldTimeGenerate = 0;

    public float timeToDestroy = 5f;
    bool isStart = false;

    public List<GameObject> listEnemy;

    enum Level
    {
        easy = 0,
        nomarl = 1,
        hard = 2,
        expert = 3
    }

    // Update is called once per frame
    void Update()
    {
        if(isStart && !GameManager.Instance.isDeath && Time.time - oldTimeGenerate >= timeGenerate)
            StartCoroutine(GenerateEnemy());
        
    }

    void Start()
    {
        Debug.Log("Starting " + Time.time);
    }
    
    public void Init ()
    {
        oldTimeGenerate = Time.time;
        isStart = true;
    }

    IEnumerator GenerateEnemy()
    {
        Debug.Log("Done " + Time.time);
        oldTimeGenerate = Time.time;
        Vector3 positon = this.transform.position + new Vector3(0,Random.Range(6, -6), 0);
        GameObject enemyNew =  Instantiate(Enemy[Random.Range(0, 1)], positon, Quaternion.identity);
        listEnemy.Add(enemyNew);
        Destroy(enemyNew, timeToDestroy);

        yield return null;
    }



}
