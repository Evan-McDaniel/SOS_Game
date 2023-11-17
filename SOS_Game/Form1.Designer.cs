namespace SOS_Game
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
            gameBoard = new DataGridView();
            boardSize = new TextBox();
            label1 = new Label();
            Simple = new RadioButton();
            General = new RadioButton();
            label2 = new Label();
            blueChoiceS = new RadioButton();
            blueChoiceO = new RadioButton();
            currentTurnLabel = new Label();
            currentPlayer = new Label();
            newGameButton = new Button();
            redBox = new GroupBox();
            redHumanTag = new Label();
            redChoiceO = new RadioButton();
            redChoiceS = new RadioButton();
            redComputerButton = new RadioButton();
            blueBox = new GroupBox();
            label3 = new Label();
            blueComputerButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)gameBoard).BeginInit();
            redBox.SuspendLayout();
            blueBox.SuspendLayout();
            SuspendLayout();
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
            // gameBoard
            // 
            gameBoard.AllowUserToResizeColumns = false;
            gameBoard.AllowUserToResizeRows = false;
            gameBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gameBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameBoard.ColumnHeadersVisible = false;
            gameBoard.Location = new Point(232, 130);
            gameBoard.Name = "gameBoard";
            gameBoard.RowHeadersVisible = false;
            gameBoard.RowHeadersWidth = 51;
            gameBoard.RowTemplate.Height = 29;
            gameBoard.ScrollBars = ScrollBars.None;
            gameBoard.Size = new Size(300, 188);
            gameBoard.TabIndex = 0;
            gameBoard.CellContentClick += gameBoard_CellContentClick;
            // 
            // boardSize
            // 
            boardSize.Location = new Point(705, 28);
            boardSize.Name = "boardSize";
            boardSize.Size = new Size(47, 27);
            boardSize.TabIndex = 5;
            boardSize.Text = "3";
            boardSize.KeyPress += keyPressedBoardSize;
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
            Simple.Checked = true;
            Simple.Location = new Point(123, 27);
            Simple.Name = "Simple";
            Simple.Size = new Size(118, 24);
            Simple.TabIndex = 2;
            Simple.TabStop = true;
            Simple.Text = "Simple game";
            Simple.UseVisualStyleBackColor = true;
            Simple.CheckedChanged += Simple_CheckedChanged;
            // 
            // General
            // 
            General.AutoSize = true;
            General.Location = new Point(277, 27);
            General.Name = "General";
            General.Size = new Size(123, 24);
            General.TabIndex = 3;
            General.Text = "General game";
            General.UseVisualStyleBackColor = true;
            General.CheckedChanged += General_CheckedChanged;
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
            // blueChoiceS
            // 
            blueChoiceS.AutoSize = true;
            blueChoiceS.Checked = true;
            blueChoiceS.Location = new Point(54, 61);
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
            blueChoiceO.Location = new Point(54, 91);
            blueChoiceO.Name = "blueChoiceO";
            blueChoiceO.Size = new Size(41, 24);
            blueChoiceO.TabIndex = 9;
            blueChoiceO.Text = "O";
            blueChoiceO.UseVisualStyleBackColor = true;
            blueChoiceO.CheckedChanged += blueChoiceO_CheckedChanged;
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
            newGameButton.Click += newGameButton_Click;
            // 
            // redBox
            // 
            redBox.Controls.Add(redHumanTag);
            redBox.Controls.Add(redChoiceO);
            redBox.Controls.Add(redChoiceS);
            redBox.Controls.Add(redComputerButton);
            redBox.Location = new Point(571, 130);
            redBox.Name = "redBox";
            redBox.Size = new Size(217, 215);
            redBox.TabIndex = 17;
            redBox.TabStop = false;
            redBox.Text = "Red Player";
            // 
            // redHumanTag
            // 
            redHumanTag.AutoSize = true;
            redHumanTag.Location = new Point(22, 38);
            redHumanTag.Name = "redHumanTag";
            redHumanTag.Size = new Size(57, 20);
            redHumanTag.TabIndex = 4;
            redHumanTag.Text = "Human";
            // 
            // redChoiceO
            // 
            redChoiceO.AutoSize = true;
            redChoiceO.Location = new Point(53, 91);
            redChoiceO.Name = "redChoiceO";
            redChoiceO.Size = new Size(41, 24);
            redChoiceO.TabIndex = 2;
            redChoiceO.Text = "O";
            redChoiceO.UseVisualStyleBackColor = true;
            // 
            // redChoiceS
            // 
            redChoiceS.AutoSize = true;
            redChoiceS.Checked = true;
            redChoiceS.Location = new Point(53, 61);
            redChoiceS.Name = "redChoiceS";
            redChoiceS.Size = new Size(38, 24);
            redChoiceS.TabIndex = 1;
            redChoiceS.TabStop = true;
            redChoiceS.Text = "S";
            redChoiceS.UseVisualStyleBackColor = true;
            // 
            // redComputerButton
            // 
            redComputerButton.AutoSize = true;
            redComputerButton.Location = new Point(31, 123);
            redComputerButton.Name = "redComputerButton";
            redComputerButton.Size = new Size(96, 24);
            redComputerButton.TabIndex = 3;
            redComputerButton.Text = "Computer";
            redComputerButton.UseVisualStyleBackColor = true;
            redComputerButton.CheckedChanged += redComputerButton_CheckedChanged;
            // 
            // blueBox
            // 
            blueBox.Controls.Add(blueChoiceO);
            blueBox.Controls.Add(label3);
            blueBox.Controls.Add(blueChoiceS);
            blueBox.Controls.Add(blueComputerButton);
            blueBox.Location = new Point(12, 130);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(202, 215);
            blueBox.TabIndex = 18;
            blueBox.TabStop = false;
            blueBox.Text = "Blue Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 38);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Human";
            // 
            // blueComputerButton
            // 
            blueComputerButton.AutoSize = true;
            blueComputerButton.Location = new Point(31, 123);
            blueComputerButton.Name = "blueComputerButton";
            blueComputerButton.Size = new Size(96, 24);
            blueComputerButton.TabIndex = 3;
            blueComputerButton.Text = "Computer";
            blueComputerButton.UseVisualStyleBackColor = true;
            blueComputerButton.CheckedChanged += blueComputerButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blueBox);
            Controls.Add(redBox);
            Controls.Add(newGameButton);
            Controls.Add(currentPlayer);
            Controls.Add(currentTurnLabel);
            Controls.Add(boardSize);
            Controls.Add(label2);
            Controls.Add(General);
            Controls.Add(Simple);
            Controls.Add(label1);
            Controls.Add(gameBoard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gameBoard).EndInit();
            redBox.ResumeLayout(false);
            redBox.PerformLayout();
            blueBox.ResumeLayout(false);
            blueBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private RadioButton Simple;
        private RadioButton General;
        private Label label2;
        private TextBox boardSize;
        private RadioButton blueChoiceS;
        private RadioButton blueChoiceO;
        private Label currentTurnLabel;
        private Label currentPlayer;
        private Button newGameButton;
        private DataGridViewButtonColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox redBox;
        private RadioButton redComputerButton;
        private RadioButton redS;
        private RadioButton redChoiceO;
        private RadioButton redChoiceS;
        private Label redHumanTag;
        private GroupBox blueBox;
        private Label label3;
        private RadioButton blueComputerButton;
    }
}