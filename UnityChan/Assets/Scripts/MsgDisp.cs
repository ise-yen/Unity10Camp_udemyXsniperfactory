using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgDisp : MonoBehaviour
{
	public static string msg;
	public static bool flagDisplay = false;
	public GUIStyle guiDisplay;

	private Rect rtDisplay = new Rect();

	// OnGUI는 GUI 이벤트를 렌더링 및 처리하기 위해 호출
	private void OnGUI()
	{
		// GUI 크기: 16:9의 1280 x 720 해상도 기준
		const float guiScreen = 1280;
		const float guiWidth = 800; // 800 x 200 픽셀의 메세지창
		const float guiHeight = 200;
		const float guiLeft = (guiScreen - guiWidth) / 2; // 가운데
		const float guiTop = 720 - guiHeight - 20; // 하단

		// 현재 화면과의 비율
		float gui_scale = Screen.width / guiScreen;

		if (flagDisplay)
		{
			// 글꼴 스타일
			GUIStyle msgFont = new GUIStyle
			{
				fontSize = (int)(30 * gui_scale)
			};

			// 메세지창 위치 계산
			rtDisplay.x = guiLeft * gui_scale;
			rtDisplay.y = guiTop * gui_scale;
			rtDisplay.width = guiWidth * gui_scale;
			rtDisplay.height = guiHeight * gui_scale;

			// 메세지창 출력
			GUI.Box(rtDisplay, "창", guiDisplay);

			// 메세지 그림자 출력
			msgFont.normal.textColor = Color.black;
			rtDisplay.x = (guiLeft + 22) * gui_scale;
			rtDisplay.y = (guiTop + 22) * gui_scale;
			GUI.Label(rtDisplay, msg, msgFont);

			// 메세지 출력
			msgFont.normal.textColor = Color.white;
			rtDisplay.x = (guiLeft + 20) * gui_scale;
			rtDisplay.y = (guiTop + 20) * gui_scale;
			GUI.Label(rtDisplay, msg, msgFont);
		}
	}

	// 외부에서 메세지 받기
	public static void ShowMessage(string msg)
	{
		MsgDisp.msg = msg;
		flagDisplay = true;
	}

	private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
