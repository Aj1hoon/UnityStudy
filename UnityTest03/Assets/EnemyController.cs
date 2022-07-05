using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody enemyRd;
    private float moveRate;
    private float timeAfterMove;


    // Start is called before the first frame update
    void Start()
    {
        enemyRd = GetComponent<Rigidbody>();

        moveRate = Random.Range(-1.0f, 1.0f);
        
        //startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        enemyRd.AddForce(Random.Range(-400.0f, 400.0f), 0, 0);
    }
}
