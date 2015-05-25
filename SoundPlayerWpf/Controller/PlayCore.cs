/*
 * Copyright 2015- underdolphin(masato sueda)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
using System;
using System.Media;

namespace SoundPlayerWpf.Controller
{
	/// <summary>
	/// Description of PlayCore.
	/// </summary>
	public class PlayCore
	{
		SoundPlayer player;
		/// <summary>
		/// this class controller
		/// </summary>
		public PlayCore()
		{
			player = null;
		}
		
		/// <summary>
		/// 与えられたファイルを再生する基本メソッドです
		/// </summary>
		/// <param name="waveFile">音楽ファイルのフルパス名</param>
		public void PlaySound(string waveFile)
		{
			if(player != null) StopSound();
			player = new SoundPlayer(waveFile);
			player.Play();
		}
		
		public void StopSound()
		{
			if(player != null)
			{
				player.Stop();
				player.Dispose();
				player = null;
			}
		}
	}
}
