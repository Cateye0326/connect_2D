using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenController : MonoBehaviour
{

    [SerializeField]
    [Tooltip("Circle")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("-6,4")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("6,4")]
    private Transform rangeB;
    [SerializeField]
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if (time > 0.7f)
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);

            _ = Instantiate(createPrefab, new Vector2(x, y), createPrefab.transform.rotation);

            time = 0f;
        }
    }
}
