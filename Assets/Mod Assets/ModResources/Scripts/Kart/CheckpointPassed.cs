using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class CheckpointPassed : TargetObject


{
    [Header("PickupObject")]

    [Tooltip("New Gameobject (a VFX for example) to spawn when you trigger this PickupObject")]
    public GameObject spawnPrefabOnPickup;


    

    [Tooltip("Destroy the spawned spawnPrefabOnPickup gameobject after this delay time. Time is in seconds.")]
    public float destroySpawnPrefabDelay = 10;

    [Tooltip("Destroy this gameobject after collectDuration seconds")]
    public float collectDuration = 0f;

    [Tooltip("This is responsible for taking you to the menu screen after destroying object")]
    public string questionScene = "Test Scene";


    void Start()
    {
        Register();
    }

    void OnCollectOfCheckpoint()
    {

        Assert.IsTrue(this.CollectSound);
        if (CollectSound)
        {
            AudioUtility.CreateSFX(CollectSound, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        }


        Assert.IsTrue(this.spawnPrefabOnPickup);
        if (spawnPrefabOnPickup)
        {
            var vfx = Instantiate(spawnPrefabOnPickup, CollectVFXSpawnPoint.position, Quaternion.identity);
            Destroy(vfx, destroySpawnPrefabDelay);
        }


        Objective.OnUnregisterPickup(this);


        Assert.IsTrue(TimeGained > -1);
        TimeManager.OnAdjustTime(TimeGained);


              
        Destroy(gameObject, collectDuration);

        Assert.IsTrue(SceneManager.GetSceneByName(questionScene).IsValid());
        SceneManager.LoadScene(questionScene, LoadSceneMode.Additive);
    }

    void OnTriggerEnter(Collider other)
    {
        if ((layerMask.value & 1 << other.gameObject.layer) > 0 && other.gameObject.CompareTag("Player"))
        {
            OnCollectOfCheckpoint();
        }
    }
}
