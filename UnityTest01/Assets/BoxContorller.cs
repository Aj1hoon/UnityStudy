using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxContorller : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        print("�浹�߻� Enter!")
    }

    public void OnCollisionExit(Collision collision)
    {
        print("�浹�߻� Exit!")
    }

}
