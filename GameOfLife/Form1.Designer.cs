namespace PA_06
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_Heading = new System.Windows.Forms.MenuStrip();
            this.displaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSetGridRows = new System.Windows.Forms.ToolStripTextBox();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSetGridColumns = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gridOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTooStriplGridColor = new System.Windows.Forms.ToolStripMenuItem();
            this.setCreatureColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEvolSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEvolutionRate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEvolRate = new System.Windows.Forms.ToolStripTextBox();
            this.evolutionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBMIN = new System.Windows.Forms.ToolStripTextBox();
            this.bMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBMAX = new System.Windows.Forms.ToolStripTextBox();
            this.sMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSMIN = new System.Windows.Forms.ToolStripTextBox();
            this.sMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSMAX = new System.Windows.Forms.ToolStripTextBox();
            this.increaseEvolutionRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreseEvolutionRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopEvolutionProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.singleStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeCellStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Help = new System.Windows.Forms.Button();
            this.menuStrip_Heading.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Heading
            // 
            this.menuStrip_Heading.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip_Heading.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Heading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySettingsToolStripMenuItem,
            this.toolStripEvolSetting,
            this.simulationToolStripMenuItem,
            this.generationUpdateToolStripMenuItem,
            this.generationToolStripMenuItem});
            this.menuStrip_Heading.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Heading.Name = "menuStrip_Heading";
            this.menuStrip_Heading.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_Heading.Size = new System.Drawing.Size(544, 24);
            this.menuStrip_Heading.TabIndex = 0;
            this.menuStrip_Heading.Text = "Evolution Settings";
            // 
            // displaySettingsToolStripMenuItem
            // 
            this.displaySettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.toolStripSeparator3,
            this.gridOToolStripMenuItem,
            this.clearGridToolStripMenuItem,
            this.toolStripSeparator2,
            this.setBackgroundColorToolStripMenuItem,
            this.setTooStriplGridColor,
            this.setCreatureColorToolStripMenuItem});
            this.displaySettingsToolStripMenuItem.Name = "displaySettingsToolStripMenuItem";
            this.displaySettingsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.displaySettingsToolStripMenuItem.Text = "Display Settings";
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSetGridRows});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.rowsToolStripMenuItem.Text = "Rows";
            // 
            // toolStripTextBoxSetGridRows
            // 
            this.toolStripTextBoxSetGridRows.Name = "toolStripTextBoxSetGridRows";
            this.toolStripTextBoxSetGridRows.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSetGridRows.Text = "Insert Rows";
            this.toolStripTextBoxSetGridRows.Click += new System.EventHandler(this.toolStripTextBoxSetGridRows_Click);
            this.toolStripTextBoxSetGridRows.TextChanged += new System.EventHandler(this.toolStripTextBoxSetGridRows_TextChanged);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSetGridColumns});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // toolStripTextBoxSetGridColumns
            // 
            this.toolStripTextBoxSetGridColumns.Name = "toolStripTextBoxSetGridColumns";
            this.toolStripTextBoxSetGridColumns.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSetGridColumns.Text = "Insert Columns";
            this.toolStripTextBoxSetGridColumns.Click += new System.EventHandler(this.toolStripTextBoxSetGridColumns_Click);
            this.toolStripTextBoxSetGridColumns.TextChanged += new System.EventHandler(this.toolStripTextBoxSetGridColumns_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // gridOToolStripMenuItem
            // 
            this.gridOToolStripMenuItem.Checked = true;
            this.gridOToolStripMenuItem.CheckOnClick = true;
            this.gridOToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridOToolStripMenuItem.Name = "gridOToolStripMenuItem";
            this.gridOToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gridOToolStripMenuItem.Text = "Toggle Grid On/Off";
            this.gridOToolStripMenuItem.Click += new System.EventHandler(this.gridOToolStripMenuItem_Click);
            // 
            // clearGridToolStripMenuItem
            // 
            this.clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            this.clearGridToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearGridToolStripMenuItem.Text = "Clear Grid";
            this.clearGridToolStripMenuItem.Click += new System.EventHandler(this.clearGridToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // setBackgroundColorToolStripMenuItem
            // 
            this.setBackgroundColorToolStripMenuItem.Name = "setBackgroundColorToolStripMenuItem";
            this.setBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setBackgroundColorToolStripMenuItem.Text = "Set Background Color";
            this.setBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundColorToolStripMenuItem_Click);
            // 
            // setTooStriplGridColor
            // 
            this.setTooStriplGridColor.Name = "setTooStriplGridColor";
            this.setTooStriplGridColor.Size = new System.Drawing.Size(189, 22);
            this.setTooStriplGridColor.Text = "Set Grid Color";
            this.setTooStriplGridColor.Click += new System.EventHandler(this.setTooStriplGridColor_Click);
            // 
            // setCreatureColorToolStripMenuItem
            // 
            this.setCreatureColorToolStripMenuItem.Name = "setCreatureColorToolStripMenuItem";
            this.setCreatureColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setCreatureColorToolStripMenuItem.Text = "Set Creature Color";
            this.setCreatureColorToolStripMenuItem.Click += new System.EventHandler(this.setCreatureColorToolStripMenuItem_Click);
            // 
            // toolStripEvolSetting
            // 
            this.toolStripEvolSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEvolutionRate,
            this.evolutionParametersToolStripMenuItem,
            this.increaseEvolutionRateToolStripMenuItem,
            this.decreseEvolutionRateToolStripMenuItem});
            this.toolStripEvolSetting.Name = "toolStripEvolSetting";
            this.toolStripEvolSetting.Size = new System.Drawing.Size(114, 22);
            this.toolStripEvolSetting.Text = "Evolution Settings";
            // 
            // toolStripMenuItemEvolutionRate
            // 
            this.toolStripMenuItemEvolutionRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEvolRate});
            this.toolStripMenuItemEvolutionRate.Name = "toolStripMenuItemEvolutionRate";
            this.toolStripMenuItemEvolutionRate.Size = new System.Drawing.Size(259, 22);
            this.toolStripMenuItemEvolutionRate.Text = "Set Evolution Rate";
            this.toolStripMenuItemEvolutionRate.Click += new System.EventHandler(this.toolStripMenuItemEvolutionRate_Click);
            // 
            // toolStripEvolRate
            // 
            this.toolStripEvolRate.Name = "toolStripEvolRate";
            this.toolStripEvolRate.Size = new System.Drawing.Size(100, 23);
            this.toolStripEvolRate.Text = "Insert Rate";
            this.toolStripEvolRate.Click += new System.EventHandler(this.toolStripEvolRate_Click);
            this.toolStripEvolRate.TextChanged += new System.EventHandler(this.toolStripEvolRate_TextChanged);
            // 
            // evolutionParametersToolStripMenuItem
            // 
            this.evolutionParametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMINToolStripMenuItem,
            this.bMAXToolStripMenuItem,
            this.sMINToolStripMenuItem,
            this.sMAXToolStripMenuItem});
            this.evolutionParametersToolStripMenuItem.Name = "evolutionParametersToolStripMenuItem";
            this.evolutionParametersToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.evolutionParametersToolStripMenuItem.Text = "Evolution Parameters";
            // 
            // bMINToolStripMenuItem
            // 
            this.bMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxBMIN});
            this.bMINToolStripMenuItem.Name = "bMINToolStripMenuItem";
            this.bMINToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.bMINToolStripMenuItem.Text = "BMIN";
            // 
            // toolStripTextBoxBMIN
            // 
            this.toolStripTextBoxBMIN.Name = "toolStripTextBoxBMIN";
            this.toolStripTextBoxBMIN.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxBMIN.Click += new System.EventHandler(this.bMINToolStripMenuItem_Click);
            this.toolStripTextBoxBMIN.TextChanged += new System.EventHandler(this.bMINToolStripMenuItem_TextChanged);
            // 
            // bMAXToolStripMenuItem
            // 
            this.bMAXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxBMAX});
            this.bMAXToolStripMenuItem.Name = "bMAXToolStripMenuItem";
            this.bMAXToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.bMAXToolStripMenuItem.Text = "BMAX";
            // 
            // toolStripTextBoxBMAX
            // 
            this.toolStripTextBoxBMAX.Name = "toolStripTextBoxBMAX";
            this.toolStripTextBoxBMAX.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxBMAX.Click += new System.EventHandler(this.toolStripTextBoxBMAX_Click);
            this.toolStripTextBoxBMAX.TextChanged += new System.EventHandler(this.toolStripTextBoxBMAX_TextChanged);
            // 
            // sMINToolStripMenuItem
            // 
            this.sMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSMIN});
            this.sMINToolStripMenuItem.Name = "sMINToolStripMenuItem";
            this.sMINToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sMINToolStripMenuItem.Text = "SMIN";
            // 
            // toolStripTextBoxSMIN
            // 
            this.toolStripTextBoxSMIN.Name = "toolStripTextBoxSMIN";
            this.toolStripTextBoxSMIN.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSMIN.Click += new System.EventHandler(this.toolStripTextBoxSMIN_Click);
            this.toolStripTextBoxSMIN.TextChanged += new System.EventHandler(this.toolStripTextBoxSMIN_TextChanged);
            // 
            // sMAXToolStripMenuItem
            // 
            this.sMAXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSMAX});
            this.sMAXToolStripMenuItem.Name = "sMAXToolStripMenuItem";
            this.sMAXToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sMAXToolStripMenuItem.Text = "SMAX";
            // 
            // toolStripTextBoxSMAX
            // 
            this.toolStripTextBoxSMAX.Name = "toolStripTextBoxSMAX";
            this.toolStripTextBoxSMAX.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxSMAX.Click += new System.EventHandler(this.toolStripTextBoxSMAX_Click);
            this.toolStripTextBoxSMAX.TextChanged += new System.EventHandler(this.toolStripTextBoxSMAX_TextChanged);
            // 
            // increaseEvolutionRateToolStripMenuItem
            // 
            this.increaseEvolutionRateToolStripMenuItem.Name = "increaseEvolutionRateToolStripMenuItem";
            this.increaseEvolutionRateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.increaseEvolutionRateToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.increaseEvolutionRateToolStripMenuItem.Text = "Increase Evolution Rate";
            this.increaseEvolutionRateToolStripMenuItem.Click += new System.EventHandler(this.increaseEvolutionRateToolStripMenuItem_Click);
            // 
            // decreseEvolutionRateToolStripMenuItem
            // 
            this.decreseEvolutionRateToolStripMenuItem.Name = "decreseEvolutionRateToolStripMenuItem";
            this.decreseEvolutionRateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.decreseEvolutionRateToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.decreseEvolutionRateToolStripMenuItem.Text = "Decrese Evolution Rate";
            this.decreseEvolutionRateToolStripMenuItem.Click += new System.EventHandler(this.decreseEvolutionRateToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startEToolStripMenuItem,
            this.stopEvolutionProcessToolStripMenuItem,
            this.toolStripSeparator1,
            this.singleStepToolStripMenuItem,
            this.randomizeCellStatesToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // startEToolStripMenuItem
            // 
            this.startEToolStripMenuItem.Name = "startEToolStripMenuItem";
            this.startEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.startEToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.startEToolStripMenuItem.Text = "Start Evolution Process";
            this.startEToolStripMenuItem.Click += new System.EventHandler(this.startEToolStripMenuItem_Click);
            // 
            // stopEvolutionProcessToolStripMenuItem
            // 
            this.stopEvolutionProcessToolStripMenuItem.Name = "stopEvolutionProcessToolStripMenuItem";
            this.stopEvolutionProcessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.stopEvolutionProcessToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.stopEvolutionProcessToolStripMenuItem.Text = "Stop Evolution Process";
            this.stopEvolutionProcessToolStripMenuItem.Click += new System.EventHandler(this.stopEvolutionProcessToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // singleStepToolStripMenuItem
            // 
            this.singleStepToolStripMenuItem.Name = "singleStepToolStripMenuItem";
            this.singleStepToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.singleStepToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.singleStepToolStripMenuItem.Text = "Single-Step Evolution";
            this.singleStepToolStripMenuItem.Click += new System.EventHandler(this.singleStepToolStripMenuItem_Click);
            // 
            // randomizeCellStatesToolStripMenuItem
            // 
            this.randomizeCellStatesToolStripMenuItem.Name = "randomizeCellStatesToolStripMenuItem";
            this.randomizeCellStatesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.randomizeCellStatesToolStripMenuItem.Text = "Randomize Cell States";
            this.randomizeCellStatesToolStripMenuItem.Click += new System.EventHandler(this.randomizeCellStatesToolStripMenuItem_Click);
            // 
            // generationUpdateToolStripMenuItem
            // 
            this.generationUpdateToolStripMenuItem.Name = "generationUpdateToolStripMenuItem";
            this.generationUpdateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.generationUpdateToolStripMenuItem.Text = "Generation Update:";
            // 
            // generationToolStripMenuItem
            // 
            this.generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            this.generationToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.generationToolStripMenuItem.Text = "Generation";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Yellow;
            this.btn_Help.Location = new System.Drawing.Point(494, 1);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(50, 21);
            this.btn_Help.TabIndex = 1;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 359);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.menuStrip_Heading);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip_Heading;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Game Of Life";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip_Heading.ResumeLayout(false);
            this.menuStrip_Heading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Heading;
        private System.Windows.Forms.ToolStripMenuItem toolStripEvolSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEvolutionRate;
        private System.Windows.Forms.ToolStripMenuItem displaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCreatureColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTooStriplGridColor;
        private System.Windows.Forms.ToolStripMenuItem evolutionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopEvolutionProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripEvolRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem randomizeCellStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSetGridRows;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSetGridColumns;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem generationUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBMIN;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBMAX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSMIN;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSMAX;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.ToolStripMenuItem increaseEvolutionRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreseEvolutionRateToolStripMenuItem;
    }
}

