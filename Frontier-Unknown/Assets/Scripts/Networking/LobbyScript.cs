using Mirror;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LobbyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonBack()
    {
        var manager = NetworkManager.singleton as RoomManager;
        if (!manager)
        {
            SceneManager.LoadScene(1);
            return;
        }
        switch (manager.mode)
        {
            case NetworkManagerMode.Host:
                manager.StopHost();
                break;
            case NetworkManagerMode.ClientOnly:
                manager.StopClient();
                break;
            default:
                SceneManager.LoadScene(1);
                break;
        }
    }

    public void ButtonStart()
    {
        var roomManager = NetworkManager.singleton as RoomManager;
        roomManager.ServerChangeScene(roomManager.GameplayScene);
    }

    public HUDMap MinimapReference;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
