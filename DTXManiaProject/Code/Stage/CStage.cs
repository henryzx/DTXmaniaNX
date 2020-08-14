﻿using System;
using System.Collections.Generic;
using System.Text;
using FDK;

namespace DTXMania
{
	public class CStage : CActivity
	{
		// プロパティ

		internal enum EHitJudgement
		{
			PERFECT,
			GREAT,
			GOOD,
			POOR,
			MISS,
			BAD,
			AUTO
		}

		internal EStage eステージID;
		public enum EStage
		{
			DoNothing,
			Startup,
			Title,
			Option,
			Config,
			SongSelection,
			SongLoading,
			Playing,
			Result,
			ChangeSkin,						// #28195 2011.5.4 yyagi
			End
		}
		
		internal EPhase ePhaseID;
		public enum EPhase
		{
			Common_DefaultState,
			Common_FadeIn,
			Common_FadeOut,
			Common_EndStatus,
			起動0_システムサウンドを構築,
			起動00_songlistから曲リストを作成する,
			起動1_SongsDBからスコアキャッシュを構築,
			起動2_曲を検索してリストを作成する,
			起動3_スコアキャッシュをリストに反映する,
			起動4_スコアキャッシュになかった曲をファイルから読み込んで反映する,
			起動5_曲リストへ後処理を適用する,
			起動6_スコアキャッシュをSongsDBに出力する,
			起動7_完了,
			タイトル_起動画面からのフェードイン,
			選曲_結果画面からのフェードイン,
			選曲_NowLoading画面へのフェードアウト,
			NOWLOADING_DTXファイルを読み込む,
			NOWLOADING_WAVファイルを読み込む,
			NOWLOADING_BMPファイルを読み込む,
			NOWLOADING_システムサウンドBGMの完了を待つ,
			演奏_STAGE_FAILED,
			演奏_STAGE_FAILED_フェードアウト,
            演奏_STAGE_CLEAR,
			演奏_STAGE_CLEAR_フェードアウト
		}
        public bool bIsStageFailed;
	}
}
