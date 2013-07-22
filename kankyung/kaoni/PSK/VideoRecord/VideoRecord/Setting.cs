using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Expression.Encoder.Devices;

namespace VideoRecord
{
    public partial class Setting : Form
    {
        private ScreenCapEvents sc = new ScreenCapEvents();
        private Form1 fc = new Form1();

        public Setting()
        {
            InitializeComponent();

            SoundDevice();
            SetEvents();
            WEvents();

            sc.XMLLoadData();
            Loaded();
        }

        private void InitEvents()
        {
            if (PDirText.Text != null) return;
            if (PMainSound.Items.Count == -1) return;
            if (PSubSound.Items.Count == -1) return;
        }

        private void SoundDevice()
        {
            var devs = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            var devsNames = devs.Select(p => p.Name).ToList();
            PMainSound.Items.AddRange(devsNames.ToArray());
            PSubSound.Items.AddRange(devsNames.ToArray());
        }

        private void Loaded()
        {
            Load += (s, e) =>
                {
                    if (!File.Exists(Application.StartupPath + @"\Setting.xml")) return;

                    PDirText.Text = sc.SavePath;
                    PMainSound.SelectedIndex = sc.FirstAudioDeviceNumber;
                    PSubSound.SelectedIndex = sc.SecondAudioDeviceNumber;
                    PCkSubSound.Checked = sc.IsSubSoundEnable;
                    PFrame.Value = (decimal)sc.VideoFrame;
                    PQuality.Value = (decimal)sc.VideoQuality;
                    PMute.Checked = sc.IsSoundMute;
                    PMousePointer.Checked = sc.IsMouseView;
                    if (sc.WindowMode == true)
                    {
                        PWindow.Checked = true;
                        PFullMode.Checked = false;
                    }
                    else
                    {
                        PWindow.Checked = false;
                        PFullMode.Checked = true;
                    }
                };
        }

        private void SetEvents()
        {
            PDir.Click += (s, e) =>
                {
                    using (var fe = new FolderBrowserDialog())
                    {
                        if (fe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            PDirText.Text = fe.SelectedPath;
                            sc.SavePath = fe.SelectedPath;
                        }
                    }
                };

            PCkSubSound.CheckedChanged += (s, e) =>
                {
                    switch (PCkSubSound.Checked)
                    {
                        case true:
                            sc.IsSubSoundEnable = true;
                            PSubSound.Enabled = true;
                            break;

                        case false:
                            sc.IsSubSoundEnable = false;
                            PSubSound.Enabled = false;
                            break;

                        default:
                            sc.IsSubSoundEnable = false;
                            PSubSound.Enabled = false;
                            break;
                    }
                };

            PMainSound.SelectedIndexChanged += (s, e) =>
                {
                    if (PMainSound.SelectedIndex == -1) return;
                        sc.FirstAudioDeviceNumber = PMainSound.SelectedIndex;
                };

            PSubSound.SelectedIndexChanged += (s, e) =>
                {
                    if (PSubSound.SelectedIndex == -1) return;
                        sc.SecondAudioDeviceNumber = PSubSound.SelectedIndex;
                };

            PMute.CheckedChanged += (s, e) =>
                {
                    if (PMute.Checked == true)
                    {
                        sc.IsSoundMute = true;
                    }
                    else
                        sc.IsSoundMute = false;
                };

            PMousePointer.CheckedChanged += (s, e) =>
                {
                    if (PMousePointer.Checked == true)
                    {
                        sc.IsMouseView = true;
                    }
                    else
                        sc.IsMouseView = false;
                };

            PFrame.ValueChanged += (s, e) =>
                {
                    if (PFrame.Value > PFrame.Minimum)
                    {
                        sc.VideoFrame = (double)PFrame.Value;
                    }
                    else
                        sc.VideoFrame = (double)PFrame.Minimum;
                };

            PQuality.ValueChanged += (s, e) =>
                {
                    if (PQuality.Value > PQuality.Minimum)
                    {
                        sc.VideoQuality = (int)PQuality.Value;
                    }
                    else
                        sc.VideoQuality = (int)PQuality.Minimum;
                };

            PWindow.CheckedChanged += (s, e) =>
                {
                    if (PWindow.Checked == true)
                    {
                        sc.WindowMode = true;
                    }
                };

            PFullMode.CheckedChanged += (s, e) =>
                {
                    if (PFullMode.Checked == true)
                    {
                        sc.WindowMode = false;
                    }
                };
        }

        private void DefaultEvents()
        {
            InitEvents();

            PDirText.Text = @"";
            sc.SavePath = @"";

            PMainSound.SelectedIndex = -1;
            sc.FirstAudioDeviceNumber = -1;

            PCkSubSound.Checked = false;
            sc.IsSubSoundEnable = false;

            PSubSound.SelectedIndex = -1;
            sc.SecondAudioDeviceNumber = -1;

            PMute.Checked = false;
            sc.IsSoundMute = false;

            PMousePointer.Checked = false;
            sc.IsMouseView = false;

            PFrame.Value = PFrame.Minimum;
            sc.VideoFrame = (double)PFrame.Minimum;

            PQuality.Value = PQuality.Minimum;
            sc.VideoQuality = (int)PQuality.Minimum;

            PWindow.Checked = true;
            PFullMode.Checked = false;
        }

        private void XMLSaveData()
        {
            var doc = new XDocument();
            var root = new XElement("Root");

            var sub = new XElement("Setting");
            sub.Add(new XElement("SavaPath", sc.SavePath));
            sub.Add(new XElement("MainSound", sc.FirstAudioDeviceNumber));
            sub.Add(new XElement("SubSound", sc.SecondAudioDeviceNumber));
            sub.Add(new XElement("Mute", sc.IsSoundMute));
            sub.Add(new XElement("MouseView", sc.IsMouseView));
            sub.Add(new XElement("SubSoundEnable", sc.IsSubSoundEnable));
            sub.Add(new XElement("Frame", sc.VideoFrame));
            sub.Add(new XElement("Quality", sc.VideoQuality));
            sub.Add(new XElement("WinMode", sc.WindowMode));

            root.Add(sub);

            doc.Add(root);

            doc.Save(Application.StartupPath + @"\Setting.xml");
        }

        private void WEvents()
        {
            POk.Click += (s, e) =>
                {
                    InitEvents();
                    SetEvents();
                    XMLSaveData();
                    Close();
                };

            PCancel.Click += (s, e) =>
                {
                    InitEvents();
                    Close();
                };

            PDefault.Click += (s, e) =>
                {
                    DefaultEvents();
                };
        }
    }
}
