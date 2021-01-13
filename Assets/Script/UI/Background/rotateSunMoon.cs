using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UniRx;
using UniRx.Triggers;

public class rotateSunMoon : MonoBehaviour
{
    [SerializeField]
    private float speed=60;
    private GameObject SkyColor;
    private bool Blackchange;
    private ColorChange CC;
    private Sequence sequence;
    
    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        SkyColor=GameObject.Find("Sky");
        CC = SkyColor.GetComponent<ColorChange>();
        
//        Observable.EveryUpdate()
//            .Subscribe(
//                _ => transform.Rotate(new Vector3(0,0,speed))
//            );
//        this.UpdateAsObservable()
//            .Where(_ => gameObject.transform.rotation.z<=-80.0f )
//            .Subscribe(_=> CC.CC_Black());
//        this.UpdateAsObservable()
//            .Where(_ => gameObject.transform.rotation.z==100.0f)
//            .Subscribe(_=> CC.CC_white());
        sequence.Append(gameObject.transform.DORotate(new Vector3(0f, 0, -360f), 3*speed/4, RotateMode.FastBeyond360)
                .SetEase(Ease.Linear))

            //.Append(gameObject.transform.DORotate(new Vector3(0f,0,-120f), speed/3, RotateMode.FastBeyond360).SetEase(Ease.Linear))
            .InsertCallback(speed / 3, () => CC.CC_Black())
            .InsertCallback(3*speed / 4, () => CC.CC_white())
            .SetLoops(-1,LoopType.Restart);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
