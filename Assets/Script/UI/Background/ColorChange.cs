using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ColorChange:MonoBehaviour
{
    [SerializeField]
    private float daytime;
    [SerializeField]
    private float changetime;
    [SerializeField]
    private float DelayTime;

    private Sequence sequence;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        image = this.gameObject.GetComponent<Image>();

//        sequence.Append(DOTween.To(
//            () => image.color,                // 何を対象にするのか
//            color => image.color = color,    // 値の更新
//            Color.yellow,                    // 最終的な値
//            daytime/6.0f  
//            // アニメーション時間
//        ).SetDelay(daytime/4.0f));

//        sequence.Append(DOTween.To(
//            () => image.color,                // 何を対象にするのか
//            color => image.color = color,    // 値の更新
//            Color.white,                    // 最終的な値
//            daytime/6.0f                                // アニメーション時間
//        ).SetDelay(daytime/4.0f));
    }

    public void CC_Black()
    {
        sequence.Append(DOTween.To(
            () => image.color,                // 何を対象にするのか
            color => image.color = color,    // 値の更新
            Color.yellow,                    // 最終的な値
            changetime                                // アニメーション時間
        )); 
            sequence.Append(DOTween.To(
            () => image.color,                // 何を対象にするのか
            color => image.color = color,    // 値の更新
            Color.black,                    // 最終的な値
            changetime                                // アニメーション時間
        ));
            
                
    }
//    public void CC_yellow()
//    {
//        DOTween.To(
//            () => image.color,                // 何を対象にするのか
//            color => image.color = color,    // 値の更新
//            Color.yellow,                    // 最終的な値
//            changetime                                // アニメーション時間
//        );
//    }
    public void CC_white()
    {
        DOTween.To(
            () => image.color,                // 何を対象にするのか
            color => image.color = color,    // 値の更新
            Color.white,                    // 最終的な値
            changetime                                // アニメーション時間
        );
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
