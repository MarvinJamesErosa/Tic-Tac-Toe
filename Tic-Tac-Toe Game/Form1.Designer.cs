﻿namespace Tic_Tac_Toe_Game
{
    partial class gameScreen
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
            this.game_Title = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.gameGrid = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_Title
            // 
            this.game_Title.AutoSize = true;
            this.game_Title.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game_Title.ForeColor = System.Drawing.Color.White;
            this.game_Title.Location = new System.Drawing.Point(87, 21);
            this.game_Title.Name = "game_Title";
            this.game_Title.Size = new System.Drawing.Size(393, 83);
            this.game_Title.TabIndex = 0;
            this.game_Title.Text = "Tic-Tac-Toe";
            this.game_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.gameGrid);
            this.mainContainer.Location = new System.Drawing.Point(117, 190);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(339, 300);
            this.mainContainer.TabIndex = 1;
            // 
            // gameGrid
            // 
            this.gameGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.gameGrid.ColumnCount = 3;
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.gameGrid.Location = new System.Drawing.Point(-9, -11);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.RowCount = 3;
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.Size = new System.Drawing.Size(357, 314);
            this.gameGrid.TabIndex = 0;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(584, 524);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.game_Title);
            this.Name = "gameScreen";
            this.Text = "Tic-Tac-Toe";
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label game_Title;
        private Panel mainContainer;
        private TableLayoutPanel gameGrid;
    }
}