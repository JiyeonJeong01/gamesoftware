using TMPro;
using UnityEngine;

public class ModalManager : MonoBehaviour
{
    // �̱���
    private static ModalManager _instance;
    public static ModalManager Instance 
    {
        get
        {
            return _instance;
        }
    }

    System.Action _OnClickConfrimButton; // Ȯ�� ��ư Ŭ�� �� �޼���
    System.Action _OnClickCancelButton; // ��� ��ư Ŭ�� �� �޼��� 

    public GameObject _modal;
    public TMP_Text _modalMsg;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
            return;
        }
        else
        {
            _instance = this;
            _modal.SetActive(false);
        }
    }

    public void Open(string msg, System.Action OnClickConfirmButton, System.Action OnClickCancelButton)
    {
        _modal.SetActive(true);
        _modalMsg.text = msg;
        _OnClickConfrimButton = OnClickConfirmButton;
        _OnClickCancelButton = OnClickCancelButton;
    }

    public void Close()
    {
        _modal.SetActive(false);
    }

    // ��ư�� On Click()�� �Ҵ� 
    public void OnClickConfirmButton()
    {
        if (_OnClickConfrimButton != null)
        {
            _OnClickConfrimButton();
        }
    }

    public void OnClickCancelButton()
    {
        if (_OnClickCancelButton != null)
        {
            _OnClickCancelButton();
        }
        Close();
    }

}