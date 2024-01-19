using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Canvas_Manager : MonoBehaviour
{
    [SerializeField ]
    private Text Main_Tet;
    [SerializeField ]
    private Button congn_Button;
    [SerializeField ]
    private Button Quit_Button;

    public AnimationCurve da_curve;


    private void Start()
    {
        congn_Button.onClick.AddListener(() => { SceneManager.LoadScene("Building"); }); 
        Quit_Button.onClick.AddListener(() =>{ Application.Quit(); });
    }


    public  void set_Mina(string str)
    {
        Main_Tet.text = str; 
    }


    private void OnEnable()
    {
        StartCoroutine(Scale_date(transform, da_curve, 1));
    }

    IEnumerator Scale_date(Transform transform,AnimationCurve animation,float speed)
    {
        float time = 0;
        while(transform.localScale.x <1)
        {
            transform.localScale=Vector3.one*animation.Evaluate(time);
            time += Time.deltaTime * speed;
            yield return null;  
        }
    }

}
