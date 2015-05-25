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
using System.Windows;
using MahApps.Metro.Controls;
using SoundPlayerWpf.Controller;
using SoundPlayerWpf.Dialog;

namespace SoundPlayerWpf
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : MetroWindow
	{
		PlayCore playCore;
		public Window1()
		{
			InitializeComponent();
			playCore = new PlayCore();
		}
		
		void FileChoiceButton_Click(object sender, RoutedEventArgs e)
		{
			var digs = new Dialogs();
			Textbox1.Text = digs.OpenFile();
		}
		
		void SoundPlayButton_Click(object sender, RoutedEventArgs e)
		{
			if(Textbox1.Text != "") playCore.PlaySound(Textbox1.Text);
		}
		
		void SoundStopButton_Click(object sender, RoutedEventArgs e)
		{
			playCore.StopSound();
		}
		
		void LicensesViewButton_Click(object sender, RoutedEventArgs e)
		{
			new Licenses();
		}
	}
}