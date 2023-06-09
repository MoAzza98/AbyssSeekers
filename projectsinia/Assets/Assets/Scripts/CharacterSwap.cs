using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{
    private PlayerMovement pmove;
    private MovementInfoScriptableObject newchar;
    // Start is called before the first frame update
    void Start()
    {
        pmove = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CharacterSwapper();
        }
    }

    //Sets the players movement data to a new scriptable object in the resources folder (must be in /resources)
    void CharacterSwapper()
    {
        newchar = Resources.Load<MovementInfoScriptableObject>("Characters/Yura");
        pmove.Data = newchar;
    }
}
