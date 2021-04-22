using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
	Documentation: https://mirror-networking.com/docs/Guides/NetworkBehaviour.html
	API Reference: https://mirror-networking.com/docs/api/Mirror.NetworkBehaviour.html
*/

public class RoomPlayerListItem : MonoBehaviour
{
    public Toggle ReadyToggle;
    public TMP_InputField LocalPlayerName;
    public TMP_Text PlayerName;
    public TMP_Dropdown ColorDropdown;
    public Transform DropdownListTransform;

    public void SetCallbacks(RoomPlayer player)
    {
        ReadyToggle.onValueChanged.AddListener(player.OnToggleChange);
        LocalPlayerName.onEndEdit.AddListener(player.OnNameChange);
        ColorDropdown.onValueChanged.AddListener(player.OnColorChange);
    }
}
