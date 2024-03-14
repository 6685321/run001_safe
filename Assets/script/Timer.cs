using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI uiText;
    public int Duration;
    private int remainingDuration;
    // Start is called before the first frame update
    void Start()
    {
        Being(Duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Being(int second)
    {
        remainingDuration = second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            uiText.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    private void OnEnd()
    {
        SceneManager.LoadScene(3);
        print("end");
    }
}
