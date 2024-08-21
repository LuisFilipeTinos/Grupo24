using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyController : MonoBehaviour
{
    RectTransform actualGameObject;
    [SerializeField] RectTransform target;

    [SerializeField] float initialXLimit;
    [SerializeField] float finalXLimit;
    [SerializeField] float initialYLimit;
    [SerializeField] float finalYLimit;

    // Start is called before the first frame update
    void Start()
    {
        actualGameObject = GetComponent<RectTransform>();

        var randX = Random.Range(initialXLimit, finalXLimit);
        var randY = Random.Range(initialYLimit, finalYLimit);
        target.anchoredPosition = new Vector2(randX, randY);
    }

    // Update is called once per frame
    void Update()
    {
        actualGameObject.anchoredPosition = Vector2.MoveTowards(actualGameObject.anchoredPosition, target.anchoredPosition, 1);

        if (actualGameObject.anchoredPosition == target.anchoredPosition)
        {
            var randX = Random.Range(initialXLimit, finalXLimit);
            var randY = Random.Range(initialYLimit, finalYLimit);
            target.anchoredPosition = new Vector2(randX, randY);
        }
    }
}
