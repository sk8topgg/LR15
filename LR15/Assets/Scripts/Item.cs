using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Item : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Перед мной припятствие!");
            }
        }
    }
}
