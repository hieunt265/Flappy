using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScore : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "enemy")
			GameManager.Instance.PlusScore(5);
	}
}
