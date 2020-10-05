using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParchmentPaper : MonoBehaviour
{
    public Text location;
    public Text bodyText;
    public GameObject option1Button;
    public Text option1Text;
    public GameObject option2Button;
    public Text option2Text;
    public GameObject option3Button;
    public Text option3Text;

    private  GameData gameDataComponent;
    private int id;
    private int option1LeadsTo;
    private int option2LeadsTo;
    private int option3LeadsTo;
    private int numberOfRestarts = -1;
    private List<object> gameData = new List<object>();
    private FadeInAndOut fadeInAndOut;

    SoundManager sm;

    void Awake()
    {
        sm = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Start()
    {
        gameDataComponent = GetComponent<GameData>();
        fadeInAndOut = GameObject.Find("Fader").GetComponent<FadeInAndOut>();
        GetGameData(0);
    }

    private void GetGameData(int idNumber)
    {
        if (IsWin(idNumber))
        {
            fadeInAndOut.DoFade(3);
            return;
        }

        //Debug.Log("idNumber = " + idNumber);
        gameData = gameDataComponent.GetLocationData(idNumber);

        //for (int i = 0; i < gameData.Count; i++)
        //{
        //    Debug.Log(gameData[i]);
        //}

        numberOfRestarts++;
        if (idNumber == 0)
        {
            sm.PlaySound(sm.sounds[0]);
        }

        id = (int)gameData[0];
        location.text = (string)gameData[1];
        bodyText.text = (string)gameData[2];
        option1Text.text = (string)gameData[3];
        option1LeadsTo = (int)gameData[4];
        option2Text.text = (string)gameData[5];
        option2LeadsTo = (int)gameData[6];
        option3Text.text = (string)gameData[7];
        option3LeadsTo = (int)gameData[8];

        SetButtons();
    }

    private void SetButtons()
    {
        if (option1LeadsTo == -1)
        {
            option1Button.SetActive(false);
        } else
        {
            option1Button.SetActive(true);
        }

        if (option2LeadsTo == -1)
        {
            option2Button.SetActive(false);
        }
        else
        {
            option2Button.SetActive(true);
        }

        if (option3LeadsTo == -1)
        {
            option3Button.SetActive(false);
        }
        else
        {
            option3Button.SetActive(true);
        }
    }

    private bool IsWin(int idNumber)
    {
        return idNumber == 60;
    } 

    public void LeftButton()
    {
        if (option1LeadsTo == -1)
        {
            return;
        }
        
        GetGameData(option1LeadsTo);
    }

    public void MiddleButton()
    {
        if (option2LeadsTo == -1)
        {
            return;
        }

        GetGameData(option2LeadsTo);
    }

    public void RightButton()
    {
        if (option3LeadsTo == -1)
        {
            return;
        }

         GetGameData(option3LeadsTo);
    }
}
