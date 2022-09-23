using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyPlay : MonoBehaviour
{

    Rigidbody rig = null;

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isDeath && (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)))
        {
            rig.AddForce(Vector3.up * speed);
		}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
            GameManager.Instance.GameOver();
    }
}
