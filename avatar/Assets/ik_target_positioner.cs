using UnityEngine;

public class ik_target_positioner : MonoBehaviour
{
    public Transform rightIKTarget;
    public Transform rightIKSource;

    public Transform leftIKTarget;
    public Transform leftIKSource;

    public Transform headIKTarget;
    public Transform headIKSource;

    public Vector3 headSourcePositionOffset = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightIKTarget.position = rightIKSource.position;
        rightIKTarget.rotation = rightIKSource.rotation;

        leftIKTarget.position = leftIKSource.position;
        leftIKTarget.rotation = leftIKSource.rotation;

        headIKTarget.position = headIKSource.position;
        headIKTarget.rotation = headIKSource.rotation;

        Vector3 position = transform.position;
        position.y = headIKSource.transform.position.y + headSourcePositionOffset.y;
        //transform.position = position;  
    }
}
