using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour {
    private EnemyScript enemy;
	// Use this for initialization
	void Start () {
        enemy = GetComponentInParent<EnemyScript>();

	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemy.PlayerDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enemy.PlayerDetected = false;
    }

}
