using UnityEditor;
using UnityEngine;

public class Interaction_Lever : MonoBehaviour
{
    public GameObject handle;

    public Transform startPos;
    public Transform endPos;

    public float progressDone;


    private Transform dragging = null;


    private void Start()
    {
        handle.transform.position = startPos.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                dragging = hit.transform;
            }
        } 
        
        else if (Input.GetMouseButtonUp(0))
        {
            dragging = null;
        }

        if (dragging != null)
        {
            dragging.position = new Vector3(dragging.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -1);
            if (dragging.position.y >= startPos.position.y)
            {
                dragging.position = startPos.position;
            }
            if(dragging.position.y <= endPos.position.y)
            {
                dragging.position = endPos.position;
            }
        }
        leverProgress();

    }

    public void leverProgress()
    {
        progressDone = (Vector3.Distance(handle.transform.position, startPos.position)-1) / 4;

    }

    private void OnGUI()
    {
    }
}
