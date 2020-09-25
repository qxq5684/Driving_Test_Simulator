using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour
{
    [Tooltip("What is the name of the scene we want to load when clicking the button?")]
    public string SceneName;

    public void LoadGameScenePrimary()
    {
        SceneManager.UnloadScene("Test Scene");
    }
}