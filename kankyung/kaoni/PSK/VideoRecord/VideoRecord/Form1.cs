using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Expression.Encoder.ScreenCapture;
using Microsoft.Expression.Encoder.Devices;
using System;
using System.Xml.Linq;
using System.IO;

namespace VideoRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TransparencyKey = Color.White;
            BackColor = Color.White;

            TopLevel = true;

            sc.XMLLoadData();

            Opacity = 0.00;
            ShowInTaskbar = false;
            ButtonEvents();
        }

        private ScreenCapEvents sc = new ScreenCapEvents();     

        private void ButtonEvents()
        {
            var sj = sc.sj;

            PStart.Click += (s, e) =>
                {
                    sc.SetVideoRecord();
                };

            KeyDown += (s, e) =>
                {
                    switch(e.KeyCode)
                    {
                        case Keys.F5:
                            sc.SetVideoRecord();
                            break;

                        case Keys.Escape:
                            if (sj.Status == RecordStatus.Running)
                            {
                                sj.Stop();
                            }
                            break;
                    }
                };

            PStop.Click += (s, e) =>
                {
                    if (sj.Status == RecordStatus.Running)
                    {
                        sj.Stop();
                    }
                };

            FormClosing += (s, e) =>
                {
                    if (sj.Status == RecordStatus.Running)
                    {
                        sj.Stop();
                    }
                };

            PStrip.Opened += (s, e) =>
                {
                    if (WindowState == FormWindowState.Minimized)
                    {
                        CMini.Text = @"원래대로";
                    }
                    else
                        CMini.Text = @"최소화";
                };

            CStart.Click += (s, e) =>
                {
                    sc.SetVideoRecord();
                };

            CStop.Click += (s, e) =>
                {
                    if (sj.Status == RecordStatus.Running)
                    {
                        sj.Stop();
                    }
                };

            CMini.Click += (s, e) =>
                {
                    if(ViewPanel.Size.Width != Screen.PrimaryScreen.Bounds.Width)
                    {
                        if (WindowState == FormWindowState.Minimized)
                        {
                            WindowState = FormWindowState.Normal;
                        }
                        else
                            WindowState = FormWindowState.Minimized;
                    }
                };

            CSetting.Click += (s, e) =>
                {
                    var se = new Setting();
                    se.ShowDialog();
                };

            CExit.Click += (s, e) =>
                {
                    if (sj.Status == RecordStatus.Running)
                    {
                        sj.Stop();
                    }

                    Close();
                };

            /*Load += (s, e) =>
                {
                    switch (sc.WindowMode)
                    {
                        case true:
                            WindowState = FormWindowState.Normal;
                            break;

                        case false:
                            //sc.GetWinModeX = GetFullLocation();
                            WindowState = FormWindowState.Minimized;
                            break;

                        default:
                            //sc.GetWinModeX = GetPanelLocation();
                            WindowState = FormWindowState.Normal;
                            break;
                    }

                };*/
        }

        public Rectangle GetPanelLocation()
        {
            var rc = new Rectangle(ViewPanel.PointToScreen(ViewPanel.ClientRectangle.Location), ViewPanel.Size);

            rc.Width = (rc.Width % 2 == 0) ? rc.Width : rc.Width + 1;
            rc.Height = (rc.Height % 2 == 0) ? rc.Height : rc.Height + 1;

            return rc;
        }

        public Rectangle GetFullLocation()
        {
            var rc = new Rectangle(Screen.PrimaryScreen.Bounds.Location, Screen.PrimaryScreen.Bounds.Size);

            rc.Width = (rc.Width % 2 == 0) ? rc.Width : rc.Width + 1;
            rc.Height = (rc.Height % 2 == 0) ? rc.Height : rc.Height + 1;

            return rc;
        }
    }

    public class ScreenCapEvents 
    {
        public ScreenCaptureJob sj = new ScreenCaptureJob();

        public ScreenCapEvents()
        {
        }

        #region Properties

        public string SavePath { get; set; }
        public string SaveFileName { get; set; }
        public int VideoQuality { get; set; }
        public double VideoFrame { get; set; }
        public bool IsSoundMute { get; set; }
        public bool IsMouseView { get; set; }
        public bool IsSubSoundEnable { get; set; }
        public int FirstAudioDeviceNumber { get; set; }
        public int SecondAudioDeviceNumber { get; set; }
        public bool WindowMode { get; set; }

        #endregion

        public void XMLLoadData()
        {
            if (!File.Exists(Application.StartupPath + @"\Setting.xml")) return;
            var doc = XDocument.Load(Application.StartupPath + @"\Setting.xml");

            var path = from c in doc.Elements("Root").Elements("Setting").Elements("SavaPath") select c;
            foreach(var v in path)
            {
                SavePath = v.Value;
            }

            var quality = from c in doc.Elements("Root").Elements("Setting").Elements("Quality") select c;
            foreach (var v in quality)
            {
                VideoQuality = int.Parse(v.Value);
            }

            var frame = from c in doc.Elements("Root").Elements("Setting").Elements("Frame") select c;
            foreach(var v in frame)
            {
                VideoFrame = double.Parse(v.Value);
            }

            var mute = from c in doc.Elements("Root").Elements("Setting").Elements("Mute") select c;
            foreach (var v in mute)
            {
                IsSoundMute = bool.Parse(v.Value);
            }

            var mouse = from c in doc.Elements("Root").Elements("Setting").Elements("MouseView") select c;
            foreach(var v in mouse)
            {
                IsMouseView = bool.Parse(v.Value);
            }

            var enable = from c in doc.Elements("Root").Elements("Setting").Elements("SubSoundEnable") select c;
            foreach(var v in enable)
            {
                IsSubSoundEnable = bool.Parse(v.Value);
            }

            var mainSound = from c in doc.Elements("Root").Elements("Setting").Elements("MainSound") select c;
            foreach (var v in mainSound)
            {
                FirstAudioDeviceNumber = int.Parse(v.Value);
            }

            var subSound = from c in doc.Elements("Root").Elements("Setting").Elements("SubSound") select c;
            foreach (var v in subSound)
            {
                SecondAudioDeviceNumber = int.Parse(v.Value);
            }

            var winMode = from c in doc.Elements("Root").Elements("Setting").Elements("WinMode") select c;
            foreach (var v in winMode)
            {
                WindowMode = bool.Parse(v.Value);
            } 
        }

        public void SetVideoRecord()
        {
            XMLLoadData();

            var dt = string.Format(@"{0}년 {1}월 {2}일 {3}시 {4}분 {5}초", 
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            sj.OutputPath = SavePath;
            sj.OutputScreenCaptureFileName = SavePath + @"\" + dt + @".wmv"; // 파일 저장 경로..
            sj.ScreenCaptureVideoProfile.Quality = VideoQuality; // 영상 퀄리티
            sj.ScreenCaptureVideoProfile.FrameRate = VideoFrame; // fps 프레임
            sj.CaptureMouseCursor = IsMouseView; // 마우스 표시 여부

            if (IsSoundMute == true)
            {
                sj.RemoveAudioDeviceSource(EncoderDevices.FindDevices(EncoderDeviceType.Audio).ElementAt(FirstAudioDeviceNumber));

                if (IsSubSoundEnable == true)
                {
                    sj.RemoveAudioDeviceSource(EncoderDevices.FindDevices(EncoderDeviceType.Audio).ElementAt(SecondAudioDeviceNumber));
                }
            }
            else
            {
                sj.AddAudioDeviceSource(EncoderDevices.FindDevices(EncoderDeviceType.Audio).ElementAt(FirstAudioDeviceNumber));

                if (IsSubSoundEnable == true)
                {
                    sj.AddAudioDeviceSource(EncoderDevices.FindDevices(EncoderDeviceType.Audio).ElementAt(SecondAudioDeviceNumber));
                }
            }

            sj.Start();// 녹화 하면서 파일 저장 경로 대로 저장..
        }
    }
}
