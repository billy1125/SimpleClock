﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;           // 音效檔播放器函式庫
using System.IO;             // 檔案讀取的IO函式庫


namespace SimpleClock
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            comboboxInitialzation();  // 下拉選單初始化

            timerClcok.Start();       // 啟動時鐘
        }

        List<string> hours = new List<string>();            // 小時清單
        List<string> minutes = new List<string>();          // 分鐘清單   

        private string strSelectTime;                       // 鬧鐘時間設定
        private WaveOutEvent waveOut;                       // 音效檔播放器
        private AudioFileReader audioFileReader;            // 音效檔讀取器


        // 下拉選單初始化
        private void comboboxInitialzation()
        {
            // 設定小時下拉選單的選單內容，建立小時的清單，數字範圍為00-23
            for (int i = 0; i <= 23; i++)
                cmbHour.Items.Add(string.Format("{0:00}", i));
            cmbHour.SelectedIndex = 0;

            // 設定分鐘下拉選單的選單內容，建立分鐘的清單，數字範圍為00-59
            for (int i = 0; i <= 59; i++)
                cmbMin.Items.Add(string.Format("{0:00}", i));
            cmbMin.SelectedIndex = 0;
        }

        private void timerClcok_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            txtWeekDay.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }

        // 鬧鐘計時器timerAlert_tick事件：每一秒執行一次
        private void timerAlert_Tick(object sender, EventArgs e)
        {
            // 判斷現在時間是不是已經是鬧鐘設定時間？如果時間到了，就要播放鬧鐘聲音
            if (strSelectTime == DateTime.Now.ToString("HH:mm"))
            {
                try
                {
                    stopWaveOut();

                    // 指定聲音檔的相對路徑，可以使用MP3
                    string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "alert.wav");

                    // 使用 AudioFileReader 來讀取聲音檔
                    audioFileReader = new AudioFileReader(audioFilePath);

                    // 初始化 WaveOutEvent
                    waveOut = new WaveOutEvent();
                    waveOut.Init(audioFileReader);

                    // 播放聲音檔
                    waveOut.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法播放聲音檔，錯誤資訊: " + ex.Message);
                }
                finally
                {
                    timerAlert.Stop(); // 停止鬧鐘計時器
                }
            }
        }

        // 停止之前的播放
        private void stopWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void btnSetAlert_Click(object sender, EventArgs e)
        {
            timerAlert.Start(); // 啟動鬧鐘計時器
            btnSetAlert.Enabled = false;
            btnCancelAlert.Enabled = true;
            strSelectTime = cmbHour.SelectedItem.ToString() + ":" + cmbMin.SelectedItem.ToString(); // 擷取小時和分鐘的下拉選單文字，用來設定鬧鐘時間
        }

        private void btnCancelAlert_Click(object sender, EventArgs e)
        {
            stopWaveOut();     // 停止之前的播放
            timerAlert.Stop(); // 停止鬧鐘計時器
            btnSetAlert.Enabled = true;
            btnCancelAlert.Enabled = false;
        }

    }
}
