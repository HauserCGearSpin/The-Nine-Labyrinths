using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    [SerializeField] private float timeOfDay;
    [SerializeField] private float cycleSpeed;
    [SerializeField] private GameObject celestialBodies;
    [SerializeField] private GameObject moonTexture;
    [SerializeField] private GameObject player;

    private void Start()
    {
        moonTexture.SetActive(true);
        moonTexture.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 1000);
        moonTexture.transform.localScale = new Vector3(15, 15, 15);
    }

    private void Update()
    {
        celestialBodies.transform.Rotate(cycleSpeed * Time.deltaTime, 0f, 0f, Space.Self);
        celestialBodies.transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);    
    }
}
