using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Camera;
    public GameObject menu;

    public GameObject OptionButton;

    public GameObject UIButton;
    public GameObject UIExitButton;

    public GameObject SoundButton;
    public GameObject SoundOption;
    public GameObject QuitButton;

    public GameObject ExitButton;
    public GameObject ExitPanel;
    public GameObject ExitAnswerButton;
    public GameObject NoExitAnswerButton;

    public GameObject CollectButton;

    public GameObject GachaButton;

    public GameObject BuildingButton;

    public GameObject BuildingMenu;

    public GameObject CollectionMenu;

    //public TMP_Text VillageLevel;

    public bool act = false;
    public bool TouchOptionMenu = false;
    public bool UITouch = false;
    public bool PallteEffect = false;
    // Start is called before the first frame update
    void Start()//게임 시작시에는 메뉴UI를 비활성화한다
    {
        menu.SetActive(false);

        UIButton.SetActive(false);
        UIExitButton.SetActive(false);

        SoundButton.SetActive(false);
        SoundOption.SetActive(false);

        ExitButton.SetActive(false);

        CollectButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (act==false)//카메라가 해당 위치까지 이동했다면 메뉴UI를 활성화시킨다
        {
            //menu.SetActive(true);
            StartCoroutine(SummonMenu());
            act = true;
        }
        else
        {
            StopCoroutine(SummonMenu());//지점 도착시 메뉴 활성화하는 코루틴 종료
        }

        if (Input.GetKey(KeyCode.Escape))//모바일에서 뒤로가기 누를 시 종료창 활성화
        {
            ExitPanel.SetActive(true);
        }
    }
    IEnumerator SummonMenu()//menu를 활성화시키는 코루틴
    {
        menu.SetActive(true);
        //VillageLevel.text = "Village Level : 10";
        yield return null;
    }

    public void OnOptionClick()//옵션을 누르면 설정 버튼이 나오도록 구현
    {
        if (TouchOptionMenu == false)
        {
            TouchOptionMenu = true;
            UIButton.SetActive(true);
            SoundButton.SetActive(true);
            ExitButton.SetActive(true);
            CollectButton.SetActive(true);
        }
        else
        {
            TouchOptionMenu = false;
            UIButton.SetActive(false);
            SoundButton.SetActive(false);
            ExitButton.SetActive(false);
            CollectButton.SetActive(false);
        }
    }

    public void OnUIClick()//UI메뉴버튼 클릭 시 menu 비활성화
    {
        if (PallteEffect == false)
        {
            UIButton.SetActive(false);
            SoundButton.SetActive(false);
            ExitButton.SetActive(false);
            CollectButton.SetActive(false);
            GachaButton.SetActive(false);
            BuildingButton.SetActive(false);
            OptionButton.SetActive(false);

            UIExitButton.SetActive(true);
        }
    }
    public void OnUIExitButtonClick()//버튼 클릭 시 메뉴 활성화
    {
        if (PallteEffect == false)
        {
            TouchOptionMenu = false;

            GachaButton.SetActive(true);
            BuildingButton.SetActive(true);
            OptionButton.SetActive(true);

            UIExitButton.SetActive(false);
        }
    }
    public void OnSoundClick()//Sound버튼 클릭 시 소리 조절하는 메뉴창 활성화
    {
        if(PallteEffect == false)
        {
            PallteEffect = true;

            SoundOption.SetActive(true);
        }
    }
    public void OnQuitClick()//X버튼 클릭 시 활성화한 페널 비활성화
    {
        PallteEffect = false;

        SoundOption.SetActive(false);
        ExitPanel.SetActive(false);
    }
    public void OnBackgroundSoundCancelClick()//버튼 클릭 시 배경음 음소거
    {

    }
    public void OnEffectSoundCancelClick()//버튼 클릭 시 효과음 음소거
    {

    }
    public void OnExitButtonClick()//종료버튼 클릭 시 종료 페널 활성화
    {
        if (PallteEffect == false)
        {
            PallteEffect = true;

            ExitPanel.SetActive(true);
        }
    }
    public void OnExitAnswerButtonClick()//종료 확인 버튼 클릭 시 게임 종료
    {
        PallteEffect = false;

        DataManager.Data.DataSave();
        Application.Quit();
    }
    public void OnNoExitAnswerButtonClick()//종료 취소 버튼 클릭 시 종료 페널 비활성화
    {
        PallteEffect = true;

        ExitPanel.SetActive(false);
    }
    public void OnCollectButtonClick()//도감버튼 클릭 시 도감창 활성화
    {
        if (PallteEffect == false)
        {
            CollectionMenu.SetActive(true);
        }
    }
    public void OnGachaButtonClick()
    {
        if(PallteEffect == false)
        {
            SceneManager.LoadScene("GachaScene");
        }
    }
    public void OnBuildingButtonClick()//건물 생성 버튼 클릭 시 건물 생성 창으로 이동
    {
        if (PallteEffect == false)
        {
            BuildingMenu.SetActive(true);
        }
        
    }
    public void OnBuildingExit()
    {
        BuildingMenu.SetActive(false);
    }
    public void OnCollectionExit()
    {
        CollectionMenu.SetActive(false);
    }
}
