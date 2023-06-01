using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GachaUI : MonoBehaviour
{
    public int GachaInfo;
    public static bool GetCollect1 = false;
    public static bool GetCollect2 = false;
    public static bool GetCollect3 = false;
    public static bool GetCollect4 = false;
    public static bool GetCollect5 = false;
    public static bool GetCollect6 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //뽑기 시에 얻은 동물을 활성화
        if(GachaInfo == 1)
        {
            GetCollect1 = true;
        }
        else if(GachaInfo == 2)
        {
            GetCollect2 = true;
        }
        else if (GachaInfo == 3)
        {
            GetCollect3 = true;
        }
        else if (GachaInfo == 4)
        {
            GetCollect4 = true;
        }
        else if (GachaInfo == 5)
        {
            GetCollect5 = true;
        }
        else if (GachaInfo == 6)
        {
            GetCollect6 = true;
        }


        if (Input.GetKey(KeyCode.Escape))//모바일에서 뒤로가기 누를 시 마을 화면으로 변경
        {
            SceneManager.LoadScene("StartScene");
        }
    }
    public void OnReturnButtonClick()//되돌아가기 버튼 클릭 시 마을 화면으로 변경
    {
        SceneManager.LoadScene("StartScene");
    }
    public void OnGachaButtonClick()//뽑기 버튼 클릭 시 랜덤 값 생성
    {
        GachaInfo=Random.Range(1, 7);
        Debug.Log(GachaInfo);
    }
}
