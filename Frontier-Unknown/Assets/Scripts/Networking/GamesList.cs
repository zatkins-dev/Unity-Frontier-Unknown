using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GamesList : MonoBehaviour
{
    [Tooltip("List of map list item prefabs.")]
    public List<GameObject> mapList;
    [Tooltip("TextMeshPro Text object to display selected map.")]
    public TMP_Text currentItemText;
    [HideInInspector]
    public string currentMap;

    private RoomManager _manager;

    Dictionary<string, MapListItem> maps = new Dictionary<string, MapListItem>();

    void Start() 
    {
        maps[""] = null;
        foreach (var map in mapList) {
            var mapObj = Instantiate(map, transform);

            Debug.Log(mapObj);
            var listItem = mapObj.GetComponent<MapListItem>();
            if (listItem != null) {
                listItem.GamesList = this;
                maps[listItem.PrettyName] = listItem;
            }
        }
        currentItemText.text = "Select a map!";
    }

    void Update()
    {
        if (_manager == null)
        {
            _manager = NetworkManager.singleton as RoomManager;
        }
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ButtonStartHost() {
        if (maps[currentMap] != null && _manager != null) {
            _manager.networkAddress = "localhost";
            _manager.GameplayScene = maps[currentMap].LinkedScene;
            _manager.MapName = maps[currentMap].PrettyName;
            _manager.StartHost();
        }
    }

    public void SetMap(string mapName) {
        if (mapName == currentMap) 
            return;
        if (maps.ContainsKey(mapName)) {
            if (maps[currentMap] != null) 
                maps[currentMap].button.colors = UIConfig.Instance.buttonColors.Background;
            currentMap = mapName;
            currentItemText.text = "Map: " + currentMap;
            maps[currentMap].button.colors = UIConfig.Instance.buttonColors.Light;
        }
    }

}
