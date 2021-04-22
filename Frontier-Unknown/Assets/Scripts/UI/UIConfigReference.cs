using UnityEngine;

public class UIConfigReference : MonoBehaviour
{
    [SerializeField] private UIConfig _uiConfig;
    // Start is called before the first frame update
    void Start()
    {
        _uiConfig = UIConfig.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
