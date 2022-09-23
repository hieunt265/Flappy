using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 13f;

    enum Level {
        easy = 0,
        nomarl = 1,
        hard = 2,
        expert = 3
	}

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.isDeath)
            this.transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}
