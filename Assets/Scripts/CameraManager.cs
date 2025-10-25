using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // 主角 Z 值范围
    private const float MIN_PLAYER_Z = -22f;
    private const float MAX_PLAYER_Z = 2f;
    
    // 摄像头角度范围
    private const float MAX_PITCH_ANGLE = 28f;
    private const float MIN_PITCH_ANGLE = 14f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        // 获取主角的 Z 值
        float playerZ = player.transform.position.z;

        // 将 Z 值范围映射到摄像头角度范围
        // Z: -22 -> 30度, Z: 2 -> 13度
        float normalizedZ = Mathf.Clamp01((playerZ - MIN_PLAYER_Z) / (MAX_PLAYER_Z - MIN_PLAYER_Z));
        float pitchAngle = Mathf.Lerp(MAX_PITCH_ANGLE, MIN_PITCH_ANGLE, normalizedZ);

        // 应用摄像头俯仰角
        ApplyPitchAngle(pitchAngle);
    }

    private void ApplyPitchAngle(float pitchAngle)
    {
        // 获取摄像头当前的欧拉角
        Vector3 rotation = transform.eulerAngles;
        
        // 设置 X 轴旋转（俯仰角）
        rotation.x = pitchAngle;
        
        // 应用新的旋转
        transform.eulerAngles = rotation;
    }
}
