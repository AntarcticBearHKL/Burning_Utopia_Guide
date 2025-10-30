using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePosition : MonoBehaviour
{
    public Vector2 position1;
    public Vector2 position2;
    public Vector2 position3;
    public Vector2 position4;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void HandleDrop(GameObject dancer, Vector2 currentPos, Vector2 originalPos)
    {
        Vector2[] positions = { position1, position2, position3, position4 };

        // 找到currentPos最接近的固定位置
        Vector2 closestPos = positions[0];
        float minDist = Vector2.Distance(currentPos, positions[0]);
        for (int i = 1; i < positions.Length; i++)
        {
            float dist = Vector2.Distance(currentPos, positions[i]);
            if (dist < minDist)
            {
                minDist = dist;
                closestPos = positions[i];
            }
        }

        // 如果距离超过3，返回原位置
        if (minDist > 3)
        {
            dancer.transform.position = originalPos;
            return;
        }

        // 检查closestPos是否是原位置
        if (Vector2.Distance(originalPos, closestPos) < 0.1f) // 使用小阈值判断是否是同一位置
        {
            dancer.transform.position = originalPos;
            return;
        }

        // 使用Physics2D找到在closestPos位置的对象（假设dancers有Collider2D）
        GameObject objAtPos = null;
        Collider2D[] colliders = Physics2D.OverlapPointAll(closestPos);
        foreach (Collider2D col in colliders)
        {
            if (col.gameObject != dancer && col.gameObject.GetComponent<dragableDancer>() != null)
            {
                objAtPos = col.gameObject;
                break;
            }
        }

        if (objAtPos == null)
        {
            // 位置为空，直接移动dancer到该位置
            dancer.transform.position = closestPos;
        }
        else
        {
            // 交换位置
            objAtPos.transform.position = originalPos;
            dancer.transform.position = closestPos;
        }
    }
}
