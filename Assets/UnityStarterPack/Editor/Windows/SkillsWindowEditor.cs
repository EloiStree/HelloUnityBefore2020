using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class SkillsWindowEditor : EditorWindow
{
    public string _modulesName ="C# for beginner";
    public bool _unknowSkills = true;
    public bool _masteredSkills = false;
    public float _pourcentKnowledge = 0.1f;

    // Add menu named "My Window" to the Window menu
    [MenuItem("Starter Pack/ C#")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        SkillsWindowEditor window = (SkillsWindowEditor)EditorWindow.GetWindow(typeof(SkillsWindowEditor));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label(_modulesName, EditorStyles.largeLabel);
        _unknowSkills = EditorGUILayout.Foldout(_unknowSkills, "Unknow");
        if (_unknowSkills)
        {
            GUILayout.Label("Click on the skills you want to learn", EditorStyles.helpBox);
            int iSkillsToDisplay = 30;
            for (int i = 0; i < 30 && iSkillsToDisplay > 0; i++)
            {
                GUILayout.BeginHorizontal();
                for (int j = 0; j < 10 && iSkillsToDisplay>0; j++)
                {
                    if (GUILayout.Button("" + i))
                    {
                        SkillInfoWindowEditor window = (SkillInfoWindowEditor)EditorWindow.GetWindow(typeof(SkillInfoWindowEditor));
                        window.Show();
                    }
                    iSkillsToDisplay--;
                }
                GUILayout.EndHorizontal();


            }
            //myString = EditorGUILayout.TextField("Text Field", myString);
            //groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
            //myBool = EditorGUILayout.Toggle("Toggle", myBool);
            //myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
            //EditorGUILayout.EndToggleGroup();
        }
        else
        {

        }
        _masteredSkills = EditorGUILayout.Foldout(_masteredSkills, "Mastered");
        if (_masteredSkills)
        {
            GUILayout.Label("Find here the skills you said you mastered.", EditorStyles.helpBox);
            _pourcentKnowledge = EditorGUILayout.Slider(_pourcentKnowledge, 0f, 1f);
            //myString = EditorGUILayout.TextField("Text Field", myString);
            //groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
            //myBool = EditorGUILayout.Toggle("Toggle", myBool);
            //myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
            //EditorGUILayout.EndToggleGroup();
        }
        else
        {

        }


    }
}

