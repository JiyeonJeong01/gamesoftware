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

    System.Action _OnClickConfrimButton; // Ȯ�� ��ư Ŭ��
    System.Action _OnClickCancelButton; // ��� ��ư Ŭ��

    public GameObject _modal;
    public TMP_Text _modalMsg;

    private void Awake()
    {
        _modal.SetActive(false);
        DontDestroyOnLoad(this); // �� ��ȯ �� �ı����� �ʵ��� 
        _instance = this;
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
        Close();
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