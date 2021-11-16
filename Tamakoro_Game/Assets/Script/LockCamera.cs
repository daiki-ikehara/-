using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")]
public class LockCamera : CinemachineExtension
{
    [Tooltip("カメラのY.Z座標を固定する値")]
    public float m_YPosition = 1.274454f; //固定するY座標
    //public float m_ZPosition = -0.9311206f;　//固定するZ座標



    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            //pos.z = m_ZPosition;
            state.RawPosition = pos;
        }
    }

}