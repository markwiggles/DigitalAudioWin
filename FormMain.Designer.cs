namespace DigitalAudioConsole
    {
    partial class FormMain
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose( disposing );
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAudioFile = new System.Windows.Forms.TextBox();
            this.buttonLoadAudio = new System.Windows.Forms.Button();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.textBoxXmlFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxDisplayGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayParsedXml = new System.Windows.Forms.CheckBox();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtWaveSave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(83, 109);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio File:";
            // 
            // textBoxAudioFile
            // 
            this.textBoxAudioFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAudioFile.Location = new System.Drawing.Point(92, 24);
            this.textBoxAudioFile.Name = "textBoxAudioFile";
            this.textBoxAudioFile.Size = new System.Drawing.Size(386, 20);
            this.textBoxAudioFile.TabIndex = 2;
            this.textBoxAudioFile.Text = "AudioFiles\\jupiter.wav";
            // 
            // buttonLoadAudio
            // 
            this.buttonLoadAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadAudio.Location = new System.Drawing.Point(484, 24);
            this.buttonLoadAudio.Name = "buttonLoadAudio";
            this.buttonLoadAudio.Size = new System.Drawing.Size(30, 20);
            this.buttonLoadAudio.TabIndex = 3;
            this.buttonLoadAudio.Text = "...";
            this.buttonLoadAudio.UseVisualStyleBackColor = true;
            this.buttonLoadAudio.Click += new System.EventHandler(this.buttonLoadAudio_Click);
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadXml.Location = new System.Drawing.Point(484, 50);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(30, 20);
            this.buttonLoadXml.TabIndex = 6;
            this.buttonLoadXml.Text = "...";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // textBoxXmlFile
            // 
            this.textBoxXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXmlFile.Location = new System.Drawing.Point(92, 50);
            this.textBoxXmlFile.Name = "textBoxXmlFile";
            this.textBoxXmlFile.Size = new System.Drawing.Size(386, 20);
            this.textBoxXmlFile.TabIndex = 5;
            this.textBoxXmlFile.Text = "XmlFiles\\jupiter.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xml File:";
            // 
            // checkBoxDisplayGraph
            // 
            this.checkBoxDisplayGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDisplayGraph.AutoSize = true;
            this.checkBoxDisplayGraph.Checked = true;
            this.checkBoxDisplayGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayGraph.Location = new System.Drawing.Point(344, 109);
            this.checkBoxDisplayGraph.Name = "checkBoxDisplayGraph";
            this.checkBoxDisplayGraph.Size = new System.Drawing.Size(92, 17);
            this.checkBoxDisplayGraph.TabIndex = 7;
            this.checkBoxDisplayGraph.Text = "Display Graph";
            this.checkBoxDisplayGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayParsedXml
            // 
            this.checkBoxDisplayParsedXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDisplayParsedXml.AutoSize = true;
            this.checkBoxDisplayParsedXml.Checked = true;
            this.checkBoxDisplayParsedXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayParsedXml.Location = new System.Drawing.Point(344, 132);
            this.checkBoxDisplayParsedXml.Name = "checkBoxDisplayParsedXml";
            this.checkBoxDisplayParsedXml.Size = new System.Drawing.Size(116, 17);
            this.checkBoxDisplayParsedXml.TabIndex = 8;
            this.checkBoxDisplayParsedXml.Text = "Display Parsed Xml";
            this.checkBoxDisplayParsedXml.UseVisualStyleBackColor = true;
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(448, 149);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(56, 20);
            this.txtThreads.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Threads:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(484, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWaveSave
            // 
            this.txtWaveSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWaveSave.Location = new System.Drawing.Point(92, 76);
            this.txtWaveSave.Name = "txtWaveSave";
            this.txtWaveSave.Size = new System.Drawing.Size(386, 20);
            this.txtWaveSave.TabIndex = 12;
            this.txtWaveSave.Text = "TxtFiles\\jupiter.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Save Wave File:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save Wave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWaveSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.checkBoxDisplayParsedXml);
            this.Controls.Add(this.checkBoxDisplayGraph);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.textBoxXmlFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadAudio);
            this.Controls.Add(this.textBoxAudioFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Digital Audio Console";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAudioFile;
        private System.Windows.Forms.Button buttonLoadAudio;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.TextBox textBoxXmlFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxDisplayGraph;
        private System.Windows.Forms.CheckBox checkBoxDisplayParsedXml;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtWaveSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        }
    }

