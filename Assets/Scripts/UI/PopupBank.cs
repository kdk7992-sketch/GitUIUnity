using UnityEngine;


public class PopupBank : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject depositMenu;
    public GameObject withdrawMenu; 

    public void OnClickDepositMenu()
    {
        mainMenu.SetActive(false);
        depositMenu.SetActive(true);
        withdrawMenu.SetActive(false);
    }

    public void OnClickWithDrawMenu()
    {
        mainMenu.SetActive(false);
        withdrawMenu.SetActive(true);
        depositMenu.SetActive(false);
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
}
