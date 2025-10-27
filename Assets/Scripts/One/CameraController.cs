using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float yValue1 = -16.3f;
    public float yValue2 = -0.4f;
    public float yValue3 = 16.3f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetPositionY1()
    {
        transform.position = new Vector3(transform.position.x, yValue1, transform.position.z);
    }

    public void SetPositionY2()
    {
        transform.position = new Vector3(transform.position.x, yValue2, transform.position.z);
    }

    public void SetPositionY3()
    {
        transform.position = new Vector3(transform.position.x, yValue3, transform.position.z);
    }

    public IEnumerator MoveBetweenYValues(float speedToY3, float speedToY1)
    {
        while (Mathf.Abs(transform.position.y - yValue3) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, yValue3, transform.position.z), speedToY3 * Time.deltaTime);
            yield return null;
        }

        while (Mathf.Abs(transform.position.y - yValue1) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, yValue1, transform.position.z), speedToY1 * Time.deltaTime);
            yield return null;
        }
    }
}
