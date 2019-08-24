using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MatchToSceneViewCam : MonoBehaviour
{
    [Tooltip("Target transform to match SceneView camera's position and rotation")]
    public Transform tragetTransform;
}

#if UNITY_EDITOR
[CustomEditor(typeof(MatchToSceneViewCam))]
public class MatchToSceneViewCamEditor : Editor
{
    MatchToSceneViewCam source;

    private void OnEnable()
    {
        source = (MatchToSceneViewCam)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Match To Scene View Cam"))
        {
            source.tragetTransform.position = SceneView.GetAllSceneCameras()[0].transform.position;
            source.tragetTransform.rotation = SceneView.GetAllSceneCameras()[0].transform.rotation;
        }
    }
}
#endif
