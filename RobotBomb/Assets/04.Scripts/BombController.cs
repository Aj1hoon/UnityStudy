using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HpImage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject hp = GameObject.Find("HpController");

        if (collision.gameObject.tag == "ROBOT")
        {
            hp.GetComponent<HpController>().HpControl();
        }

        Destroy(gameObject);
    }
}
