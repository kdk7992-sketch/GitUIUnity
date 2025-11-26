using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public UserData userdata;

    public string savePath;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); 
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        savePath = Application.persistentDataPath + "/userdata.json";
        LoadUserdata();
    }
    public void MakeUserData()
    {
        userdata = new UserData("KDK", 900000, 30000);
    }

    public void SaveUserData()
    {
        if (userdata == null)
            return;

        string json = JsonUtility.ToJson(userdata, true);
        File.WriteAllText(savePath, json);
        Debug.Log("JSON 저장 완료: " + savePath);
    }

    public void LoadUserdata()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            userdata = JsonUtility.FromJson<UserData>(json);
            Debug.Log("JSON 로드 완료");
        }
        else
        {
            MakeUserData();
            SaveUserData(); 
        }
    }
}
