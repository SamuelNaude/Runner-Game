
using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour
{

    public float currentAmount = 0f;
    public float maxAmount = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {

            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.2f;

            else

                Time.timeScale = 1.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }


        if (Time.timeScale == 0.03f)
        {

            currentAmount += Time.deltaTime;
        }

        if (currentAmount > maxAmount)
        {

            currentAmount = 0f;
            Time.timeScale = 1.0f;

        }

    }
}
