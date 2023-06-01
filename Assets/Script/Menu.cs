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
    void Start()//���� ���۽ÿ��� �޴�UI�� ��Ȱ��ȭ�Ѵ�
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
        if (act==false)//ī�޶� �ش� ��ġ���� �̵��ߴٸ� �޴�UI�� Ȱ��ȭ��Ų��
        {
            //menu.SetActive(true);
            StartCoroutine(SummonMenu());
            act = true;
        }
        else
        {
            StopCoroutine(SummonMenu());//���� ������ �޴� Ȱ��ȭ�ϴ� �ڷ�ƾ ����
        }

        if (Input.GetKey(KeyCode.Escape))//����Ͽ��� �ڷΰ��� ���� �� ����â Ȱ��ȭ
        {
            ExitPanel.SetActive(true);
        }
    }
    IEnumerator SummonMenu()//menu�� Ȱ��ȭ��Ű�� �ڷ�ƾ
    {
        menu.SetActive(true);
        //VillageLevel.text = "Village Level : 10";
        yield return null;
    }

    public void OnOptionClick()//�ɼ��� ������ ���� ��ư�� �������� ����
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

    public void OnUIClick()//UI�޴���ư Ŭ�� �� menu ��Ȱ��ȭ
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
    public void OnUIExitButtonClick()//��ư Ŭ�� �� �޴� Ȱ��ȭ
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
    public void OnSoundClick()//Sound��ư Ŭ�� �� �Ҹ� �����ϴ� �޴�â Ȱ��ȭ
    {
        if(PallteEffect == false)
        {
            PallteEffect = true;

            SoundOption.SetActive(true);
        }
    }
    public void OnQuitClick()//X��ư Ŭ�� �� Ȱ��ȭ�� ��� ��Ȱ��ȭ
    {
        PallteEffect = false;

        SoundOption.SetActive(false);
        ExitPanel.SetActive(false);
    }
    public void OnBackgroundSoundCancelClick()//��ư Ŭ�� �� ����� ���Ұ�
    {

    }
    public void OnEffectSoundCancelClick()//��ư Ŭ�� �� ȿ���� ���Ұ�
    {

    }
    public void OnExitButtonClick()//�����ư Ŭ�� �� ���� ��� Ȱ��ȭ
    {
        if (PallteEffect == false)
        {
            PallteEffect = true;

            ExitPanel.SetActive(true);
        }
    }
    public void OnExitAnswerButtonClick()//���� Ȯ�� ��ư Ŭ�� �� ���� ����
    {
        PallteEffect = false;

        DataManager.Data.DataSave();
        Application.Quit();
    }
    public void OnNoExitAnswerButtonClick()//���� ��� ��ư Ŭ�� �� ���� ��� ��Ȱ��ȭ
    {
        PallteEffect = true;

        ExitPanel.SetActive(false);
    }
    public void OnCollectButtonClick()//������ư Ŭ�� �� ����â Ȱ��ȭ
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
    public void OnBuildingButtonClick()//�ǹ� ���� ��ư Ŭ�� �� �ǹ� ���� â���� �̵�
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
