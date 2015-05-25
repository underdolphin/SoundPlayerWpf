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
using Microsoft.Win32;

namespace SoundPlayerWpf.Dialog
{
	/// <summary>
	/// Description of FileDialog.
	/// </summary>
	public class Dialogs
	{
		public Dialogs()
		{
		}
		
		public string OpenFile()
		{
			string retFileName ="";
			OpenFileDialog ofd1 = new OpenFileDialog();
			ofd1.Title = "Please select Song File";
			ofd1.InitialDirectory = 
				Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic);
			ofd1.FileName = "";
			ofd1.Filter = "wav File|*.wav";
			ofd1.FilterIndex = 2;
			ofd1.RestoreDirectory = true;
			ofd1.Multiselect=true;
			ofd1.ShowReadOnly = true;
			ofd1.ReadOnlyChecked = true;
			Nullable<bool> result = ofd1.ShowDialog();
			if(result == true)
			{
				retFileName = ofd1.FileName;
			}
			return retFileName;
		}
	}
}
