﻿namespace SOS_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTextBoxColumn1 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            boardSize = new TextBox();
            label1 = new Label();
            Simple = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            bluePlayer = new Label();
            redPlayer = new Label();
            blueChoiceS = new RadioButton();
            blueChoiceO = new RadioButton();
            redChoiceO = new RadioButton();
            redChoiceS = new RadioButton();
            currentTurnLabel = new Label();
            currentPlayer = new Label();
            newGameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)gameBoard).BeginInit();
            SuspendLayout();
            // 
            // gameBoard
            // 
            gameBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameBoard.ColumnHeadersVisible = false;
            //gameBoard.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            gameBoard.Location = new Point(232, 130);
            gameBoard.Name = "gameBoard";
            gameBoard.RowHeadersVisible = false;
            gameBoard.RowHeadersWidth = 51;
            gameBoard.RowTemplate.Height = 29;
            gameBoard.Size = new Size(300, 188);
            gameBoard.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // boardSize
            // 
            boardSize.Location = new Point(705, 28);
            boardSize.Name = "boardSize";
            boardSize.Size = new Size(47, 27);
            boardSize.TabIndex = 5;
            boardSize.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 31);
            label1.TabIndex = 1;
            label1.Text = "SOS";
            label1.Click += label1_Click;
            // 
            // Simple
            // 
            Simple.AutoSize = true;
            Simple.Location = new Point(123, 27);
            Simple.Name = "Simple";
            Simple.Size = new Size(118, 24);
            Simple.TabIndex = 2;
            Simple.TabStop = true;
            Simple.Text = "Simple game";
            Simple.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(277, 27);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(123, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "General game";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(575, 27);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 4;
            label2.Text = "Board size";
            // 
            // bluePlayer
            // 
            bluePlayer.AutoSize = true;
            bluePlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bluePlayer.Location = new Point(14, 130);
            bluePlayer.Name = "bluePlayer";
            bluePlayer.Size = new Size(108, 28);
            bluePlayer.TabIndex = 6;
            bluePlayer.Text = "Blue player";
            // 
            // redPlayer
            // 
            redPlayer.AutoSize = true;
            redPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            redPlayer.Location = new Point(622, 130);
            redPlayer.Name = "redPlayer";
            redPlayer.Size = new Size(104, 28);
            redPlayer.TabIndex = 7;
            redPlayer.Text = "Red player";
            // 
            // blueChoiceS
            // 
            blueChoiceS.AutoSize = true;
            blueChoiceS.Location = new Point(34, 176);
            blueChoiceS.Name = "blueChoiceS";
            blueChoiceS.Size = new Size(38, 24);
            blueChoiceS.TabIndex = 8;
            blueChoiceS.TabStop = true;
            blueChoiceS.Text = "S";
            blueChoiceS.UseVisualStyleBackColor = true;
            blueChoiceS.CheckedChanged += blueChoiceS_CheckedChanged;
            // 
            // blueChoiceO
            // 
            blueChoiceO.AutoSize = true;
            blueChoiceO.Location = new Point(34, 215);
            blueChoiceO.Name = "blueChoiceO";
            blueChoiceO.Size = new Size(41, 24);
            blueChoiceO.TabIndex = 9;
            blueChoiceO.TabStop = true;
            blueChoiceO.Text = "O";
            blueChoiceO.UseVisualStyleBackColor = true;
            blueChoiceO.CheckedChanged += blueChoiceO_CheckedChanged;
            // 
            // redChoiceO
            // 
            redChoiceO.AutoSize = true;
            redChoiceO.Location = new Point(638, 215);
            redChoiceO.Name = "redChoiceO";
            redChoiceO.Size = new Size(41, 24);
            redChoiceO.TabIndex = 11;
            redChoiceO.TabStop = true;
            redChoiceO.Text = "O";
            redChoiceO.UseVisualStyleBackColor = true;
            // 
            // redChoiceS
            // 
            redChoiceS.AutoSize = true;
            redChoiceS.Location = new Point(638, 176);
            redChoiceS.Name = "redChoiceS";
            redChoiceS.Size = new Size(38, 24);
            redChoiceS.TabIndex = 10;
            redChoiceS.TabStop = true;
            redChoiceS.Text = "S";
            redChoiceS.UseVisualStyleBackColor = true;
            // 
            // currentTurnLabel
            // 
            currentTurnLabel.AutoSize = true;
            currentTurnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentTurnLabel.Location = new Point(278, 385);
            currentTurnLabel.Name = "currentTurnLabel";
            currentTurnLabel.Size = new Size(122, 28);
            currentTurnLabel.TabIndex = 12;
            currentTurnLabel.Text = "Current turn:";
            // 
            // currentPlayer
            // 
            currentPlayer.AutoSize = true;
            currentPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentPlayer.Location = new Point(406, 385);
            currentPlayer.Name = "currentPlayer";
            currentPlayer.Size = new Size(49, 28);
            currentPlayer.TabIndex = 13;
            currentPlayer.Text = "Blue";
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(632, 388);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(94, 29);
            newGameButton.TabIndex = 14;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newGameButton);
            Controls.Add(currentPlayer);
            Controls.Add(currentTurnLabel);
            Controls.Add(redChoiceO);
            Controls.Add(redChoiceS);
            Controls.Add(blueChoiceO);
            Controls.Add(blueChoiceS);
            Controls.Add(redPlayer);
            Controls.Add(bluePlayer);
            Controls.Add(boardSize);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(Simple);
            Controls.Add(label1);
            Controls.Add(gameBoard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gameBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
        private Label label1;
        private RadioButton Simple;
        private RadioButton radioButton2;
        private Label label2;
        private TextBox boardSize;
        private Label bluePlayer;
        private Label redPlayer;
        private RadioButton blueChoiceS;
        private RadioButton blueChoiceO;
        private RadioButton redChoiceO;
        private RadioButton redChoiceS;
        private Label currentTurnLabel;
        private Label currentPlayer;
        private Button newGameButton;
        private DataGridViewButtonColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}