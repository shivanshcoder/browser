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
        // Actual Process that handles video downloading
        private YoutubeDLProcess ytdlProc;

        private string youtubeLink;

        // For cancelling the download task
        private CancellationTokenSource cts = new CancellationTokenSource();

        private static OptionSet options = new OptionSet()
        {
            FfmpegLocation = "./ffmpeg/ffmpeg.exe", // ffmpeg for merging of audio and video
            MergeOutputFormat = DownloadMergeFormat.Mp4, // Final format for our video
            RestrictFilenames = true,
            Format = "best", // Download the best available format
            RecodeVideo = VideoRecodeFormat.Mp4, // Encoding format
            Output = "%(title)s-%(id)s.%(ext)s" // For setting the Destination
        };

        public YTDownloader(string youtubeLink)
        {
            this.youtubeLink = youtubeLink;

            InitializeComponent();

            // No need for resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            // Initialize the Download
            InitializeYT();
        }

        // For Getting the Title of the video
        private async Task getTitle()
        {
            var res = await new YoutubeDL().RunVideoDataFetch(this.youtubeLink);
            nameLabel.Text = res.Data.Title;
        }

        // Get the Save path for downloading the file
        private string getSavePath()
        {
            using (var fbd = new FolderBrowserDialog() { Description = "Please choose the Destination place for video download" })
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
        
            // Incase of error show error window and exit the window
            ytdlProc.ErrorReceived += (o, e) =>
            {
                var msg = MessageBox.Show("Error", e.Data, MessageBoxButtons.OK);
                this.Close();
                Console.WriteLine("ERROR: " + e.Data);
            };

            // Callback for tracking the progress of the download
            var progress_callback = new Progress<DownloadProgress>(p =>
            {
                progressBar1.Value = (int)(p.Progress * 100); // This value  ranges from 0 - 1
                speedLabel.Text = "Current Speed: " + p.DownloadSpeed;
                timeLabel.Text = "Time Left: " + p.ETA;
                if (p.Progress == 1)
                {
                    MessageBox.Show("Success", "Successfully Downloaded video", MessageBoxButtons.OK);
                    this.Close();
                }

            });

            // Start downloading the video
            ytdlProc.RunAsync(new string[] { this.youtubeLink }, options, ct: cts.Token, progress: progress_callback);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            
            cts.Cancel();
        }


    }
}
