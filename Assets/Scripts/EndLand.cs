using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLand : MonoBehaviour
{
    // 싱글톤 변수
    public static EndLand gm;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    // 게임 상태 상수
    public enum GameState
    {
        Ready,
        Run
    }

    // 현재의 게임 상태 변수
    public GameState gState;

    // 게임 상태 UI 오브젝트 변수
    public GameObject gameLabel;
    public GameObject gamePanel;

    // 게임 상태 UI 텍컴포넌트 변수
    Text gameText;

    void Start()
    {
        // 초기 게임 상태는 준비 상태로 설정한다.
        gState = GameState.Ready;

        // 게임 상태 UI 오브젝트에서 Text 컴포넌트를 가져온다.
        gameText = gameLabel.GetComponent<Text>();

        gameLabel.SetActive(true);
        gamePanel.SetActive(true);

        // 상태 텍스트의 내용을 ‘Ready...’로 한다.
        gameText.text = "~Ending 토끼와 함께~";

        // 게임 준비 -> 게임 중 상태로 전환하기
        StartCoroutine(ReadyToMove());
    }

    IEnumerator ReadyToMove()
    {
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "당신은 토끼의 제안을 받아들였습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "용궁에 돌아가지 않고";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "육지에 남아 토끼와 함께 살게 되었습니다.";
        // 2초간 대기한다.
        yield return new WaitForSeconds(2f);
        // 상태 텍스트의 내용
        gameText.text = "~Ending 토끼와 함께~";
        // 3초간 대기한다.
        yield return new WaitForSeconds(3f);
        // 상태 텍스트를 비활성화한다.
        gameLabel.SetActive(false);
        gamePanel.SetActive(false);
        // 상태를 ‘게임중’ 상태로 변경한다.
        gState = GameState.Run;
    }
}

