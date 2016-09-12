﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using TSM;

public class TSMSample : MonoBehaviour {

    public Button playBGM1;
    public Button playBGM2;
    public Button stopBGM;
    public Button playBGMWithFade1;
    public Button playBGMWithFade2;
    public Button stopBGMWithFade;
    public Button playSE1;
    public Button playSE2;
    public Button playJingle;
    public Button stopJingle;
    public Button pause;

    public SoundManager sm;
    public SimpleRotater cube;
    public Slider masterVolumeSlider;

	void Start () {
        playBGM1.onClick.AddListener(() => {
            sm.PlayBGM("Dysipe_1_loop");
        });

        playBGM2.onClick.AddListener(() => {
            sm.PlayBGM("Fepu");
        });

        stopBGM.onClick.AddListener(() => {
            sm.StopBGM();
        });

        playBGMWithFade1.onClick.AddListener(() => {
            sm.PlayBGMWithFade("Dysipe_1_loop");
        });

        playBGMWithFade2.onClick.AddListener(() => {
            sm.PlayBGMWithFade("Fepu");
        });

        stopBGMWithFade.onClick.AddListener(() => {
            sm.StopBGMWithFade();
        });

        playSE1.onClick.AddListener(() => {
            sm.PlaySE("Heal");
        });

        playSE2.onClick.AddListener(() => {
            sm.PlaySE("Damage");
        });

        playJingle.onClick.AddListener(() => {
            sm.PlayJingle("Notice");
        });

        pause.onClick.AddListener(() => {
            if (!sm.IsPaused) {
                sm.OnPause();
                cube.OnPause();
                pause.GetComponentInChildren<Text>().text = "Resume";
            } else {
                sm.OnResume();
                cube.OnResume();
                pause.GetComponentInChildren<Text>().text = "Pause";
            }
        });

        masterVolumeSlider.onValueChanged.AddListener((value) => {
            sm.MasterVolumeInt = (int)value;
        });

        stopJingle.onClick.AddListener(() => {
            sm.StopJingle();
        });
    }

	void Update () {
	
	}
}
