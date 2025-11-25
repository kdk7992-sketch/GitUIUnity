using TMPro;
using UnityEngine;


public class PopupBank : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject depositMenu;
    public GameObject withdrawMenu;
    public TMP_InputField depositInputField;
    public TMP_InputField withdrawInputField;
    public GameObject popupError;
    public UIManager uiManager;

    
    public void OnClickDepositMenu()
    {
        mainMenu.SetActive(false);
        depositMenu.SetActive(true);
        withdrawMenu.SetActive(false);
        depositInputField.text = "";
    }

    public void OnClickWithDrawMenu()
    {
        mainMenu.SetActive(false);
        withdrawMenu.SetActive(true);
        depositMenu.SetActive(false);
        withdrawInputField.text = "";
    }

    public void OnClickDepositBack()
    {
        mainMenu.SetActive(true);
        depositMenu.SetActive(false);
    }

    public void OnClickWithDrawBack()
    {
        mainMenu.SetActive(true);
        withdrawMenu.SetActive(false);
    }

    public void OnClickDeposit(int amount)
    {
        UserData data = GameManager.Instance.userdata;

        if (data.Cash < amount)
        {
            popupError.SetActive(true);
            return;
        }
        data.Cash -= amount;
        data.Balance += amount;

        uiManager.Refresh(data);
    }

    public void OnClickDepositInput()
    {
        if (string.IsNullOrEmpty(depositInputField.text)) return; 
        OnClickDeposit(int.Parse(depositInputField.text));
    }
    public void OnClickWithDraw(int amount)
    {
        UserData data = GameManager.Instance.userdata;

        if (data.Balance < amount)
        {
            popupError.SetActive(true);
            return;
        }
        data.Cash += amount;
        data.Balance -= amount;

        uiManager.Refresh(data);
    }
    public void OnClickWithDrawInput()
    {
        if (string.IsNullOrEmpty(withdrawInputField.text)) return; 
        OnClickWithDraw(int.Parse( withdrawInputField.text));
    }
    public void OnClickErrorOK()
    {
        popupError.SetActive(false);
    }
    
}
