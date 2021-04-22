using UnityEngine;
using UnityEngine.InputSystem;
public class SelectionManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    // Update is called once per frame

    private void Update()
    {
        //Vector3 targetRotation = camera.transform.eulerAngles;
        //var ray = camera.ScreenPointToRay(targetRotation);
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if(selectionRenderer != null )
            {
                selectionRenderer.material = highlightMaterial;
            }
        }
    }
}
