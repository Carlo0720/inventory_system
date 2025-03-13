namespace inventory_system
{
    partial class userCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            user_creation_create_Btn = new ReaLTaiizor.Controls.CyberButton();
            close_btn = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // user_creation_create_Btn
            // 
            user_creation_create_Btn.Alpha = 20;
            user_creation_create_Btn.BackColor = Color.Transparent;
            user_creation_create_Btn.Background = true;
            user_creation_create_Btn.Background_WidthPen = 4F;
            user_creation_create_Btn.BackgroundPen = true;
            user_creation_create_Btn.ColorBackground = Color.FromArgb(37, 52, 68);
            user_creation_create_Btn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            user_creation_create_Btn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            user_creation_create_Btn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            user_creation_create_Btn.ColorLighting = Color.FromArgb(29, 200, 238);
            user_creation_create_Btn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            user_creation_create_Btn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            user_creation_create_Btn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            user_creation_create_Btn.Effect_1 = true;
            user_creation_create_Btn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            user_creation_create_Btn.Effect_1_Transparency = 25;
            user_creation_create_Btn.Effect_2 = true;
            user_creation_create_Btn.Effect_2_ColorBackground = Color.White;
            user_creation_create_Btn.Effect_2_Transparency = 20;
            user_creation_create_Btn.Font = new Font("Arial", 11F);
            user_creation_create_Btn.ForeColor = Color.FromArgb(245, 245, 245);
            user_creation_create_Btn.Lighting = false;
            user_creation_create_Btn.LinearGradient_Background = false;
            user_creation_create_Btn.LinearGradientPen = false;
            user_creation_create_Btn.Location = new Point(137, 214);
            user_creation_create_Btn.Name = "user_creation_create_Btn";
            user_creation_create_Btn.PenWidth = 15;
            user_creation_create_Btn.Rounding = true;
            user_creation_create_Btn.RoundingInt = 70;
            user_creation_create_Btn.Size = new Size(108, 36);
            user_creation_create_Btn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            user_creation_create_Btn.TabIndex = 0;
            user_creation_create_Btn.Tag = "Cyber";
            user_creation_create_Btn.TextButton = "Create";
            user_creation_create_Btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            user_creation_create_Btn.Timer_Effect_1 = 5;
            user_creation_create_Btn.Timer_RGB = 300;
            user_creation_create_Btn.Click += user_creation_create_Btn_Click;
            // 
            // close_btn
            // 
            close_btn.Alpha = 20;
            close_btn.BackColor = Color.Transparent;
            close_btn.Background = true;
            close_btn.Background_WidthPen = 4F;
            close_btn.BackgroundPen = true;
            close_btn.ColorBackground = Color.FromArgb(37, 52, 68);
            close_btn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            close_btn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            close_btn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            close_btn.ColorLighting = Color.FromArgb(29, 200, 238);
            close_btn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            close_btn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            close_btn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            close_btn.Effect_1 = true;
            close_btn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            close_btn.Effect_1_Transparency = 25;
            close_btn.Effect_2 = true;
            close_btn.Effect_2_ColorBackground = Color.White;
            close_btn.Effect_2_Transparency = 20;
            close_btn.Font = new Font("Arial", 11F);
            close_btn.ForeColor = Color.FromArgb(245, 245, 245);
            close_btn.Lighting = false;
            close_btn.LinearGradient_Background = false;
            close_btn.LinearGradientPen = false;
            close_btn.Location = new Point(350, 3);
            close_btn.Name = "close_btn";
            close_btn.PenWidth = 15;
            close_btn.Rounding = true;
            close_btn.RoundingInt = 70;
            close_btn.Size = new Size(32, 24);
            close_btn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            close_btn.TabIndex = 1;
            close_btn.Tag = "Cyber";
            close_btn.TextButton = "X";
            close_btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            close_btn.Timer_Effect_1 = 5;
            close_btn.Timer_RGB = 300;
            close_btn.Click += close_btn_Click;
            // 
            // userCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(close_btn);
            Controls.Add(user_creation_create_Btn);
            Name = "userCreationForm";
            Size = new Size(385, 265);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton user_creation_create_Btn;
        private ReaLTaiizor.Controls.CyberButton close_btn;
    }
}