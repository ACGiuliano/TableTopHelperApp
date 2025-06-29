namespace TableTopHelper
{
    partial class MainMenuForm
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
            newCharacterButton = new Button();
            loadCharacterButton = new Button();
            newCharacterLabel = new Label();
            loadCharacterLabel = new Label();
            SuspendLayout();
            // 
            // newCharacterButton
            // 
            newCharacterButton.Font = new Font("Josefin Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newCharacterButton.Location = new Point(109, 105);
            newCharacterButton.Name = "newCharacterButton";
            newCharacterButton.Size = new Size(193, 63);
            newCharacterButton.TabIndex = 0;
            newCharacterButton.Text = "New Character";
            newCharacterButton.UseVisualStyleBackColor = true;
            newCharacterButton.Click += newCharacterButton_Click;
            // 
            // loadCharacterButton
            // 
            loadCharacterButton.Font = new Font("Josefin Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadCharacterButton.Location = new Point(109, 208);
            loadCharacterButton.Name = "loadCharacterButton";
            loadCharacterButton.Size = new Size(193, 63);
            loadCharacterButton.TabIndex = 1;
            loadCharacterButton.Text = "Load Character";
            loadCharacterButton.UseVisualStyleBackColor = true;
            // 
            // newCharacterLabel
            // 
            newCharacterLabel.AutoSize = true;
            newCharacterLabel.Font = new Font("Josefin Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newCharacterLabel.Location = new Point(338, 121);
            newCharacterLabel.Name = "newCharacterLabel";
            newCharacterLabel.Size = new Size(225, 31);
            newCharacterLabel.TabIndex = 2;
            newCharacterLabel.Text = "Create a new character";
            // 
            // loadCharacterLabel
            // 
            loadCharacterLabel.AutoSize = true;
            loadCharacterLabel.Font = new Font("Josefin Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadCharacterLabel.Location = new Point(338, 224);
            loadCharacterLabel.Name = "loadCharacterLabel";
            loadCharacterLabel.Size = new Size(255, 31);
            loadCharacterLabel.TabIndex = 3;
            loadCharacterLabel.Text = "Load an existing character";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 410);
            Controls.Add(loadCharacterLabel);
            Controls.Add(newCharacterLabel);
            Controls.Add(loadCharacterButton);
            Controls.Add(newCharacterButton);
            Name = "MainMenuForm";
            Text = "TableTop Helper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newCharacterButton;
        private Button loadCharacterButton;
        private Label newCharacterLabel;
        private Label loadCharacterLabel;
    }
}