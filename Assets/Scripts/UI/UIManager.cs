using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI cashText;
    public TextMeshProUGUI balanceText;
    void Start()
    { 
        GameManager.Instance.MakeUserData();
        Refresh(GameManager.Instance.UserData);  
    }
    public void Refresh(UserData userdata)
    {
        nameText.text = userdata.Name;
        cashText.text = "Cash " + string.Format("{0:N0}", userdata.Cash);
        balanceText.text = "Balance - " + string.Format("{0:N0}", userdata.Balance);
    }
}
