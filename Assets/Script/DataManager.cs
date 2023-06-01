using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataManager : MonoBehaviour
{
    private PlayerData playerData;
    private static DataManager _saveData;
    public string GameDataFileName = "save.json";

    public static DataManager Data
    {
        get
        {
            if (!_saveData)
            {
                _saveData = FindObjectOfType(typeof(DataManager)) as DataManager;
            }
            return _saveData;
        }
    }
    private void Awake()
    {
        if(_saveData == null)
        {
            _saveData = this;
        }
        else if(_saveData != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public PlayerData SaveData
    {
        get
        {
            if(playerData == null)
            {
            }
            return playerData;
        }
    }
    public void LoadData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;

        if (File.Exists(filePath))
        {
            string FromJsonData = File.ReadAllText(filePath);
            playerData = JsonUtility.FromJson<PlayerData>(FromJsonData);
        }
        else
        {
            playerData = new PlayerData();
        }
    }

    public void DataSave()
    {
        string ToJsonData = JsonUtility.ToJson(SaveData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, ToJsonData);
    }
}

[System.Serializable]
public class PlayerData
{
    public int money=100;
    public int energy=100;
}
