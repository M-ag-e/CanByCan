using UnityEditor;
using UnityEngine;

public class InteractionManager_CanCrusher : MonoBehaviour
{
    public GameObject changedObject;

    public Interaction_Lever LeverInteract;

    public Transform startPos;
    public Transform endPos;

    [HideInInspector]
    public float progress;

    private void Start()
    {
        changedObject.transform.position = startPos.position;
    }

    private void Update()
    {
        progress = (LeverInteract.progressDone);

        changedObject.transform.position = new Vector3(
            changedObject.transform.position.x, 
            Mathf.Lerp(startPos.position.y, endPos.position.y, progress), 
            changedObject.transform.position.z);
    }
    public void ChangeOnLever()
    {

    }

    public void ChangeOnButton()
    {

    }
    
    //private void OnGUI()
    //{
    //    Handles.Label(new Vector3(20, 20), $"{progress}");
    //}
}
