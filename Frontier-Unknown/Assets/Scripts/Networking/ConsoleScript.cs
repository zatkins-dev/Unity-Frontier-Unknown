using Mirror;
using UnityEngine;

public class ConsoleScript : NetworkBehaviour
{
    public ActionMode consoleMode;
    // public ActionScript consoleAction;
    public Camera consoleTargetCamera;

    [SyncVar]
    GameObject user = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate(GameObject requester) {
        var player = requester.GetComponent<PlayerScript>();
        if (user == null && player != null) {
            user = requester;
            consoleTargetCamera.enabled = true;
            Camera.main.transform.localPosition = new Vector3(0,3,7);
            Camera.main.transform.localRotation = Quaternion.Euler(Vector3.zero);
            player.SetActionMode(consoleMode);
        }
    }

    public void Deactivate() {
        if (user != null) {
            var player = user.GetComponent<PlayerScript>();
            player.SetActionMode(ActionMode.Default);
            consoleTargetCamera.enabled = false;
        }
        user = null;
    }

}
