using Mirror;
using TMPro;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MapListItem : MonoBehaviour
{
    [Scene]
    public string LinkedScene;
    public string PrettyName = "";

    public GamesList GamesList;
    public Button button;
    public TMP_Text text;
    // Update is called once per frame
    public void Start() {
        button = GetComponent<Button>();
        text = GetComponentInChildren<TMP_Text>();
        button.onClick.AddListener(OnClick);
        if (PrettyName == "") {
            var filename = Path.GetFileName(LinkedScene).Replace(".unity", "");
            PrettyName = Regex.Replace(filename,"([a-z](?=[A-Z]|[0-9])|[A-Z](?=[A-Z][a-z]|[0-9])|[0-9](?=[^0-9]))","$1 ").Trim();
        }
        text.text = PrettyName;
        button.colors = UIConfig.Instance.buttonColors.Background;
        text.color = UIConfig.Instance.colorPalette.SecondaryText;
        text.font = UIConfig.Instance.bodyFont;
    }
    void OnClick()
    {
        GamesList.SetMap(PrettyName);
    }
}
