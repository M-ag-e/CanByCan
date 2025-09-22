using UnityEditor;
using UnityEngine;

public class Interaction_Can : MonoBehaviour
{
    private float progress;

    private float lowest;
    private RaycastHit2D hit;
    private void Update()
    {
        hit = Physics2D.Raycast(transform.position, Vector2.up);
        
    }
    private void OnGUI()
    {
        Handles.Label(new Vector3(20, 20), $"{hit.distance}");
    }

}
