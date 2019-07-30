﻿using UnityEditor;

namespace Nebukam.ORCA.Ed
{

    [CustomEditor(typeof(ORCABehaviour))]
    [CanEditMultipleObjects]
    public class ORCABehaviourEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(ORCAEditorConstants.ORCABehaviorNotes, MessageType.Warning);
            base.OnInspectorGUI();
        }
    }

}