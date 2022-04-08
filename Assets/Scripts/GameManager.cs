using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class GameManager : MonoBehaviour
{
    public Sprite bushDark;
    public Sprite bushLight;
    public Sprite bushUsal;
    public Sprite grassLight;
    public Sprite grassDark;
    public Sprite target;
    public Sprite plants;
    public Sprite stone;
    public Sprite treeGreen;
    public Sprite treeSmall;
    public Sprite treeOrange;
    public Sprite plantLight;
    public Sprite plantDark;

    public GameObject player;
    public GameObject box;

    private GameObject[] boxes;
    private GameObject[] cells;

    [SerializeField] Text textLevel;
    [SerializeField] Text textSteps;

    public Levels Levels;
    public AdmobManager admobManager;
    public GameObject menu;
    [SerializeField] GameObject pause;
    [SerializeField] GameObject music;
    [SerializeField] GameObject sound;

    [SerializeField] GameObject musicBtn;
    [SerializeField] GameObject soundBtn;
    [SerializeField] Sprite musicOff;
    [SerializeField] Sprite musicOn;
    [SerializeField] Sprite soundOff;
    [SerializeField] Sprite soundOn;

    public AudioSource soundGame;
    public AudioSource soundWin;
    public AudioSource soundClick;
    public AudioSource soundMove;
    public AudioSource soundBox;
    public AudioSource soundTarget;
    public AudioSource soundGameover;

    [SerializeField] GameObject hintsPanel;
    [SerializeField] Image hintImage;
    [SerializeField] Sprite[] hints;

    int startPosX = -4;
    int startPosY = 4;

    int rows = 9;
    int columns = 9;

    int numLevel = 0;
    int countSteps = 0;

    // If the touch is longer than MAX_SWIPE_TIME, we dont consider it a swipe
    public const float MAX_SWIPE_TIME = 0.5f;

    // Factor of the screen width that we consider a swipe
    // 0.17 works well for portrait mode 16:9 phone
    public const float MIN_SWIPE_DISTANCE = 0.07f;

    public static bool swipedRight = false;
    public static bool swipedLeft = false;
    public static bool swipedUp = false;
    public static bool swipedDown = false;


    public bool debugWithArrowKeys = true;

    Vector2 startPos;
    float startTime;

    private void Awake()
    {
        Appodeal.setLogLevel(Appodeal.LogLevel.Verbose);
        Appodeal.initialize("18118a312386040e13c03ebb805e11ae37027d8929ae4b60", Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO, true);
        Appodeal.setTesting(false);
    }

    void Start()
    {
        //IronSource.Agent.init("13b3382d1", IronSourceAdUnits.REWARDED_VIDEO, IronSourceAdUnits.INTERSTITIAL, IronSourceAdUnits.OFFERWALL, IronSourceAdUnits.BANNER);
        //IronSource.Agent.loadInterstitial();
        //IronSourceEvents.onRewardedVideoAdClosedEvent += RewardedVideoAdClosedEvent;

        if (PlayerPrefs.GetInt("firstStart") != 1)
        {
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("firstStart", 1);
        }

        numLevel = PlayerPrefs.GetInt("level");
        ParseLevel(Levels.number[numLevel]);
    }
    void ParseLevel(string[,] level)
    {
        textLevel.text = "Level: " + (numLevel + 1).ToString();

        countSteps = 0;
        textSteps.text = countSteps.ToString();

        int countBox = 0;
        int countCell = 0;

        boxes = new GameObject[LengthCountBoxes(level)];
        cells = new GameObject[81];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                cells[countCell] = new GameObject($"Field {startPosX + j}:{startPosY - i}");
                SpriteRenderer renderer = cells[countCell].AddComponent<SpriteRenderer>();

                //Player
                if (level[i, j] == "p0")
                {
                    player = Instantiate(player, new Vector3(startPosX + j, startPosY - i, -0.01f), Quaternion.identity);
                }

                //Grass
                if (level[i, j] == "gl" || level[i, j] == "b0" || level[i, j] == "p0")
                {
                    renderer.sprite = grassLight;
                }
                if (level[i, j] == "gd" || level[i, j] == "b0" || level[i, j] == "p0")
                {
                    renderer.sprite = grassDark;
                }

                //Box
                if (level[i, j] == "b0" || level[i, j] == "tb")
                {
                    boxes[countBox] = Instantiate(box, new Vector3(startPosX + j, startPosY - i, 4f - i * 1f), Quaternion.identity);
                    countBox++;
                }

                //Target
                if (level[i, j] == "t0" || level[i, j] == "tb")
                {
                    renderer.sprite = target;
                }

                cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f + i * 1f);

                //Bush
                if (level[i, j] == "bl")
                {
                    renderer.sprite = bushLight;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }
                if (level[i, j] == "bd")
                {
                    renderer.sprite = bushDark;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }
                if (level[i, j] == "bu")
                {
                    renderer.sprite = bushUsal;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }
                if (level[i, j] == "pl")
                {
                    renderer.sprite = plantLight;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }
                if (level[i, j] == "pd")
                {
                    renderer.sprite = plantDark;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }
                if (level[i, j] == "s0")
                {
                    renderer.sprite = stone;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 4f - i * 1f);
                }


                //Tree
                if (level[i, j] == "tg")
                {
                    renderer.sprite = treeGreen;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 0f - i * 0.1f);
                }
                if (level[i, j] == "ts")
                {
                    renderer.sprite = treeSmall;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 0f - i * 0.1f);
                }
                if (level[i, j] == "to")
                {
                    renderer.sprite = treeOrange;

                    cells[countCell].transform.position = new Vector3(startPosX + j, startPosY - i, 0f - i * 0.1f);
                }
                countCell++;
            }
        }
    }

    void Update()
    {
        Swipe();


        if (Input.GetKeyUp("up"))
        {
            Move(0, 1);
        }
        if (Input.GetKeyUp("down"))
        {
            Move(0, -1);
        };
        if (Input.GetKeyUp("left"))
        {
            Move(-1, 0);
        };
        if (Input.GetKeyUp("right"))
        {
            Move(1, 0);
        };
    }

    public void Swipe()
    {
        swipedRight = false;
        swipedLeft = false;
        swipedUp = false;
        swipedDown = false;

        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                startPos = new Vector2(t.position.x / (float)Screen.width, t.position.y / (float)Screen.width);
                startTime = Time.time;
            }
            if (t.phase == TouchPhase.Ended)
            {
                if (Time.time - startTime > MAX_SWIPE_TIME) // press too long
                    return;

                Vector2 endPos = new Vector2(t.position.x / (float)Screen.width, t.position.y / (float)Screen.width);

                Vector2 swipe = new Vector2(endPos.x - startPos.x, endPos.y - startPos.y);

                if (swipe.magnitude < MIN_SWIPE_DISTANCE) // Too short swipe
                    return;

                if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
                { // Horizontal swipe
                    if (swipe.x > 0)
                    {
                        swipedRight = true;
                        Move(1, 0);
                    }
                    else
                    {
                        swipedLeft = true;
                        Move(-1, 0);
                    }
                }
                else
                { // Vertical swipe
                    if (swipe.y > 0)
                    {
                        swipedUp = true;
                        Move(0, 1);
                    }
                    else
                    {
                        swipedDown = true;
                        Move(0, -1);
                    }
                }
            }
        }

        if (debugWithArrowKeys)
        {
            swipedDown = swipedDown || Input.GetKeyDown(KeyCode.DownArrow);
            swipedUp = swipedUp || Input.GetKeyDown(KeyCode.UpArrow);
            swipedRight = swipedRight || Input.GetKeyDown(KeyCode.RightArrow);
            swipedLeft = swipedLeft || Input.GetKeyDown(KeyCode.LeftArrow);
        }
    }

    void Move(int x, int y)
    {
        countSteps++;
        textSteps.text = (countSteps).ToString();

        soundMove.Play();

        int nextPosX = -((int)player.transform.position.y + y - 4);
        int nextPosY = (int)player.transform.position.x + x + 4;
        int nextPosZ = (int)player.transform.position.y + y - 4 + 4;

        if (
            Levels.number[numLevel][nextPosX, nextPosY] == "bl"
            | Levels.number[numLevel][nextPosX, nextPosY] == "bd"
            | Levels.number[numLevel][nextPosX, nextPosY] == "bu"
            | Levels.number[numLevel][nextPosX, nextPosY] == "pl"
            | Levels.number[numLevel][nextPosX, nextPosY] == "pd"
            | Levels.number[numLevel][nextPosX, nextPosY] == "s0"
            )
        {
            return;
        }

        for (int i = 0; i < LengthCountBoxes(Levels.number[numLevel]); i++)
        {
            if (boxes[i].transform.position.x == player.transform.position.x + x && boxes[i].transform.position.y == player.transform.position.y + y)
            {
                int nextBoxPosX = -((int)player.transform.position.y + y + y - 4);
                int nextBoxPosY = (int)player.transform.position.x + x + x + 4;
                int nextBoxPosZ = (int)player.transform.position.y + y + y - 4 + 4;

                if (
                    Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "bl"
                    | Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "bd"
                    | Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "bu"
                    | Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "pl"
                    | Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "pd"
                    | Levels.number[numLevel][nextBoxPosX, nextBoxPosY] == "s0"
                    )
                {
                    return;
                }

                for (int j = 0; j < LengthCountBoxes(Levels.number[numLevel]); j++)
                {
                    int nextTwoBoxPosX = (int)player.transform.position.x + x + x;
                    int nextTwoBoxPosY = (int)player.transform.position.y + y + y;

                    if (boxes[j].transform.position.x == nextTwoBoxPosX && boxes[j].transform.position.y == nextTwoBoxPosY)
                    {
                        return;
                    }
                }

                soundBox.Play();
                boxes[i].transform.position = new Vector3(player.transform.position.x + x + x, player.transform.position.y + y + y, nextBoxPosZ - 0.5f);
                player.transform.position = new Vector3(player.transform.position.x + x, player.transform.position.y + y, nextPosZ - 0.5f);

                CheckWin();
                return;
            }
        }

        player.transform.position = new Vector3(player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z);
    }

    bool CheckWin()
    {
        bool isWin = false;
        int countFinishedCheckpoint = 0;

        for (int i = 0; i < LengthCountBoxes(Levels.number[numLevel]); i++)
        {
            if (Levels.number[numLevel][-((int)boxes[i].transform.position.y - 4), (int)boxes[i].transform.position.x + 4] == "t0")
            {
                soundTarget.Play();
                countFinishedCheckpoint++;
            }
            if (Levels.number[numLevel][-((int)boxes[i].transform.position.y - 4), (int)boxes[i].transform.position.x + 4] == "tb")
            {
                soundTarget.Play();
                countFinishedCheckpoint++;
            }
        }

        if (countFinishedCheckpoint == LengthCountBoxes(Levels.number[numLevel]))
        {
            isWin = true;
            print("Win");

            DestroyLevel();

            if ((numLevel + 1) == Levels.number.Length)
            {
                Restart();
                return isWin;
            }

            soundWin.Play();
            numLevel++;
            PlayerPrefs.SetInt("level", numLevel);
            ParseLevel(Levels.number[numLevel]);
        }

        return isWin;
    }

    int LengthCountBoxes(string[,] level)
    {
        int lengthCountBoxes = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (level[i, j] == "b0" || level[i, j] == "tb")
                {
                    lengthCountBoxes++;
                }
            }
        }

        return lengthCountBoxes;
    }

    void DestroyLevel()
    {
        for (int i = 0; i < LengthCountBoxes(Levels.number[numLevel]); i++)
        {
            Destroy(boxes[i]);
        }
        Destroy(player);
        for (int i = 0; i < cells.Length; i++)
        {
            Destroy(cells[i]);
        }
    }

    public void Replay()
    {
        //IronSource.Agent.showInterstitial();
        menu.SetActive(false);
        DestroyLevel();
        numLevel = PlayerPrefs.GetInt("level");
        ParseLevel(Levels.number[numLevel]);
        menu.SetActive(false);
    }

    public void Restart()
    {
        DestroyLevel();
        numLevel = 0;
        PlayerPrefs.SetInt("level", 0);
        ParseLevel(Levels.number[numLevel]);
        menu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Pause()
    {
        pause.SetActive(!pause.activeSelf);
    }

    public void Music()
    {
        music.SetActive(!music.activeSelf);

        if (music.activeSelf)
        {
            musicBtn.GetComponent<Image>().sprite = musicOn;
        }
        else
        {
            musicBtn.GetComponent<Image>().sprite = musicOff;
        }
    }

    public void Sound()
    {
        sound.SetActive(!sound.activeSelf);

        if (sound.activeSelf)
        {
            soundBtn.GetComponent<Image>().sprite = soundOn;
        }
        else
        {
            soundBtn.GetComponent<Image>().sprite = soundOff;
        }
    }

    public void Gameover()
    {
        soundGameover.Play();
        Replay();
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
        //admobManager.ShowInterstitial();
    }

    public void Open()
    {
        pause.SetActive(false);
        menu.SetActive(true);
    }

    public void Close()
    {
        menu.SetActive(false);
    }

    public void ClickSound()
    {
        soundClick.Play();
    }

    public void RewardVideo()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }

        ShowHints();
        //admobManager.ShowRewarded(numLevel);
        //IronSource.Agent.showRewardedVideo();
    }

    void ShowHints()
    {
        hintsPanel.SetActive(true);
        hintImage.GetComponent<Image>().sprite = hints[numLevel];
    }

    void RewardedVideoAdClosedEvent()
    {
        //CompleteMethod(true);
    }
}