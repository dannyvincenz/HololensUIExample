using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatManager : MonoBehaviour
{
    public float stat1;
    public Image bar1;
    public TMP_Text statText1;
    public float max1;

    public float stat2;
    public Image bar2;
    public TMP_Text statText2;
    public float max2;

    public float stat3;
    public Image bar3;
    public TMP_Text statText3;
    public float max3;

    public float stat4;
    public Image bar4;
    public TMP_Text statText4;
    public float max4;

    public float stat5;
    public Image bar5;
    public TMP_Text statText5;
    public float max5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        statText1.text = stat1.ToString();
        statText2.text = stat2.ToString();
        statText3.text = stat3.ToString();
        statText4.text = stat4.ToString();
        statText5.text = stat5.ToString();

        bar1.transform.localScale = new Vector3((stat1 / max1), 1f, 1f);
        bar2.transform.localScale = new Vector3((stat2 / max2), 1f, 1f);
        bar3.transform.localScale = new Vector3((stat3 / max3), 1f, 1f);
        bar4.transform.localScale = new Vector3((stat4 / max4), 1f, 1f);
        bar5.transform.localScale = new Vector3((stat5 / max5), 1f, 1f);


    }
}
