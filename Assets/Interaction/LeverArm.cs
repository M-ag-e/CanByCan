using UnityEngine;

public class LeverArm : MonoBehaviour
{
    public GameObject arm;
    public Transform root;
    public Transform target;

    private Vector3 midpoint;
    private Vector3 direction;
    private float distance;

    private void Update()
    {
        midpoint = (root.position + target.position) / 2f;
        direction = root.position - target.position;
        
        distance = direction.magnitude;

        arm.transform.position = midpoint;
        arm.transform.up = direction.normalized;
        arm.transform.localScale = new Vector3(arm.transform.localScale.x, distance, arm.transform.localScale.z);
    }
}
