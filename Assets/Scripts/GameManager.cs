using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private UserData userdata;
    public UserData UserData { get { return userdata; } }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // �ߺ� ���
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void MakeUserData()
    {
        userdata = new UserData("KDK", 900000, 30000);
    }
}
