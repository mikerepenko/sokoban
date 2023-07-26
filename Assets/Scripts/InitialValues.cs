using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialValues : MonoBehaviour
{
    void Awake()
    {
        if (!!PlayerPrefs.HasKey("isInit"))
        {
            PlayerPrefs.SetInt("health", 5);
            PlayerPrefs.SetInt("money", 10);
            PlayerPrefs.SetString("stars", "2,3,1"); // 1-3 - level stars
            PlayerPrefs.SetInt("level", 4);

            PlayerPrefs.SetInt("isInit", 1);
        }
    }
}
