using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpCounter : MonoBehaviour
{
    public RectTransform displayCounter;

    public float dropHieght = -25;
    private float startHieght;
    public float riseDelay = 2;
    public float riseSpeed = 2;

    private bool startLerp;
    private bool delayed;
    private float endTime;
    private float anchedPosX;

    private float t;

    // Start is called before the first frame update
    void Start()
    {
        startHieght = displayCounter.anchoredPosition.y;
        anchedPosX = displayCounter.anchoredPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (startLerp)
		{
            if (delayed)
			{
                t = 0;
                delayed = false;
                endTime = Time.time + riseDelay;
                displayCounter.anchoredPosition = new Vector2(anchedPosX, dropHieght);

            }

            if (Time.time >= endTime)
			{
                t += Time.deltaTime * riseSpeed;
                displayCounter.anchoredPosition = new Vector2(anchedPosX, Mathf.Lerp(dropHieght, startHieght, t));
			}
		}
    }

    public void IncreaseCounter()
	{
        displayCounter.GetComponent<TextMeshProUGUI>().text = PickUp.counter.ToString();
        startLerp = true;
        delayed = true;
	}

}
