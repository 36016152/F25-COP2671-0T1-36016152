using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Bounds camBounds;
    public GameObject player;
    private Camera cam;
    private Vector3 targetPos;
    public GameObject border;
    float minX;
    float maxX;
    float minY;
    float maxY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var bounds = border.GetComponent<Collider2D>().bounds;
        cam = Camera.main;

        var height = cam.orthographicSize;
        var width = height * cam.aspect;

        minX = bounds.min.x;
        maxX = bounds.max.x;

        minY = bounds.min.y;
        maxY = bounds.max.y;
        Debug.Log(minX + maxX + minY + maxY);

        camBounds = new Bounds();
        camBounds.SetMinMax(
            new Vector3(minX, minY, 0.0f),
            new Vector3(maxX, maxY, 0.0f)
            );
    }

    private Vector3 GetCameraBounds()
    {
        return new Vector3(
            Mathf.Clamp(targetPos.x, camBounds.min.x, camBounds.max.x),
            Mathf.Clamp(targetPos.y, camBounds.min.y, camBounds.max.y),
            transform.position.z);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        targetPos = player.transform.position;

        targetPos = GetCameraBounds();
        transform.position = targetPos;


    }
}
