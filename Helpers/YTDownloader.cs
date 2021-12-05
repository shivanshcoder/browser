using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using YoutubeDLSharp.Helpers;
using System.Text.RegularExpressions;

namespace Browser.Helpers
{
    public partial class YTDownloader : Form
    {
        private YoutubeDLProcess ytdlProc;

        private string youtubeLink;

        private CancellationTokenSource cts = new CancellationTokenSource();

        private static OptionSet options = new OptionSet()
        {
            FfmpegLocation = "./ffmpeg/ffmpeg.exe",
            MergeOutputFormat = DownloadMergeFormat.Mp4,
            NoContinue = true,
            RestrictFilenames = true,
            Format = "best",
            RecodeVideo = VideoRecodeFormat.Mp4,
            Exec = "echo {}",
            Output = "%(title)s-%(id)s.%(ext)s"
        };

        public YTDownloader(string youtubeLink)
        {
            this.youtubeLink = youtubeLink;

            InitializeComponent();
            InitializeYT();
        }

        private async Task getTitle()
        {
            var res = await new YoutubeDL().RunVideoDataFetch(this.youtubeLink);
            nameLabel.Text = res.Data.Title;
        }

        private string getSavePath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath + "\\%(title)s-%(id)s.%(ext)s";
                }
            }

            return "%(title)s-%(id)s.%(ext)s";
        }

        private void InitializeYT()
        {
            progressBar1.Maximum = 100;
            
            
            ytdlProc = new YoutubeDLProcess();


            this.getTitle();

            options.Output = (getSavePath());
        

            ytdlProc.ErrorReceived += (o, e) =>
            {
                var msg = MessageBox.Show("Error", e.Data, MessageBoxButtons.OK);
                this.Close();
                Console.WriteLine("ERROR: " + e.Data);
            };


            var progress_callback = new Progress<DownloadProgress>(p =>
            {
                progressBar1.Value = (int)(p.Progress * 100);
                speedLabel.Text = "Current Speed: " + p.DownloadSpeed;
                timeLabel.Text = "Time Left: " + p.ETA;
                if (p.Progress == 1)
                {
                    MessageBox.Show("@@Success", "Successfully Downloaded video", MessageBoxButtons.OK);
                    this.Close();
                }
                if (p.State == DownloadState.Success)
                {
                    MessageBox.Show("Success", "Successfully Downloaded video",  MessageBoxButtons.OK);
                    this.Close();
                }

            });

            ytdlProc.RunAsync(new string[] { this.youtubeLink }, options, ct: cts.Token, progress: progress_callback);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            this.Close();
        }

        
    }
}
