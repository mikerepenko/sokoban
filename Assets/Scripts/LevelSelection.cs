using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] GameObject levelBtnPrefab;
    [SerializeField] Levels Levels;

    void Start()
    {
        float posX = -300f;
        float posY = 500f;

        string[] stars = PlayerPrefs.GetString("stars").Split(",");
        int level = PlayerPrefs.GetInt("level");
        

        for (int i = 1; i <=  Levels.number.Length; i++)
        {
            GameObject levelBtn = GameObject.Instantiate(levelBtnPrefab, new Vector3(0f, 0f, 0), Quaternion.identity);
            levelBtn.transform.SetParent(gameObject.transform);
            
            RectTransform rt = levelBtn.GetComponent<RectTransform>();
            rt.anchoredPosition.Set(10, 10);
            rt.localScale = new Vector3(1f, 1f, 1f);
            rt.localPosition = new Vector3(posX, posY, 0f);

            GameObject levelText = levelBtn.transform.GetChild(0).gameObject;
            levelText.GetComponent<Text>().text = i.ToString();

            GameObject starsObj = levelBtn.transform.GetChild(1).gameObject;
            GameObject s1 = starsObj.transform.GetChild(0).gameObject;
            GameObject s2 = starsObj.transform.GetChild(1).gameObject;
            GameObject s3 = starsObj.transform.GetChild(2).gameObject;

            if (stars.Length >= i) {
                if (int.Parse(stars[i - 1]) >= 1) {
                    s1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/star_active");
                }
               
                if (int.Parse(stars[i - 1]) >= 2) {
                    s2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/star_active");
                }

                if (int.Parse(stars[i - 1]) == 3) {
                    s3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/star_active");
                }
            }
            

            if (level >= i) {
                GameObject lockImage = levelBtn.transform.GetChild(2).gameObject;
                lockImage.SetActive(false);
            } else {
                levelBtn.GetComponent<Button>().interactable = false;
            }

            if (i % 3 == 0) {
                posX = -300f;
                posY = posY - 250f;
            } else {
                posX = posX + 300f;
            }
        }
    }
}