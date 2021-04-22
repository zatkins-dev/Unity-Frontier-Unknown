using Mirror;
using TMPro;
using UnityEngine;

public class SceneScript : NetworkBehaviour
{
    public TMP_Text canvasStatusText;
    public TMP_Text canvasAmmoLText;
    public TMP_Text canvasAmmoRText;
    public TMP_Text uiHealthText;
    public TMP_Text uiScoreText;
    public PlayerScript playerScript;
    public SceneReference sceneReference;
    public HUDController hud;

    [SyncVar(hook = nameof(OnStatusTextChanged))]
    public string statusText;

    void OnStatusTextChanged(string _Old, string _New)
    {
        //called from sync var hook, to update info on screen for all players
        canvasStatusText.text = statusText;
    }

    public void UIAmmoR(int _value)
    {
        canvasAmmoRText.text = _value.ToString();
    }
    public void UIAmmoL(int _value)
    {
        canvasAmmoLText.text = _value.ToString();
    }

    public void UIHealth(int _value) {
        uiHealthText.SetText(_value.ToString());
    }

    public void UIHealthColor(Color _value) {
        uiHealthText.color = _value;
    }

    public void UIScore(int _value) {
        uiScoreText.SetText(_value.ToString());
    }

    public void ButtonSendMessage()
    {
        if (playerScript != null)  
        {
            playerScript.CmdSendPlayerMessage();
        }
    }

    public void ButtonDisconnect() 
    {
        if (isServer) {
            NetworkManager.singleton.StopHost();
        } else {
            NetworkManager.singleton.StopClient();
        }
    }
}
