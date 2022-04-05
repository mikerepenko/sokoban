using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] GameObject[] clouds;

    float speed = 0.5f;

    void Update()
    {
        for (int i = 0; i < clouds.Length; i++)
        {
            if (clouds[i].transform.position.x > 6.5f)
            {
                clouds[i].transform.position = new Vector2(-6.5f, clouds[i].transform.position.y);
            }
            clouds[i].transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
