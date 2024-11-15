using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerInfoController : MonoBehaviour
{
    PlayerInfo playerInfo;
    TMP_InputField nicknameInputField;
    
    string nickname;

    private void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
        nicknameInputField = GetComponentInChildren<TMP_InputField>();
    }


    public void ModifyButtonClick()
    {
        // ���� ó�� �ʿ�
        playerInfo.Nickname = nicknameInputField.text;
        playerInfo.CharacterID = 0;
        Test_PrintPlayerInfo();
    }

    void Test_PrintPlayerInfo()
    {
        Debug.Log(playerInfo.Nickname);
        Debug.Log(playerInfo.CharacterID);
    }


}
