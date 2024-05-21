using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneController : MonoBehaviour
{
    private PlayableDirector director;
    
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        
    }
}
